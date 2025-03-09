namespace Bolao.Domain.Models
{
	public class HistoricoPontuacao
	{
		public int Id { get; set; } 
		public int JogadorId { get; set; }
		public int RodadaId { get; set; }
		public int PontuacaoRodada { get; set; }
		public int DPRodada { get; set; }

		// Relacionamento: Um histórico pertence a um jogador
		public Jogador Jogador { get; set; }

		// Relacionamento: Um histórico pertence a uma rodada
		public Rodada Rodada { get; set; }
	}
}