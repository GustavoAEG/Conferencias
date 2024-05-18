using System;
using System.Collections.Generic;

public class Trilha
{
    public List<Sessao> Sessoes { get; } = new List<Sessao>();

    public void AdicionarSessao(Sessao sessao)
    {
        Sessoes.Add(sessao);
    }
}
