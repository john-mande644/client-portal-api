namespace ClientPortal_API.Schemas.v1
{    public class API
    {
        public class ErrorResponses
        {
            public ErrorResponse[] errorResponses { get; set; }
        }
        public class ErrorResponse
        {
            public string? errorCode { get; set; }
            public string? errorMessage { get; set; }
            public string? errorDetails { get; set; }
            public string? errorInfoUrl { get; set; }
        }
    }
}
