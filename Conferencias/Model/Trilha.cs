using System;
using System.Collections.Generic;

public class Trilha
{
    public List<Sessao> Sessoes { get; } = new List<Sessao>();

    public Trilha()
    {
        // Adicionar sessões padrão (manhã e tarde)
        Sessao sessaoManha = new Sessao(DateTime.Today.AddHours(9), DateTime.Today.AddHours(12));
        Sessao sessaoTarde = new Sessao(DateTime.Today.AddHours(13), DateTime.Today.AddHours(17));

        Sessoes.Add(sessaoManha);
        Sessoes.Add(sessaoTarde);
    }
}
