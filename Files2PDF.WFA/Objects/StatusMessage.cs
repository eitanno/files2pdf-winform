namespace Files2PDFWFA.Objects
{
    public class StatusMessage
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }

        public string Url { get; set; }

        public StatusMessage(bool isSuccess, string message, string url)
        {
            IsSuccess = isSuccess;
            Message = message;
            Url = url;
        }
    }
}
