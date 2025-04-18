using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace futTentativaDois.Models
{
    public class Partida
    {
        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}",
        ApplyFormatInEditMode = true)]
        public DateTime DataHora { get; set; }

        public string Estadio { get; set; }

        // Relacionamento com os times
        public int TimeMandanteId { get; set; }
        public TimeFutebol TimeMandante { get; set; }

        public int TimeVisitanteId { get; set; }
        public TimeFutebol TimeVisitante { get; set; }

        // Resultado
        public int GolsMandante { get; set; }
        public int GolsVisitante { get; set; }

        // Status (Futura, Em Andamento, Encerrada)
        public StatusPartida Status { get; set; }

        public class PartidaDBContext : DbContext
        {

            public DbSet<Partida> Partida { get; set; }
        }

        public IEnumerable<SelectListItem> TimesDisponiveis { get; set; }
    }
}