using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioFigura.src
{
	public class Garrafa
	{
        public string Personagem { get; set; }
		public string Cor { get; set; }

		public string Tamanho { get; set; }

		public string Formato { get; set; }

        public Garrafa()
        {

        }

        public Garrafa(string personagem, string cor, string tamanho, string formato)
        {
            Personagem = personagem;
            Cor = cor;
            Tamanho = tamanho;
            Formato = formato;
        }
        public string Tostring()
        {
            return $"Personagem: {Personagem} \n" +
                   $"Cor: {Cor} \n" +
                   $"Tamanho: {Tamanho} \n" +
                   $"Formato: {Formato} \n";

        }

        
    }
		
}
