using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformatorioPokedex.Data
{
    public class DataManager
    {
       
       
        public void Add( Pokemon p)
        {
            
            
           PokemonData.Pokemons.Add(p);
                
            
       
        }

        public List<Pokemon> GetAll()
        {
            return PokemonData.Pokemons;
        }


        //agregar pokemons
        //devolver una lista con todos los pokemon registrados hasta el momento
    }
}
