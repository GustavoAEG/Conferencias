using System.Collections.Generic;

public class Conferencia
{
    public List<Trilha> Trilhas { get; } = new List<Trilha>();

    public void AdicionarTrilha(Trilha trilha)
    {
        Trilhas.Add(trilha);
    }
    public void ImprimirPrograma()
    {
        foreach (var trilha in Trilhas)
        {
            Console.WriteLine($"Trilha {Trilhas.IndexOf(trilha) + 1}:");
            foreach (var sessao in trilha.Sessoes)
            {
                Console.WriteLine($"Sessão: {sessao.Inicio.ToString("HH:mm")} - {sessao.Fim.ToString("HH:mm")}");
                foreach (var palestra in sessao.Palestras)
                {
                    Console.WriteLine($"- {palestra.Titulo} ({palestra.Duracao} minutos)");
                }
            }
        }
    }
}
