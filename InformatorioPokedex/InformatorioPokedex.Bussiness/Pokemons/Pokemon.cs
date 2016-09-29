using InformatorioPokedex.Data.Pokemons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformatorioPokedex.Data
{

    public class Pokemon
    {
        public string Name { get; set; }
        public PokemonType Type { get; set; }
        public string Alias { get; set; }
        public double Wight { get; set; }
        public double Hight { get; set; }



        public Pokemon (string name, PokemonType type, string alias, double weight, double height)
        {
            this.Name = name;
            this.Type = type;
            this.Alias = alias;
            this.Wight = weight;
            this.Hight = height;
        }

        

        public void placaje()
        {
            Console.WriteLine("El poder de placaje fue ejecutado");
        }

        public void gruñido()
        {
            Console.WriteLine("El poder placaje fue ejecutado");
        }
       
    }
   







}
