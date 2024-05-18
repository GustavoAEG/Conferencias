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
            foreach (var palestra in trilha.Sessoes[0].Palestras)
            {
                trilha.Sessoes[0].AdicionarPalestras(palestra);
            }

            // adicionar palestras à sessão da tarde
            Console.WriteLine(
                $"Adicionando palestras à trilha {conferencia.Trilhas.IndexOf(trilha) + 1}: sessão da tarde"
            );
            foreach (var palestra in trilha.Sessoes[1].Palestras)
            {
                trilha.Sessoes[1].AdicionarPalestras(palestra);
            }
        }

        conferencia.ImprimirPrograma();
    }
}
















// Console.WriteLine("Escolha a taboada desejada ou Zero (0) p - Sair");
// string opcao = Console.ReadLine();
// int opcaoInt = int.Parse(opcao);

// int total = 0;

// while(opcaoInt != 0){

// for (int i =0; i < 11; i++){

// total = opcaoInt * i;
//     Console.WriteLine(opcaoInt + " x " + i + " = " + total);
// }
// Console.WriteLine("Escolha a taboada desejada ou Zero (0) p - Sair");

//  opcao = Console.ReadLine();
//  opcaoInt = int.Parse(opcao);
// }
