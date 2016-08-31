using InformatorioPokedex.Data.Pokemons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformatorioPokedex.Data
{
    public class Water: Pokemon
    {
        public Water(string name, PokemonType type, string alias, int weithg, int height) : base(name, type, alias, weithg, height)
        {
        }

        public void WaterGun()
        {
            Console.WriteLine("{0} used Water Gun", this.Name);
        }

    }
}
