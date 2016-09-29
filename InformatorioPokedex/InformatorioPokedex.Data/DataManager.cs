using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InformatorioPokedex.Data.PokemonDA;

namespace InformatorioPokedex.Data
{
    public class DataManager
    {
        public PokemonContext PokemonContext { get; set; }

        public DataManager()
        {
            this.PokemonContext = new PokemonContext();
	    }
       
       
        public void Add( Pokemon p)
        {


            this.PokemonContext.Pokemons.Add(p);
            this.PokemonContext.SaveChanges();
                
            
       
        }

        public List<Pokemon> GetAll()
        {
            return this.PokemonContext.Pokemons.ToList();
        }


        //agregar pokemons
        //devolver una lista con todos los pokemon registrados hasta el momento
    }
}
