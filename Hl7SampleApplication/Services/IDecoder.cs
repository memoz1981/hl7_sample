using Hl7SampleApplication.Model;

namespace Hl7SampleApplication.Services; 

public interface IDecoder
{
    public MdmMessage Decode(string mdmText); 
}
