namespace DMSoftwareAPI.Services.Interfaces
{
    public class ApiResponse
    {
        public int StatusCode { get; set; }
        public object Data { get; set; }
        public string ErrorMessage { get; set; }
    }
}
