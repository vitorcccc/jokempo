namespace Jokempo.Core
{
    public class Jogador
    {
        public string Nome { get; private set; }
        public Estatisticas Estatisticas { get; private set; }

        public Jogador(string nome)
        {
            Nome = nome;
            Estatisticas = new Estatisticas();
        }

        public void AlterarNome(string novoNome)
        {
            Nome = novoNome;
            Estatisticas.Resetar();
        }
    }
}
