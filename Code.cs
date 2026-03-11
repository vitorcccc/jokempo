using System;

class Program
{
    static string nomeJogador = "";
    static int vitorias = 0;
    static int derrotas = 0;
    static int empates = 0;

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Olá! Vamos jogar Jokempo?");

        GravarNomeJogador();

        MenuPrincipal();
    }

    static void GravarNomeJogador()
    {
        Console.Write("\nDigite seu nome: ");
        nomeJogador = Console.ReadLine();
        Console.WriteLine($"Bem-vindo(a), {nomeJogador}!");
    }

    static void MenuPrincipal()
    {
        int opcao;

        do
        {
            Console.Clear();
            Console.WriteLine($"=== JOKEMPO - {nomeJogador} ===");
            Console.WriteLine("1 - Jogar");
            Console.WriteLine("2 - Estatísticas");
            Console.WriteLine("3 - Mudar de Jogador");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha: ");

            opcao = ValidarEntrada(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Jogar();
                    break; 
                case 2:
                    ImprimirEstatisticas();
                    break;
                case 3:
                    MudarJogador();
                    break;
                case 4:
                    Console.WriteLine($"\n👋 Até mais, {nomeJogador}!");
                    break;
                default: 
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            if (opcao != 4)
            {
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcao != 4); 
    }

    static int ValidarEntrada(string entrada)
    {
        if (int.TryParse(entrada, out int resultado))
        {
            return resultado; 
        }
        return -1; 
    }

    static void Jogar()
    {
        char continuar;

        do
        {
            Console.Clear();
            Console.WriteLine($"\n{nomeJogador}, escolha sua jogada:");
            Console.WriteLine("0 - Pedra ✊");
            Console.WriteLine("1 - Papel ✋");
            Console.WriteLine("2 - Tesoura ✌");
            Console.Write("Opção: ");

            var opcao = Console.ReadKey().KeyChar;

            var opcaoPC = new Random().Next(3); 

            ProcessarJogada(opcao, opcaoPC);

            Console.WriteLine("\n\nQuer jogar de novo?");
            Console.WriteLine("1 - Sim | 0 - Não");
            continuar = Console.ReadKey().KeyChar;

        } while (continuar == '1'); 
    }

    static void ProcessarJogada(char opcaoJogador, int opcaoPC)
    {
        bool vitoria = false;
        string nomeJogadaJogador = "";
        string nomeJogadaPC = "";

        switch (opcaoJogador)
        {
            case '0':
                nomeJogadaJogador = "Pedra ✊";
                vitoria = (opcaoPC == 2); 
                break; 
            case '1':
                nomeJogadaJogador = "Papel ✋";
                vitoria = (opcaoPC == 0); 
                break;
            case '2':
                nomeJogadaJogador = "Tesoura ✌";
                vitoria = (opcaoPC == 1); 
                break;
            default: 
                Console.WriteLine("\nOpção inválida!");
                return; 
        }

        switch (opcaoPC)
        {
            case 0:
                nomeJogadaPC = "Pedra ✊";
                break;
            case 1:
                nomeJogadaPC = "Papel ✋";
                break;
            case 2:
                nomeJogadaPC = "Tesoura ✌";
                break;
        }

        Console.WriteLine($"\n{nomeJogador} jogou: {nomeJogadaJogador}");
        Console.WriteLine($"Computador jogou: {nomeJogadaPC}");

        DeterminarResultado(opcaoJogador, opcaoPC, vitoria);
    }

    static void DeterminarResultado(char opcaoJogador, int opcaoPC, bool vitoria)
    {
        int jogadaJogador = int.Parse(opcaoJogador.ToString());

        if (jogadaJogador == opcaoPC)
        {
            Console.WriteLine("\n😀 Legal! Nós empatamos!");
            empates++; 
        }
        else if (vitoria) 
        {
            Console.WriteLine($"\n😀 Parabéns, {nomeJogador}! Você venceu.");
            vitorias++; 
        }
        else 
        {
            Console.WriteLine("\n😀 Haha, eu venci! Não foi dessa vez.");
            derrotas++; 
        }
    }

    static void ImprimirEstatisticas()
    {
        Console.Clear();
        Console.WriteLine("=== ESTATÍSTICAS ===");
        Console.WriteLine($"Jogador: {nomeJogador}");
        Console.WriteLine($"Vitórias: {vitorias}");
        Console.WriteLine($"Derrotas: {derrotas}");
        Console.WriteLine($"Empates: {empates}");
        Console.WriteLine("====================");
    }

    static void MudarJogador(string mensagem = "Digite o novo nome")
    {
        Console.Clear();
        Console.WriteLine("=== MUDAR JOGADOR ===");
        Console.WriteLine($"Jogador atual: {nomeJogador}");
        Console.WriteLine($"Estatísticas atuais: {vitorias}V | {derrotas}D | {empates}E");

        Console.WriteLine($"\n{mensagem}: ");
        nomeJogador = Console.ReadLine();

        vitorias = 0;
        derrotas = 0;
        empates = 0;

        Console.WriteLine($"Bem-vindo(a), {nomeJogador}! Suas estatísticas foram resetadas.");
    }
}
