namespace fult.Migrations
{
    using fult.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;


    internal sealed class Configuration : DbMigrationsConfiguration<TimeFutebol.TimeFutebolDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TimeFutebol.TimeFutebolDBContext context)
        {
            var timeFultbool = new List<TimeFutebol> {
                 new TimeFutebol
                {
                    Nome = "Esporte Clube Vitória",
                    Cidade = "Salvador",
                    Estado = "Bahia",
                    AnoFundacao = 1899,
                    Estadio = "Barradão",
                    CapacidadeEstadio = 30000,
                    CorPrimaria = "Vermelho",
                    CorSecundaria = "Preto",
                    Status = "Ativo"
                },
                new TimeFutebol
                {
                    Nome = "Clube de Regatas do Flamengo",
                    Cidade = "Rio de Janeiro",
                    Estado = "RJ",
                    AnoFundacao = 1895,
                    Estadio = "Maracanã",
                    CapacidadeEstadio = 78838,
                    CorPrimaria = "Vermelho",
                    CorSecundaria = "Preto",
                    Status = "Ativo"
                },
            };

        }
    }
}
