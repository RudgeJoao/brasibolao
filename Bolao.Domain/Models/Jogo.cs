namespace Bolao.Domain.Models
{
	public class Jogo
	{
        public int Id { get; set; }
        public int RodadaId { get; set; }
        public byte TimeCasaId { get; set; }
        public byte TimeVisitanteId { get; set; }
        public int? GolsTimeCasa { get; set; }
		public int? GolsTimeVisitante { get; set; }

		// Relacionamento: Um jogo pertence a uma rodada
		public Rodada Rodada { get; set; }

		// Relacionamento: Um jogo tem um time da casa
		public Time TimeCasa { get; set; }

		// Relacionamento: Um jogo tem um time visitante
		public Time TimeVisitante { get; set; }

		// Relacionamento: Um jogo pode ter muitos palpites
		public ICollection<Palpite> Palpites { get; set; } = new List<Palpite>();
	}
}