public class Palestra
{
    public string Titulo { get; set; }
    public int Duracao { get; set; } // em minutos
    public bool Relampago { get; set; }

    public Palestra(string titulo, int duracao, bool relampago)
    {
        Titulo = titulo;
        Duracao = duracao;
        Relampago = relampago;
    }
}
