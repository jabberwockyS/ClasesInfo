using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformatorioPokedex.Data.PokemonDA
{
   public class Trainer
    {
        public int TrainerId { get; set; }
        public String Name { get; set; }


        public virtual ICollection<Pokemon> Pokemons { get; set; }

    }
}
