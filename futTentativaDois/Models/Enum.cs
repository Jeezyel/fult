using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace futTentativaDois.Models
{
    public enum Posicao
    {
        Goleiro,
        Zagueiro,
        Lateral,
        Volante,
        Meia,
        Atacante
    }

    public enum PePreferido
    {
        Direito,
        Esquerdo,
        Ambidestro
    }

    public enum Cargo
    {
        Treinador,
        Auxiliar,
        PreparadorFisico,
        Fisiologista,
        TreinadorGoleiros,
        Fisioterapeuta
    }

    public enum StatusPartida
    {
        Agendada,
        EmAndamento,
        Encerrada
    }
}