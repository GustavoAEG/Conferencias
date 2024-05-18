using System;

class Program
{
    static void Main(string[] args)
    {
        Conferencia conferencia = new Conferencia();

        Console.WriteLine("Digite o número de trilhas da conferência:");
        int numeroTrilhas = int.Parse(Console.ReadLine());

        for (int i = 0; i < numeroTrilhas; i++)
        {
            Trilha trilha = new Trilha();
            conferencia.AdicionarTrilha(trilha);
        }

        foreach (Trilha trilha in conferencia.Trilhas)
        {
            // adicionar palestras - sessão da manhã
            Console.WriteLine(
                $"Adicionando palestras à trilha {conferencia.Trilhas.IndexOf(trilha) + 1}: sessão da manhã"
            );
            AdicionarPalestras(trilha.Sessoes[0]);

            // adicionando palestras - sessão da tarde
            Console.WriteLine(
                $"Adicionando palestras à trilha {conferencia.Trilhas.IndexOf(trilha) + 1}: sessão da tarde"
            );
            AdicionarPalestras(trilha.Sessoes[1]);
        }
        conferencia.ImprimirPrograma();
    }

    static void AdicionarPalestras(Sessao sessao)
    {
        while (true)
        {
            Console.WriteLine("Digite o título da palestra (ou 'fim' para encerrar):");
            string titulo = Console.ReadLine();

            if (titulo.ToLower() == "fim")
                break;

            Console.WriteLine("Digite a duração da palestra em minutos:");
            int duracao;
            if (!int.TryParse(Console.ReadLine(), out duracao))
            {
                Console.WriteLine("Duração inválida. Por favor, digite um número.");
                continue;
            }
            else
            {
                Console.WriteLine($"Duração da palestra: {duracao} minutos");
            }
            Console.WriteLine("A palestra é relâmpago? (S/N)");
            bool relampago = Console.ReadLine().ToUpper() == "S";

            Palestra palestra = new Palestra(titulo, duracao, relampago);
            sessao.AdicionarPalestras(palestra);
        }
    }
}
