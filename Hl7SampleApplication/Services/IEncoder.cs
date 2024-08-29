using Hl7SampleApplication.Model;

namespace Hl7SampleApplication.Services
{
    public interface IEncoder
    {
        public string Encode(SuiMessage message); 
    }
}
