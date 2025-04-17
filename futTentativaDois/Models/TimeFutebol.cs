using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace futTentativaDois.Models
{
    public class TimeFutebol
    {

        public int TimeFutebolId { get; set; } // Chave primária

        // Nome do time
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        // Cidade onde o time está localizado
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        // Estado onde o time está localizado
        [Display(Name = "Estado")]
        public string Estado { get; set; }

        // Ano de fundação do time
        [Display(Name = "AnoFundacao")]
        public int AnoFundacao { get; set; }

        // Nome do estádio do time
        [Display(Name = "Estadio")]
        public string Estadio { get; set; }

        // Capacidade do estádio
        [Display(Name = "CapacidadeEstadio")]
        public int CapacidadeEstadio { get; set; }

        // Cores do uniforme
        [Display(Name = "CorPrimaria")]
        public string CorPrimaria { get; set; }

        [Display(Name = "CorSecundaria")]
        public string CorSecundaria { get; set; }

        // Status do time (ex: Ativo, Inativo, etc.)
        [Display(Name = "Status")]
        public string Status { get; set; }




        public class TimeFutebolDBContext : DbContext
        {

            public DbSet<TimeFutebol> TimeFutebol { get; set; }
        }
    }
}