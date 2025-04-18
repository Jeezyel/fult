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
            
            var times = new List<TimeFutebol> 
            { 
                
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
                
            };
            var jogadores = new List<Jogador>
            {
                new Jogador
                {
                    Nome = "João Silva",
                    DataNascimento = new DateTime(1995, 4, 12),
                    Nacionalidade = "Brasileiro",
                    Posicao = Posicao.Atacante,
                    NumeroCamisa = 9,
                    Altura = 1.82,
                    Peso = 78.5,
                    PePreferido = PePreferido.Direito,
                    TimeFutebolId = 1 // Corinthians, por exemplo
                },
                new Jogador
                {
                    Nome = "Carlos Mendes",
                    DataNascimento = new DateTime(1992, 8, 23),
                    Nacionalidade = "Brasileiro",
                    Posicao = Posicao.Zagueiro,
                    NumeroCamisa = 4,
                    Altura = 1.88,
                    Peso = 83.2,
                    PePreferido = PePreferido.Esquerdo,
                    TimeFutebolId = 1 // Flamengo, por exemplo
                }
                // Adicione mais jogadores conforme quiser
            };
            var ComissaoTecnica = new List<ComissaoTecnica>
            {
                new ComissaoTecnica
                {
                    Nome = "André Santos",
                    Cargo = Cargo.Fisioterapeuta,
                    DataNascimento = new DateTime(1975, 6, 15),
                    TimeFutebolId = 1 // Corinthians
                },
                new ComissaoTecnica
                {
                    Nome = "Lucas Oliveira",
                    Cargo = Cargo.Auxiliar,
                    DataNascimento = new DateTime(1980, 11, 3),
                    TimeFutebolId = 1 // Flamengo
                },
                new ComissaoTecnica
                {
                    Nome = "Carla Menezes",
                    Cargo = Cargo.Treinador,
                    DataNascimento = new DateTime(1985, 2, 28),
                    TimeFutebolId = 1 // Corinthians
                }
            };

            var partidas = new List<Partida>
            {
                new Partida
                {
                    DataHora = new DateTime(2024, 5, 12, 16, 0, 0),
                    Estadio = "Neo Química Arena",
                    TimeMandanteId = 1,
                    TimeVisitanteId = 1,
                    GolsMandante = 2,
                    GolsVisitante = 1,
                    Status = StatusPartida.Encerrada
                },
                new Partida
                {
                    DataHora = new DateTime(2024, 5, 20, 19, 30, 0),
                    Estadio = "Morumbi",
                    TimeMandanteId = 1,
                    TimeVisitanteId = 1,
                    GolsMandante = 0,
                    GolsVisitante = 0,
                    Status = StatusPartida.Agendada
                },
                new Partida
                {
                    DataHora = new DateTime(2024, 6, 1, 21, 0, 0),
                    Estadio = "Maracanã",
                    TimeMandanteId = 1,
                    TimeVisitanteId = 1,
                    GolsMandante = 3,
                    GolsVisitante = 2,
                    Status = StatusPartida.Encerrada
                }
            };

        }
        protected void Seed(futTentativaDois.Models.Jogador.JogadorDBContext context)
        {

            
            var jogadores = new List<Jogador>
            {
                new Jogador
                {
                    Nome = "João Silva",
                    DataNascimento = new DateTime(1995, 4, 12),
                    Nacionalidade = "Brasileiro",
                    Posicao = Posicao.Atacante,
                    NumeroCamisa = 9,
                    Altura = 1.82,
                    Peso = 78.5,
                    PePreferido = PePreferido.Direito,
                    TimeFutebolId = 1 // Corinthians, por exemplo
                },
                new Jogador
                {
                    Nome = "Carlos Mendes",
                    DataNascimento = new DateTime(1992, 8, 23),
                    Nacionalidade = "Brasileiro",
                    Posicao = Posicao.Zagueiro,
                    NumeroCamisa = 4,
                    Altura = 1.88,
                    Peso = 83.2,
                    PePreferido = PePreferido.Esquerdo,
                    TimeFutebolId = 1 // Flamengo, por exemplo
                }
                // Adicione mais jogadores conforme quiser
            };
            

           

        }
    }
}
