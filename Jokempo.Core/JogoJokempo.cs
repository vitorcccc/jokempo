using System;

namespace Jokempo.Core
{
    public class JogoJokempo
    {
        private readonly Random _random;
        public Jogador Jogador { get; private set; }

        public JogoJokempo(string nomeJogador)
        {
            _random = new Random();
            Jogador = new Jogador(nomeJogador);
        }

        public ResultadoRodada Jogar(Jogada jogadaJogador)
        {
            int opcaoPC = _random.Next(3);
            Jogada jogadaComputador = (Jogada)opcaoPC;

            string nomeJogadaJogador = ObterNomeJogada(jogadaJogador);
            string nomeJogadaComputador = ObterNomeJogada(jogadaComputador);

            ResultadoJogo resultado = DeterminarResultado(jogadaJogador, jogadaComputador);

            Jogador.Estatisticas.RegistrarResultado(resultado);

            return new ResultadoRodada
            {
                NomeJogador = Jogador.Nome,
                NomeJogadaJogador = nomeJogadaJogador,
                NomeJogadaComputador = nomeJogadaComputador,
                Resultado = resultado,
                MensagemResultado = ObterMensagemResultado(resultado)
            };
        }

        public void MudarJogador(string novoNome)
        {
            Jogador.AlterarNome(novoNome);
        }

        private ResultadoJogo DeterminarResultado(Jogada jogadaJogador, Jogada jogadaComputador)
        {
            if (jogadaJogador == jogadaComputador)
                return ResultadoJogo.Empate;

            bool vitoria =
                (jogadaJogador == Jogada.Pedra && jogadaComputador == Jogada.Tesoura) ||
                (jogadaJogador == Jogada.Papel && jogadaComputador == Jogada.Pedra) ||
                (jogadaJogador == Jogada.Tesoura && jogadaComputador == Jogada.Papel);

            return vitoria ? ResultadoJogo.Vitoria : ResultadoJogo.Derrota;
        }

        private string ObterNomeJogada(Jogada jogada)
        {
            switch (jogada)
            {
                case Jogada.Pedra:
                    return "Pedra ✊";
                case Jogada.Papel:
                    return "Papel ✋";
                case Jogada.Tesoura:
                    return "Tesoura ✌";
                default:
                    return "";
            }
        }

        private string ObterMensagemResultado(ResultadoJogo resultado)
        {
            switch (resultado)
            {
                case ResultadoJogo.Vitoria:
                    return $"😀 Parabéns, {Jogador.Nome}! Você venceu.";
                case ResultadoJogo.Derrota:
                    return "😀 Haha, eu venci! Não foi dessa vez.";
                case ResultadoJogo.Empate:
                    return "😀 Legal! Nós empatamos!";
                default:
                    return "";
            }
        }
    }
}
