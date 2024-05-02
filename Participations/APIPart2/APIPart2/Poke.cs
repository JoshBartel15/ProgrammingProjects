using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIPart2
{
    public class PokeList
    {
        public List<Pokemon> results { get; set; }

    }
    internal class Poke
    {
        public string name { get; set; }
        public Sprites sprites { get; set; }

        public int height { get; set; }
        public int weight { get; set; }
    }

    public class Pokemon
    {
        public string name { get; set; }
        public string url { get; set; }

        public override string ToString()
        {
            return name;
        }
    }
    public class Sprites
    {
        public string back_default { get; set; }
        public string front_default { get; set; }
    }
}
