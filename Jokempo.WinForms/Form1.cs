using System;
using System.Windows.Forms;
using Jokempo.Core;

namespace Jokempo.WinForms
{
    public partial class Form1 : Form
    {
        private JogoJokempo _jogo;

        public Form1()
        {
            InitializeComponent();
            HabilitarJogo(false);
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeJogador.Text))
            {
                MessageBox.Show("Digite o nome do jogador.");
                return;
            }

            _jogo = new JogoJokempo(txtNomeJogador.Text.Trim());
            lblJogador.Text = $"Jogador: {_jogo.Jogador.Nome}";
            AtualizarEstatisticas();
            lblResultado.Text = "Escolha Pedra, Papel ou Tesoura.";
            HabilitarJogo(true);
        }

        private void btnPedra_Click(object sender, EventArgs e)
        {
            Jogar(Jogada.Pedra);
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            Jogar(Jogada.Papel);
        }

        private void btnTesoura_Click(object sender, EventArgs e)
        {
            Jogar(Jogada.Tesoura);
        }

        private void btnMudarJogador_Click(object sender, EventArgs e)
        {
            if (_jogo == null)
            {
                MessageBox.Show("Inicie o jogo primeiro.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNomeJogador.Text))
            {
                MessageBox.Show("Digite o novo nome do jogador.");
                return;
            }

            _jogo.MudarJogador(txtNomeJogador.Text.Trim());
            lblJogador.Text = $"Jogador: {_jogo.Jogador.Nome}";
            AtualizarEstatisticas();
            lblResultado.Text = $"Bem-vindo(a), {_jogo.Jogador.Nome}! Suas estatísticas foram resetadas.";
        }

        private void Jogar(Jogada jogada)
        {
            if (_jogo == null)
                return;

            ResultadoRodada resultado = _jogo.Jogar(jogada);

            lblResultado.Text =
                $"{resultado.NomeJogador} jogou: {resultado.NomeJogadaJogador}\r\n" +
                $"Computador jogou: {resultado.NomeJogadaComputador}\r\n" +
                $"{resultado.MensagemResultado}";

            AtualizarEstatisticas();
        }

        private void AtualizarEstatisticas()
        {
            if (_jogo == null)
                return;

            lblEstatisticas.Text =
                $"Vitórias: {_jogo.Jogador.Estatisticas.Vitorias} | " +
                $"Derrotas: {_jogo.Jogador.Estatisticas.Derrotas} | " +
                $"Empates: {_jogo.Jogador.Estatisticas.Empates}";
        }

        private void HabilitarJogo(bool habilitar)
        {
            btnPedra.Enabled = habilitar;
            btnPapel.Enabled = habilitar;
            btnTesoura.Enabled = habilitar;
            btnMudarJogador.Enabled = habilitar;
        }
    }
}
