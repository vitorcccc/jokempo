namespace Jokempo.WinForms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblJogador;
        private System.Windows.Forms.Button btnPedra;
        private System.Windows.Forms.Button btnPapel;
        private System.Windows.Forms.Button btnTesoura;
        private System.Windows.Forms.Button btnMudarJogador;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblEstatisticas;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lblJogador = new System.Windows.Forms.Label();
            this.btnPedra = new System.Windows.Forms.Button();
            this.btnPapel = new System.Windows.Forms.Button();
            this.btnTesoura = new System.Windows.Forms.Button();
            this.btnMudarJogador = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblEstatisticas = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(130, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(112, 25);
            this.lblTitulo.Text = "JOKEMPO";

            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(30, 70);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(102, 15);
            this.lblNome.Text = "Nome do jogador";

            this.txtNomeJogador.Location = new System.Drawing.Point(30, 90);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(220, 23);

            this.btnIniciar.Location = new System.Drawing.Point(270, 89);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(80, 25);
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);

            this.lblJogador.AutoSize = true;
            this.lblJogador.Location = new System.Drawing.Point(30, 130);
            this.lblJogador.Name = "lblJogador";
            this.lblJogador.Size = new System.Drawing.Size(55, 15);
            this.lblJogador.Text = "Jogador: ";

            this.btnPedra.Location = new System.Drawing.Point(30, 170);
            this.btnPedra.Name = "btnPedra";
            this.btnPedra.Size = new System.Drawing.Size(90, 35);
            this.btnPedra.Text = "Pedra ✊";
            this.btnPedra.UseVisualStyleBackColor = true;
            this.btnPedra.Click += new System.EventHandler(this.btnPedra_Click);

            this.btnPapel.Location = new System.Drawing.Point(140, 170);
            this.btnPapel.Name = "btnPapel";
            this.btnPapel.Size = new System.Drawing.Size(90, 35);
            this.btnPapel.Text = "Papel ✋";
            this.btnPapel.UseVisualStyleBackColor = true;
            this.btnPapel.Click += new System.EventHandler(this.btnPapel_Click);

            this.btnTesoura.Location = new System.Drawing.Point(250, 170);
            this.btnTesoura.Name = "btnTesoura";
            this.btnTesoura.Size = new System.Drawing.Size(100, 35);
            this.btnTesoura.Text = "Tesoura ✌";
            this.btnTesoura.UseVisualStyleBackColor = true;
            this.btnTesoura.Click += new System.EventHandler(this.btnTesoura_Click);

            this.btnMudarJogador.Location = new System.Drawing.Point(30, 220);
            this.btnMudarJogador.Name = "btnMudarJogador";
            this.btnMudarJogador.Size = new System.Drawing.Size(150, 30);
            this.btnMudarJogador.Text = "Mudar Jogador";
            this.btnMudarJogador.UseVisualStyleBackColor = true;
            this.btnMudarJogador.Click += new System.EventHandler(this.btnMudarJogador_Click);

            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.Location = new System.Drawing.Point(30, 270);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(320, 80);
            this.lblResultado.Text = "Resultado";
            this.lblResultado.AutoSize = false;

            this.lblEstatisticas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEstatisticas.Location = new System.Drawing.Point(30, 370);
            this.lblEstatisticas.Name = "lblEstatisticas";
            this.lblEstatisticas.Size = new System.Drawing.Size(320, 40);
            this.lblEstatisticas.Text = "Estatísticas";
            this.lblEstatisticas.AutoSize = false;

            this.ClientSize = new System.Drawing.Size(390, 440);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNomeJogador);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lblJogador);
            this.Controls.Add(this.btnPedra);
            this.Controls.Add(this.btnPapel);
            this.Controls.Add(this.btnTesoura);
            this.Controls.Add(this.btnMudarJogador);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblEstatisticas);
            this.Name = "Form1";
            this.Text = "Jokempo - WinForms";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
