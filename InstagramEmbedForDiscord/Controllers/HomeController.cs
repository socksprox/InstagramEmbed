using InstagramEmbedForDiscord.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Text.Json.Serialization;

namespace InstagramEmbedForDiscord.Controllers
{
    [Route("p/{id}")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index(string id)
        {
            try
            {
                string link = "https://instagram.com/p/" + id;

                string contentUrl = string.Empty;
                string thumbnailUrl = string.Empty;

                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetAsync("http://alsauce.com:3100/igdl?url=" + link);
                    var responseString = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<InstagramResponse>(responseString)!;

                    contentUrl=result.url.data.FirstOrDefault()?.url ?? string.Empty;
                    thumbnailUrl=result.url.data.FirstOrDefault()?.thumbnail ?? string.Empty;

                    var request = new HttpRequestMessage(HttpMethod.Get, contentUrl);
                    //request.Headers.Range = new RangeHeaderValue(0, 1023);
                    var contentTypeResponse = await client.SendAsync(request);
                    
                    var contentDisposition = contentTypeResponse.Content.Headers.ContentDisposition;
                    ViewBag.IsPhoto=contentDisposition != null && contentDisposition.FileName != null && !contentDisposition.FileName.EndsWith(".mp4", StringComparison.OrdinalIgnoreCase);

                }

                string[] data = { contentUrl, thumbnailUrl, link };
                 return View(data);
            }

            catch (Exception e)
            {
                return View(new { });

            }
        }

        
    }


    public class InstagramResponse
    {
        public UrlData url { get; set; }
    }

    public class UrlData
    {
        public string developer { get; set; }
        public bool status { get; set; }
        public List<InstagramMedia> data { get; set; }
    }

    public class InstagramMedia
    {
        public string thumbnail { get; set; }
        public string url { get; set; }
    }

}
