using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace futTentativaDois.Models
{
    public class Jogador
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Nacionalidade { get; set; }

        public Posicao Posicao { get; set; }

        public int NumeroCamisa { get; set; }

        public double Altura { get; set; } // em metros

        public double Peso { get; set; } // em kg

        public PePreferido PePreferido { get; set; }

        // Relacionamento com Time
        public int TimeFutebolId { get; set; }
        public TimeFutebol Time { get; set; }

        public class JogadorDBContext : DbContext
        {

            public DbSet<Jogador> Jogador { get; set; }
        }
    }
}