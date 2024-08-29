using Hl7SampleApplication.Model;
using NHapi.Base.Parser;
using NHapi.Model.V281.Message;

namespace Hl7SampleApplication.Services;

public class Encoder : IEncoder
{
    public string Encode(SuiMessage message)
    {
        var parser = new PipeParser();
        var qry = new NHapi.Model.V281.Message.SIU_S12();

        AssignMsh(message, qry);
        AssignSCH(message, qry);
        AssignPID(message, qry);
        AssignRGS(message, qry);
        AssignAIG(message, qry);
        AssignAIL(message, qry);
        AssignAIP(message, qry);

        //additional fields/properties here...

        return parser.Encode(qry);
    }

    private void AssignMsh(SuiMessage message, NHapi.Model.V281.Message.SIU_S12 qry)
    {
        qry.MSH.MessageType.TriggerEvent.Value = message.Msh.TriggerEvent;
        qry.MSH.MessageType.MessageStructure.Value = message.Msh.MsgStructure;
        qry.MSH.FieldSeparator.Value = message.Msh.FieldSep;
        qry.MSH.SendingApplication.NamespaceID.Value = message.Msh.SendApp;
        qry.MSH.SendingFacility.NamespaceID.Value = message.Msh.SendFac;
        qry.MSH.ReceivingApplication.NamespaceID.Value = message.Msh.RecvApp;
        qry.MSH.ReceivingFacility.NamespaceID.Value = message.Msh.RecvFac;
        qry.MSH.EncodingCharacters.Value = message.Msh.EncChars;
        qry.MSH.VersionID.VersionID.Value = message.Msh.Version;

        qry.MSH.MessageControlID.Value = message.Msh.MsgCtrlId;
        qry.MSH.ProcessingID.ProcessingID.Value = message.Msh.ProcId;
    }
    private void AssignAIP(SuiMessage message, SIU_S12 qry)
    {
        throw new NotImplementedException();
    }

    private void AssignAIL(SuiMessage message, SIU_S12 qry)
    {
        throw new NotImplementedException();
    }

    private void AssignAIG(SuiMessage message, SIU_S12 qry)
    {
        throw new NotImplementedException();
    }

    private void AssignRGS(SuiMessage message, SIU_S12 qry)
    {
        throw new NotImplementedException();
    }

    private void AssignPID(SuiMessage message, SIU_S12 qry)
    {
        throw new NotImplementedException();
    }

    private void AssignSCH(SuiMessage message, NHapi.Model.V281.Message.SIU_S12 qry)
    {
        throw new NotImplementedException();
    }
}
