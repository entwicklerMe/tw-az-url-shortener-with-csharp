using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace EW.URLShortener
{
    public static class ShortURL
    {
        [FunctionName("ShortURL")]
        public static async Task<IActionResult> CreateShortURL(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = "shorturl")]
            HttpRequest req, ILogger log)
        {
            return new OkResult();
        }
    }
}