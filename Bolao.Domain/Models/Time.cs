namespace Bolao.Domain.Models
{
	public class Time
	{
		public byte Id { get; set; }
		public string Nome { get; set; }

		// Relacionamento: Um time pode ser time da casa em muitos jogos
		public ICollection<Jogo> JogosComoCasa { get; set; } = new List<Jogo>();

		// Relacionamento: Um time pode ser time visitante em muitos jogos
		public ICollection<Jogo> JogosComoVisitante { get; set; } = new List<Jogo>();
	}
}