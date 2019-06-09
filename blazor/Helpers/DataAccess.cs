
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace blazor.Helpers
{
    public class DataAccess
    {
        public DataAccess(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }
        public HttpClient HttpClient { get; set; }

 
        
    }
}