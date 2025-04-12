using System;

public class ComissaoTecnica
{
    public int Id { get; set; }

    public string Nome { get; set; }

    public Cargo Cargo { get; set; }

    public DateTime DataNascimento { get; set; }

    // Relacionamento com Time
    public int TimeFutebolId { get; set; }
    public TimeFutebol Time { get; set; }
}