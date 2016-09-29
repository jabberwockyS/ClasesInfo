using InformatorioPokedex.Bussiness;
using InformatorioPokedex.Data;
using InformatorioPokedex.Data.Pokemons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformatorioPokedex.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokedex = new Pokedex();
            try
            {
                pokedex.RegisterNewPokemon("Pikachu", "Char", PokemonType.Fire, 2.5, 1.33);
                pokedex.ShowPokemonLIst();
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            





        }

     
    }
}
