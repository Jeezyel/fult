using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace fult.Models
{
	public class Partida
	{
        public int Id { get; set; }

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
    }
}