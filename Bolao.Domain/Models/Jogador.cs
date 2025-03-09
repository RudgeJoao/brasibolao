using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolao.Domain.Models
{
	public class Jogador
	{
        public int Id { get; set; }
		public string Nome { get; set; }
        public int Pontuacao { get; set; }
        public int DistanciaPontuacao { get; set; }


		public ICollection<Palpite> Palpites { get; set; } = new List<Palpite>();
	}
}
