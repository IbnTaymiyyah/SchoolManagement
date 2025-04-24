namespace SchoolManagement.response
{
    public class APIResponse
    {
        public string StatusCode { get; set; }
        public bool IsSuccess { get; set; }
        public List<string> Error { get; set; }
        public object Data { get; set; }

    }
}
