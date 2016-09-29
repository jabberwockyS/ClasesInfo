using InformatorioPokedex.Data.Pokemons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformatorioPokedex.Data
{
    public class Fuego : Pokemon
    {
        public Fuego(string name, PokemonType type, string alias, int weithg, int height) : base(name, type, alias, weithg, height)
        {
        }

        public void Flamethrower()
        {
            Console.WriteLine("{0} used Flamethrower", this.Name);

        }

    }
}
