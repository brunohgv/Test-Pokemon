using ConstrutoresBadge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntendendoEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string treinador;
            Console.WriteLine("Qual o seu nome, Treinador(a)");
            treinador = Console.ReadLine();
            Console.WriteLine("Bem vindo(a), " + treinador, ", estamos carregando sua pokedex!");
            List<Pokemon> Pokedex = new List<Pokemon>();
            Pokemon Poke = new Pokemon("Bulbasaur", Pokemon.Tipo.Planta, Pokemon.Tipo.Veneno, new Move("Chicote de cipó"));
            Pokedex.Add(Poke);
            
            List<Move> moveSet = Comandos(new List<string> { "Ember", "Tacle", "Scratch", "Metal Claw" });
            Poke = new Pokemon("Charmander", Pokemon.Tipo.Fogo, Pokemon.Tipo.Apenas, moveSet);
            Pokedex.Add(Poke);
            

            Console.WriteLine("Vou listar agora sua pokedex");

            foreach (Pokemon pokemon in Pokedex)
            {
                Console.WriteLine(pokemon.NomePokemon + " tipo: " + pokemon.Elemento.Key + ", " + pokemon.Elemento.Value);
                Console.WriteLine("Vai " + pokemon.NomePokemon + "! ");
                foreach (Move move in pokemon.Movimentos)
                {
                    Console.WriteLine(move.MoveNome);
                }
                Console.WriteLine("Agora!");
            }
        
            if (Pokedex.Count == 0)
            {
                Console.WriteLine("Você ainda não tem nenhum pokémon registrado");
            }
           
            Console.WriteLine("Boa sorte na sua jornada!");
            Console.ReadKey();

            /*
              Treinador, você deverá listar 8 tipos diferentes de pokemons utilizando conceito de classe e Enums,
              para que possamos associar pokemons a eles e possamos obter o seu tipo.

            Exemplo de input e output:
            
            I- Bulbasaur
            O- Planta

            , pidgey, ditto, haunter, rapidash.

            Output
            voador, normal, fantasma, fogo.
            
             */
        }

        public static List<Move> Comandos(List<string> moves) {
            List<Move> moveSet = new List<Move>();

            foreach (string move in moves)
            {
                Move movimento = new Move(move);
                moveSet.Add(movimento);
            }

            return moveSet;
        }
    }
}
