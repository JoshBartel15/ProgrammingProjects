using InClassTogether.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace InClassTogether.Controllers
{
    public class ChuckNorrisJokeController : Controller
    {
        public IActionResult Index()
        {
            ChuckNorrisAPI joke;
            string url = "https://api.chucknorris.io/jokes/random";
            using (var client = new HttpClient())
            {
                  string response = client.GetStringAsync(url).Result;
                    joke = JsonConvert.DeserializeObject<ChuckNorrisAPI>(response);

            }
            return View(joke);
        }
    }
}
