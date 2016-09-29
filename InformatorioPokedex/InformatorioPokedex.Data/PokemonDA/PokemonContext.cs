using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformatorioPokedex.Data.PokemonDA
{
    public class PokemonContext: DbContext
    {
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Pokemon> Pokemons { get; set; }

        public PokemonContext()
            :base("PokemonContext")
        {

        }
    }
}
