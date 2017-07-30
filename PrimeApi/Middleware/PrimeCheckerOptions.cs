using Microsoft.AspNetCore.Http;

namespace PrimeApi.Middleware
{
    public class PrimeCheckerOptions
    {
        public PathString Path { get; set; }
    }
}