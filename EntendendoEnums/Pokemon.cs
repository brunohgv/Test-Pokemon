using ConstrutoresBadge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntendendoEnums
{
    public class Pokemon
    {
        public Pokemon()
        {
            this.Movimentos = new List<Move>();
        }

        public Pokemon(string nomePokemon, Tipo tipo1, Tipo tipo2)
        {
            this.NomePokemon = nomePokemon;
            this.Elemento = new KeyValuePair<Pokemon.Tipo, Pokemon.Tipo>(tipo1, tipo2);
            this.Movimentos = new List<Move>();
        }

        public Pokemon(string nomePokemon, Tipo tipo1, Tipo tipo2, Move move1)
        {
            this.NomePokemon = nomePokemon;
            this.Elemento = new KeyValuePair<Pokemon.Tipo, Pokemon.Tipo>(tipo1, tipo2);
            this.Movimentos = new List<Move>() { move1 };
        }

        public Pokemon(string nomePokemon, Tipo tipo1, Tipo tipo2, List<Move> moves)
        {
            this.NomePokemon = nomePokemon;
            this.Elemento = new KeyValuePair<Pokemon.Tipo, Pokemon.Tipo>(tipo1, tipo2);
            this.Movimentos = moves;
        }



        public enum Tipo
        {
            Agua, Fogo, Planta, Voador, Normal, Fantasma, Fada, Psiquico, Veneno, Apenas
        }



        public string NomePokemon { get; set; }
        public KeyValuePair<Tipo, Tipo> Elemento { get; set; }
        public List<Move> Movimentos { get; set; }



        
    }

}
