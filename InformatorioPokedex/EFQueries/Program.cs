using InformatorioPokedex.Data.PokemonDA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFQueries
{
    class Program
    {
        static void Main(string[] args)
        {
            //ef object. access db
            var pokemonContext = new PokemonContext();



            var allPkms = from pokemon 
                          in pokemonContext.Pokemons
                          select pokemon;

            var allPkmsLambda = pokemonContext.Pokemons.Select(x => x);
            //SELECT * FROM Pokemons
            IEnumerable<Pokemon>  filteredPkms = from pokemon 
                               in pokemonContext.Pokemons
                               where pokemon.Trainer.Name.Equals("ash ketchum")
                               select pokemon;
         //   var trainers = from trainer          in pokemonContext.Trainers select trainer;


            
            //select * from Trainers t where name = 'ash ketchum'
            Trainer ash = pokemonContext.Trainers.FirstOrDefault(x => x.Name == "ash ketchum");
            
            //inner join Pokemon  p on p.trainerId = t.trainerId
            foreach (var pk in ash.Pokemons)
            {

                Console.WriteLine(pk.Name);
            }
            // select p.* from Pokemon as p 
            //inner join Trainer as t
            // on p.trainerId = t.traineriD
            //where t.name = "ash ketchum"


           // foreach (Pokemon poke in filteredPkms)
            //{
//Console.WriteLine(poke.Name); 
          //  }


            //get all pokemons  caught  before 23/9 
            var newDate = new DateTime(2016,9,23);
            var pokefecha = pokemonContext.Pokemons.Where(x => x.CaptureDate < newDate);
            foreach (var item in pokefecha)
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadLine();

        }
    }
}
