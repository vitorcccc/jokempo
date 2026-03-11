using System;

class Program
{
    // Variáveis globais para armazenar dados do jogador e estatísticas
    static string nomeJogador = "";
    static int vitorias = 0;
    static int derrotas = 0;
    static int empates = 0;

    // MÉTODO PRINCIPAL - Ponto de entrada do programa
    // Conceito: Método Main é obrigatório em aplicações C#
    static void Main()
    {
        // Configuração para exibir emojis corretamente
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("😀 Olá! Vamos jogar Jokempo?");

        // Chamada do método para gravar nome do jogador
        GravarNomeJogador();

        // Chamada do método do menu principal
        MenuPrincipal();
    }

    // MÉTODO PARA GRAVAR NOME DO JOGADOR
    // Conceito: Método sem retorno (void) que executa uma ação específica
    static void GravarNomeJogador()
    {
        Console.Write("\nDigite seu nome: ");
        nomeJogador = Console.ReadLine();
        Console.WriteLine($"Bem-vindo(a), {nomeJogador}!");
    }

    // MÉTODO DO MENU PRINCIPAL
    // Conceito: Utiliza DO-WHILE para garantir que o menu apareça pelo menos uma vez
    // e SWITCH para navegação entre opções
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

            // Chamada do método de validação
            opcao = ValidarEntrada(Console.ReadLine());

            // ESTRUTURA SWITCH
            // Conceito: Switch para múltiplas condições (mais organizado que vários if/else)
            switch (opcao)
            {
                case 1:
                    Jogar();
                    break; // BREAK - interrompe a execução do switch
                case 2:
                    ImprimirEstatisticas();
                    break;
                case 3:
                    MudarJogador();
                    break;
                case 4:
                    Console.WriteLine($"\n👋 Até mais, {nomeJogador}!");
                    break;
                default: // Caso padrão (nenhuma opção válida)
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            // Aguarda tecla ser pressionada antes de continuar (exceto se for sair)
            if (opcao != 4)
            {
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcao != 4); // WHILE - condição para repetir o menu
    }

    // MÉTODO DE VALIDAÇÃO DE ENTRADA
    // Conceito: Método com RETORNO (int) e parâmetro
    // Utiliza TRY PARSE para validar se a entrada é um número válido
    static int ValidarEntrada(string entrada)
    {
        // int.TryParse tenta converter e retorna true/false
        // OUT - palavra-chave que retorna o valor convertido
        if (int.TryParse(entrada, out int resultado))
        {
            return resultado; // RETURN - retorna o valor válido
        }
        return -1; // RETURN - retorna -1 indicando valor inválido
    }

    // MÉTODO PARA JOGAR
    // Conceito: Organização do jogo principal com DO-WHILE para múltiplas partidas
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

            // Gera jogada aleatória do computador
            // Random - classe para gerar números aleatórios
            var opcaoPC = new Random().Next(3); // Gera 0, 1 ou 2

            // Processa a jogada chamando outro método
            ProcessarJogada(opcao, opcaoPC);

            Console.WriteLine("\n\nQuer jogar de novo?");
            Console.WriteLine("1 - Sim | 0 - Não");
            continuar = Console.ReadKey().KeyChar;

        } while (continuar == '1'); // Continua enquanto jogador digitar 1
    }

    // MÉTODO PARA PROCESSAR A JOGADA
    // Conceito: Utiliza SWITCH para determinar as jogadas
    static void ProcessarJogada(char opcaoJogador, int opcaoPC)
    {
        bool vitoria = false;
        string nomeJogadaJogador = "";
        string nomeJogadaPC = "";

        // SWITCH para jogada do jogador
        // Conceito: Switch com case para cada opção possível
        switch (opcaoJogador)
        {
            case '0':
                nomeJogadaJogador = "Pedra ✊";
                vitoria = (opcaoPC == 2); // Pedra ganha de Tesoura (2)
                break; // BREAK - necessário em cada case
            case '1':
                nomeJogadaJogador = "Papel ✋";
                vitoria = (opcaoPC == 0); // Papel ganha de Pedra (0)
                break;
            case '2':
                nomeJogadaJogador = "Tesoura ✌";
                vitoria = (opcaoPC == 1); // Tesoura ganha de Papel (1)
                break;
            default: // Caso o jogador digite algo diferente de 0,1,2
                Console.WriteLine("\nOpção inválida!");
                return; // RETURN - encerra o método imediatamente
        }

        // SWITCH para jogada do computador
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

        // Exibe as jogadas
        Console.WriteLine($"\n{nomeJogador} jogou: {nomeJogadaJogador}");
        Console.WriteLine($"Computador jogou: {nomeJogadaPC}");

        // Chama método para determinar o resultado
        DeterminarResultado(opcaoJogador, opcaoPC, vitoria);
    }

    // MÉTODO PARA DETERMINAR RESULTADO
    // Conceito: Utiliza ESTRUTURAS CONDICIONAIS (IF/ELSE)
    static void DeterminarResultado(char opcaoJogador, int opcaoPC, bool vitoria)
    {
        // Converte char para int para comparação
        int jogadaJogador = int.Parse(opcaoJogador.ToString());

        // ESTRUTURA IF/ELSE
        // Conceito: Tomada de decisão baseada em condições
        if (jogadaJogador == opcaoPC)
        {
            Console.WriteLine("\n😀 Legal! Nós empatamos!");
            empates++; // Incrementa estatística de empates
        }
        else if (vitoria) // ELSE IF - condição adicional
        {
            Console.WriteLine($"\n😀 Parabéns, {nomeJogador}! Você venceu.");
            vitorias++; // Incrementa estatística de vitórias
        }
        else // ELSE - caso todas as condições anteriores sejam falsas
        {
            Console.WriteLine("\n😀 Haha, eu venci! Não foi dessa vez.");
            derrotas++; // Incrementa estatística de derrotas
        }
    }

    // MÉTODO PARA IMPRIMIR ESTATÍSTICAS
    // Conceito: Método simples para exibir dados acumulados
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

    // MÉTODO PARA MUDAR DE JOGADOR
    // Conceito: PARÂMETRO OPCIONAL com valor padrão
    static void MudarJogador(string mensagem = "Digite o novo nome")
    {
        Console.Clear();
        Console.WriteLine("=== MUDAR JOGADOR ===");
        Console.WriteLine($"Jogador atual: {nomeJogador}");
        Console.WriteLine($"Estatísticas atuais: {vitorias}V | {derrotas}D | {empates}E");

        Console.WriteLine($"\n{mensagem}: ");
        nomeJogador = Console.ReadLine();

        // Reseta estatísticas para o novo jogador
        vitorias = 0;
        derrotas = 0;
        empates = 0;

        Console.WriteLine($"Bem-vindo(a), {nomeJogador}! Suas estatísticas foram resetadas.");
    }
}