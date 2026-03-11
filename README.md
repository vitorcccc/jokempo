# JOKEMPO - Pedra, Papel e Tesoura

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Console Application](https://img.shields.io/badge/Console_Application-FF8800?style=for-the-badge&logo=windows-terminal&logoColor=white)

## INTEGRANTES DO GRUPO

| Nome | RM |
|------|-----|
| **Isadora Meneghetti** | RM556326 |
| **Gustavo Ikeda** | RM554718 |
| **Henrique Azevedo** | RM556707 |
| **Renato Alvarenga** | RM556403 |
| **Victoria Moura** | RM555474 |

---

## SOBRE O PROJETO

Este é um jogo de **Jokempo (Pedra, Papel e Tesoura)** desenvolvido em C# como parte das atividades da disciplina. O jogo permite que o usuário jogue contra o computador, com funcionalidades completas de menu, estatísticas e gerenciamento de jogadores.

### Funcionalidades Implementadas

- ✅ Jogar contra o computador (modo aleatório)
- ✅ Gravar nome do jogador
- ✅ Sistema de pontuação (vitórias, derrotas e empates)
- ✅ Estatísticas completas do jogador
- ✅ Trocar de jogador com reset de estatísticas
- ✅ Validação de entrada de dados
- ✅ Menu interativo com opções
- ✅ Emojis para melhor experiência visual

---

## LINK DO REPOSITÓRIO

**Repositório principal:** [https://github.com/isadorameneghetti/jokempo](https://github.com/isadorameneghetti/jokempo)

**Branch do projeto:** `main`

---

## 🧠 CONCEITOS DE C# UTILIZADOS

Este projeto foi desenvolvido aplicando todos os conceitos abordados em aula:

| Conceito | Descrição |
|----------|-----------|
| **Métodos** | Divisão do código em blocos reutilizáveis |
| **Estruturas Condicionais (if/else)** | Tomada de decisão para resultado do jogo |
| **Estruturas Condicionais (switch)** | Navegação do menu e processamento de jogadas |
| **Laços de Repetição (while/do-while)** | Manter o menu ativo e permitir múltiplas jogadas |
| **Instruções de Controle (break)** | Interromper cases do switch |
| **Instruções de Controle (return)** | Encerrar métodos quando necessário |
| **Parâmetros** | Passagem de dados entre métodos |
| **Parâmetro opcional** | Método MudarJogador com mensagem personalizável |
| **Parâmetro out** | Validação de entrada com TryParse |
| **Validação de dados** | Prevenção contra entradas inválidas |

---

## COMO EXECUTAR O PROJETO

### Pré-requisitos
- [.NET SDK](https://dotnet.microsoft.com/download) (6.0 ou superior)
- Visual Studio Code / Visual Studio 2022
- Terminal ou Prompt de Comando

### Passos para executar

1. **Clone o repositório**
```bash
git clone https://github.com/isadorameneghetti/jokempo.git
Acesse a pasta do projeto
```

```bash
cd jokempo
Execute o programa
```

```bash
dotnet run
Ou abra o arquivo .csproj no Visual Studio e pressione F5.
```

## COMO JOGAR
Ao iniciar, digite seu nome

No menu principal, escolha uma opção:

- 1 - Jogar: Inicia uma partida
- 2 - Estatísticas: Visualiza seu desempenho
- 3 - Mudar de Jogador: Troca de usuário (estatísticas resetam)
- 4 - Sair: Encerra o programa

Durante o jogo, escolha:

- 0 - Pedra ✊
- 1 - Papel ✋
- 2 - Tesoura ✌

O computador fará uma jogada aleatória

O resultado é exibido e as estatísticas são atualizadas

Regras do Jogo

- ✊ Pedra ganha de ✌ Tesoura (quebra)

- ✋ Papel ganha de ✊ Pedra (embrulha) 

- ✌ Tesoura ganha de ✋ Papel (corta)

Jogadas iguais resultam em empate


## EXEMPLO DE EXECUÇÃO
```text
=== JOKEMPO - João ===
1 - Jogar
2 - Estatísticas
3 - Mudar de Jogador
4 - Sair
Escolha: 1


João, escolha sua jogada:
0 - Pedra ✊
1 - Papel ✋
2 - Tesoura ✌
Opção: 0

João jogou: Pedra ✊
Computador jogou: Tesoura ✌

😀 Parabéns, João! Você venceu.
📊 ESTATÍSTICAS
O programa mantém um registro completo do desempenho do jogador atual:
```

```text
=== ESTATÍSTICAS ===
Jogador: João
Vitórias: 5
Derrotas: 3
Empates: 2
====================
Ao trocar de jogador, as estatísticas são resetadas automaticamente para o novo usuário.
```

## DISCIPLINA
Estruturas de Controle de Fluxo e Métodos em C#

Professor: Vinícius Costa Santos

FACULDADE FIAP - 2026

## LICENÇA
Este projeto foi desenvolvido para fins educacionais. Todos os direitos reservados aos autores.

