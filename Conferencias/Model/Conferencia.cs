using System.Collections.Generic;

public class Conferencia
{
    public List<Trilha> Trilhas { get; } = new List<Trilha>();

    public void AdicionarTrilha(Trilha trilha)
    {
        Trilhas.Add(trilha);
    }
}
