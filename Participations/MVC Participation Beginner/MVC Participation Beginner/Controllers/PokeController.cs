using Microsoft.AspNetCore.Mvc;
using MVC_Participation_Beginner.Models;
using Newtonsoft.Json;
using System.Configuration;
using static MVC_Participation_Beginner.Models.PokeAPI;

namespace MVC_Participation_Beginner.Controllers
{
    public class PokeController : Controller
    {
        public IActionResult Index()
        {
            using (var client = new HttpClient())
            {
                string url = "https://pokeapi.co/api/v2/pokemon?limit=100";
                string json = client.GetStringAsync(url).Result;

                PokeAPI pokeList = JsonConvert.DeserializeObject<PokeAPI>(json);
                foreach (Poke poke in pokeList.results)
                {
                    string pokeJson = client.GetStringAsync(poke.url).Result;
                    sprites pokeImg = JsonConvert.DeserializeObject<sprites>(pokeJson);
                    poke.url = pokeImg.front_default;
                }
                return View(pokeList);
            }
        }

        public IActionResult Details(string url)
        {
            using (var client = new HttpClient())
            {
                Poke poke1 = new Poke();
                string json = client.GetStringAsync(poke1.url).Result;
                Poke poke = JsonConvert.DeserializeObject<Poke>(json);
                return View(poke);
            }
        }
    }
}
