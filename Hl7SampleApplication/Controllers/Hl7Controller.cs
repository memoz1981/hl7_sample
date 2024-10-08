﻿using Hl7SampleApplication.Model;
using Hl7SampleApplication.Services;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Hl7SampleApplication.Controllers; 

[Route("api/[controller]")]
[ApiController]
public class Hl7Controller : ControllerBase
{
    private readonly ILogger<Hl7Controller> _logger;
    private readonly IEncoder _encoder; 
    private readonly IDecoder _decoder;

    public Hl7Controller(ILogger<Hl7Controller> logger, IEncoder encoder, IDecoder decoder)
    {
        _logger = logger;
        _encoder = encoder;
        _decoder = decoder;
    }

    [HttpPost]
    [Route("[action]")]
    public async Task<IActionResult> SendAppointment(string jsonText)
    {
        try
        {
            var message = JsonSerializer.Deserialize<SuiMessage>(jsonText);

            var result = _encoder.Encode(message);

            //async database operations here... 
            await Task.CompletedTask; 

            return Ok(result); 
        }
        catch (JsonException ex) //just a sample - need to manage json exceptions separately
        {
            _logger.LogError(ex.ToString()); 
            return BadRequest("Data could not be deserialized to json..."); 
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.ToString());
            return StatusCode(500, "Some error occured, see the logs..."); 
        }
    }

    [HttpPost]
    [Route("[action]")]
    public async Task<IActionResult> SendMedicalRecord(string mdmText)
    {
        try
        {
            var result = _decoder.Decode(mdmText);

            //async database operations here... 
            await Task.CompletedTask;

            return Ok(result);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.ToString());
            return StatusCode(500, "Some error occured, see the logs...");
        }
    }
}
