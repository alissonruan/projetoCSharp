namespace SistemadeCafe
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.btnJogador = new System.Windows.Forms.Button();
            this.btnPartida = new System.Windows.Forms.Button();
            this.btnRanking = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(279, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 36);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ping Pong";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label4.UseMnemonic = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnJogador
            // 
            this.btnJogador.Location = new System.Drawing.Point(12, 114);
            this.btnJogador.Name = "btnJogador";
            this.btnJogador.Size = new System.Drawing.Size(187, 72);
            this.btnJogador.TabIndex = 1;
            this.btnJogador.Text = "Jogadores";
            this.btnJogador.UseVisualStyleBackColor = true;
            this.btnJogador.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPartida
            // 
            this.btnPartida.Location = new System.Drawing.Point(490, 114);
            this.btnPartida.Name = "btnPartida";
            this.btnPartida.Size = new System.Drawing.Size(187, 72);
            this.btnPartida.TabIndex = 4;
            this.btnPartida.Text = "Partida";
            this.btnPartida.UseVisualStyleBackColor = true;
            // 
            // btnRanking
            // 
            this.btnRanking.Location = new System.Drawing.Point(257, 114);
            this.btnRanking.Name = "btnRanking";
            this.btnRanking.Size = new System.Drawing.Size(187, 72);
            this.btnRanking.TabIndex = 5;
            this.btnRanking.Text = "Ranking";
            this.btnRanking.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(753, 216);
            this.Controls.Add(this.btnRanking);
            this.Controls.Add(this.btnPartida);
            this.Controls.Add(this.btnJogador);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Text = "Sistema de Gerenciamento de Partida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnJogador;
        private System.Windows.Forms.Button btnPartida;
        private System.Windows.Forms.Button btnRanking;
    }
}

