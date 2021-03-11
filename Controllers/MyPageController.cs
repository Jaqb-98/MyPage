using Microsoft.AspNetCore.Mvc;
using MyPage.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyPage.Controllers
{
    public class MyPageController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            var path = $"https://api.unsplash.com/search/photos?query=landscape&orientation=landscape&client_id=E3Z-yJwAb5S-OkQHdGlBDtyfCmhQM1jgvCVARO1_9Bk&per_page=5";
            var response = await client.GetAsync(path);

            if (response.IsSuccessStatusCode)
            {
                var responseStr = await response.Content.ReadAsStringAsync();

                var photosData = JsonConvert.DeserializeObject<JObject>(responseStr);

                var results = photosData.Value<JArray>("results").ToString();

                var result = JsonConvert.DeserializeObject<PhotoData[]>(results);

                var rssItems = LoadRssItems().OrderBy(x => Guid.NewGuid()).Take(4).ToList();

                var pagemodel = new PageModel { PhotoData = result, RssItems = rssItems };

                return View(pagemodel);
            }
            return View();
        }

        public List<RssItem> GetRssItems(string url)
        {
            var xml = XElement.Load(url);

            var items = xml.Descendants("item").Select(n => new RssItem
            {
                Title = n.Element("title").Value,
                Description = n.Element("description").Value,
                PubDate = n.Element("pubDate").Value,
            }).ToList();

            return items;
        }

        public List<RssItem> LoadRssItems()
        {
            var urls = new List<string>();

            urls.Add("https://news.google.com/rss?hl=pl&gl=PL&ceid=PL:pl");
            urls.Add("https://wydarzenia.interia.pl/feed");
            urls.Add("https://news.google.com/rss?topstories?hl=en-US&gl=US&ceid=US:en&hl=en-US");

            var rssList = new List<RssItem>();

            foreach (var url in urls)
            {
                rssList.AddRange(GetRssItems(url));
            }

            return rssList;

        }
    }
}
