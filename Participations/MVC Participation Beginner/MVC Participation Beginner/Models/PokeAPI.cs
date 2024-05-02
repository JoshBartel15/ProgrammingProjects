namespace MVC_Participation_Beginner.Models
{
    public class PokeAPI
    {
        public List<Poke> results { get; set; }
    }
        public class Poke
        {
            public string name { get; set; }

            public string url { get; set; }

            public override string ToString()
            {
                return name;
            }
        }
        public class sprites
        {
            public string front_default { get; set; }
        }
    }