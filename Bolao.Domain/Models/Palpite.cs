using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolao.Domain.Models
{
	public class Palpite
	{
		public int Id { get; set; }
        public int JogadorId { get; set; }
        public int JogoId { get; set; }
		public int PalpiteGolsTimeCasa { get; set; }
        public int PalpiteGolsTimeFora { get; set; }
        public int Pontuacao { get; set; }
        public int DistanciaPontuacao { get; set; }

		// Relacionamento: Um palpite pertence a um jogador
		public Jogador Jogador{ get; set; }

		// Relacionamento: Um palpite pertence a um jogo
		public Jogo Jogo { get; set; }
	}
}
