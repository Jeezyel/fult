using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace fult.Models
{
    public class TimeFutebol
    {

        public int TimeFutebolId { get; set; } // Chave primária
                                               // Nome do time
        public string Nome { get; set; }

        // Cidade onde o time está localizado
        public string Cidade { get; set; }

        // Estado onde o time está localizado
        public string Estado { get; set; }

        // Ano de fundação do time
        public int AnoFundacao { get; set; }

        // Nome do estádio do time
        public string Estadio { get; set; }

        // Capacidade do estádio
        public int CapacidadeEstadio { get; set; }

        // Cores do uniforme
        public string CorPrimaria { get; set; }
        public string CorSecundaria { get; set; }

        // Status do time (ex: Ativo, Inativo, etc.)
        public string Status { get; set; }




        public class TimeFutebolDBContext : DbContext
        {
            public TimeFutebolDBContext() : base("TimeFutebolDBContext") // nome da connection string
            {
            }
            public DbSet<TimeFutebol> TimeFutebol { get; set; }
        }
    }
}