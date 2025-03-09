namespace Bolao.Domain.Models
{
	public class Rodada
	{
        public int Id { get; set; }
        public int Numero { get; set; }
        public DateTime DataInicio{ get; set; }

		// Relacionamento: Uma rodada pode ter muitos jogos
		public ICollection<Jogo> Jogos { get; set; } = new List<Jogo>();

		// Relacionamento: Uma rodada pode ter muitos históricos de pontuação
		public ICollection<HistoricoPontuacao> HistoricoPontuacoes { get; set; } = new List<HistoricoPontuacao>();
	}
}