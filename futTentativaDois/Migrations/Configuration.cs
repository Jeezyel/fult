namespace futTentativaDois.Migrations
{
    using futTentativaDois.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<futTentativaDois.Models.TimeFutebol.TimeFutebolDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(futTentativaDois.Models.TimeFutebol.TimeFutebolDBContext context)
        {

            //var times = new List<TimeFutebol> 
            modelBuilder.Entity<TimeFutebol>().HasData(
                //{ 
                
                    new TimeFutebol
                    {
                        Nome = "Corinthians",
                        Cidade = "São Paulo",
                        Estado = "SP",
                        AnoFundacao = 1910,
                        Estadio = "Neo Química Arena",
                        CapacidadeEstadio = 49305,
                        CorPrimaria = "Preto",
                        CorSecundaria = "Branco",
                        Status = "Ativo"
                    },
                    new TimeFutebol
                    {
                        Nome = "Flamengo",
                        Cidade = "Rio de Janeiro",
                        Estado = "RJ",
                        AnoFundacao = 1895,
                        Estadio = "Maracanã",
                        CapacidadeEstadio = 78838,
                        CorPrimaria = "Vermelho",
                        CorSecundaria = "Preto",
                        Status = "Ativo"
                    }
                // Adicione mais times aqui se quiser
                );
            //};
        }
    }
}
