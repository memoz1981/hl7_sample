using Hl7SampleApplication.Model;
using NHapi.Base.Parser;
using NHapi.Model.V281.Message;

namespace Hl7SampleApplication.Services;

public class Decoder : IDecoder
{
    public MdmMessage Decode(string mdmText)
    {
        var parser = new PipeParser();

        var mdm = (NHapi.Model.V281.Message.MDM_T02)parser.Parse(mdmText);

        var message = new MdmMessage();
        message.Msh = ExtractMsh(mdm);

        //extract other segments and build the object

        return message; 
    }

    private MshSegment ExtractMsh(MDM_T02 mdm)
    {
        var msh = new MshSegment();
        msh.TriggerEvent = mdm.MSH.MessageType.TriggerEvent.Value;

        //populate other properties...

        return msh; 
    }
}
