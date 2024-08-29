namespace Hl7SampleApplication.Model
{
    public record SuiMessage
    {
        public MshSegment Msh { get; set; }
    }

    public record MshSegment
    {
        public string MsgType { get; set; }
        public string TriggerEvent { get; set; }
        public string MsgStructure { get; set; }
        public string FieldSep { get; set; }
        public string SendApp { get; set; }
        public string SendFac { get; set; }
        public string RecvApp { get; set; }
        public string RecvFac { get; set; }
        public string EncChars { get; set; }
        public string Version { get; set; }
        public DateTime MsgDateTime { get; set; }
        public string MsgCtrlId { get; set; }
        public string ProcId { get; set; }
    }
}
