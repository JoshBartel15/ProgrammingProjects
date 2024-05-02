using Microsoft.AspNetCore.Mvc;
using MVC_Participation_Beginner.Models;
using Newtonsoft.Json;

namespace MVC_Participation_Beginner.Controllers
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
