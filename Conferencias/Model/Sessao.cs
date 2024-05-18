using System;
using System.Collections.Generic;

public class Sessao
{
    public List<Palestra> Palestras { get; } = new List<Palestra>();
    public DateTime Inicio { get; }
    public DateTime Fim { get; }

    public Sessao(DateTime inicio, DateTime fim)
    {
        Inicio = inicio;
        Fim = fim;
    }

    public void AdicionarPalestra(Palestra palestra)
    {
        Palestras.Add(palestra);
    }
}
