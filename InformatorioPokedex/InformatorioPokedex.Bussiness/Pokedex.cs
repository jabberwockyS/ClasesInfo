using InformatorioPokedex.Data;
using InformatorioPokedex.Data.Pokemons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformatorioPokedex.Bussiness
{
    public class Pokedex
    {
        public DataManager DataManager { get; set; }

        public Pokedex()
        {
            this.DataManager = new DataManager();
        }

        public void RegisterNewPokemon(string name, string alias, PokemonType type, double weight, double height)
        {
            var newPokemon = new Pokemon(name, type, alias, weight, height);
            if (this.PokemonExists(newPokemon))
            {
                Console.WriteLine("the pokemon {0} already registered", newPokemon.Name);
            }
            else
            {
                var dbPokemon = new InformatorioPokedex.Data.PokemonDA.Pokemon();
                dbPokemon.Name = newPokemon.Name;
                dbPokemon.Type = (InformatorioPokedex.Data.PokemonDA.PokemonType)newPokemon.Type;
                dbPokemon.CaptureDate = DateTime.Today;
                var trainer = new Data.PokemonDA.Trainer();
                trainer.Name = "ash ketchum de pueblo paleta";
                dbPokemon.Trainer = trainer;

                this.DataManager.Add(dbPokemon);
                Console.WriteLine("The pokemon {0} was added successfully", newPokemon.Name);
            }
        }

        public bool PokemonExists(Pokemon p)
        { 
            
            bool retult = false;
            //foreach (Pokemon p1 in PokemonData.Pokemons)
            //{
            //    if (p1.Name == p.Name)
            //    {
            //        retult = true;


            //    }
            //}
            //
           // using linq and lambda like a champion
            retult = this.DataManager.GetAll().Exists(pk => string.Equals(pk.Name, p.Name, StringComparison.OrdinalIgnoreCase));
            return retult;
        
      

        }
         
     
        public void ShowPokemonLIst()
        {
            var pokemos = DataManager.GetAll();
            foreach (InformatorioPokedex.Data.PokemonDA.Pokemon p in pokemos)
            {
                Console.WriteLine(p.Name);
            }
        }
      
        
      }
}
