namespace Jokempo.Core
{
    public class Estatisticas
    {
        public int Vitorias { get; private set; }
        public int Derrotas { get; private set; }
        public int Empates { get; private set; }

        public void RegistrarResultado(ResultadoJogo resultado)
        {
            switch (resultado)
            {
                case ResultadoJogo.Vitoria:
                    Vitorias++;
                    break;
                case ResultadoJogo.Derrota:
                    Derrotas++;
                    break;
                case ResultadoJogo.Empate:
                    Empates++;
                    break;
            }
        }

        public void Resetar()
        {
            Vitorias = 0;
            Derrotas = 0;
            Empates = 0;
        }
    }
}
