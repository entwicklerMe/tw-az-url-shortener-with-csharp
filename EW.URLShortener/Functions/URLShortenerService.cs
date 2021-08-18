using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using EW.URLShortener.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace EW.URLShortener
{
    public static class URLShortenerService
    {
        [FunctionName("ShortURL")]
        public static async Task<IActionResult> CreateShortURL(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = "shorturl")]
            HttpRequestMessage req, ILogger log)
        {
            var requestBody = await req.Content.ReadAsStringAsync();
            var longUrl = JsonConvert.DeserializeObject<LongUrl>(requestBody);

            return new OkObjectResult(longUrl);
        }
    }
}