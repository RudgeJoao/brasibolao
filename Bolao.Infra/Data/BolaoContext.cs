using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bolao.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Bolao.Infra.Data
{
	public class BolaoContext : DbContext
	{
        public DbSet<Jogador> Jogadores { get; set; }
        public DbSet<Time> Times { get; set; }
		public DbSet<Rodada> Rodadas { get; set; }
		public DbSet<Jogo> Jogos { get; set; }
		public DbSet<Palpite> Palpites { get; set; }
		public DbSet<HistoricoPontuacao> HistoricoPontuacoes { get; set; }

		public BolaoContext(DbContextOptions<BolaoContext> options) : base(options)
		{
		}
	}
}
