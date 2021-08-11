
namespace Dado
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelJogador = new System.Windows.Forms.Label();
            this.labelComputador = new System.Windows.Forms.Label();
            this.textDado1 = new System.Windows.Forms.TextBox();
            this.textDado2 = new System.Windows.Forms.TextBox();
            this.textJogador = new System.Windows.Forms.TextBox();
            this.textComputador = new System.Windows.Forms.TextBox();
            this.bntJogar = new System.Windows.Forms.Button();
            this.bntTabela = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.Location = new System.Drawing.Point(151, 39);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(74, 30);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Dados";
            // 
            // labelJogador
            // 
            this.labelJogador.AutoSize = true;
            this.labelJogador.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelJogador.Location = new System.Drawing.Point(40, 125);
            this.labelJogador.Name = "labelJogador";
            this.labelJogador.Size = new System.Drawing.Size(80, 25);
            this.labelJogador.TabIndex = 1;
            this.labelJogador.Text = "Jogador";
            // 
            // labelComputador
            // 
            this.labelComputador.AutoSize = true;
            this.labelComputador.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelComputador.Location = new System.Drawing.Point(40, 187);
            this.labelComputador.Name = "labelComputador";
            this.labelComputador.Size = new System.Drawing.Size(118, 25);
            this.labelComputador.TabIndex = 2;
            this.labelComputador.Text = "Computador";
            // 
            // textDado1
            // 
            this.textDado1.Location = new System.Drawing.Point(40, 48);
            this.textDado1.Name = "textDado1";
            this.textDado1.Size = new System.Drawing.Size(100, 23);
            this.textDado1.TabIndex = 3;
            // 
            // textDado2
            // 
            this.textDado2.Location = new System.Drawing.Point(231, 48);
            this.textDado2.Name = "textDado2";
            this.textDado2.Size = new System.Drawing.Size(100, 23);
            this.textDado2.TabIndex = 4;
            // 
            // textJogador
            // 
            this.textJogador.Location = new System.Drawing.Point(175, 127);
            this.textJogador.Name = "textJogador";
            this.textJogador.Size = new System.Drawing.Size(100, 23);
            this.textJogador.TabIndex = 5;
            this.textJogador.TextChanged += new System.EventHandler(this.textJogador_TextChanged);
            // 
            // textComputador
            // 
            this.textComputador.Location = new System.Drawing.Point(175, 187);
            this.textComputador.Name = "textComputador";
            this.textComputador.Size = new System.Drawing.Size(100, 23);
            this.textComputador.TabIndex = 6;
            this.textComputador.TextChanged += new System.EventHandler(this.textComputador_TextChanged);
            // 
            // bntJogar
            // 
            this.bntJogar.Location = new System.Drawing.Point(186, 303);
            this.bntJogar.Name = "bntJogar";
            this.bntJogar.Size = new System.Drawing.Size(75, 23);
            this.bntJogar.TabIndex = 7;
            this.bntJogar.Text = "Jogar";
            this.bntJogar.UseVisualStyleBackColor = true;
            this.bntJogar.Click += new System.EventHandler(this.bntJogar_Click);
            // 
            // bntTabela
            // 
            this.bntTabela.Location = new System.Drawing.Point(12, 325);
            this.bntTabela.Name = "bntTabela";
            this.bntTabela.Size = new System.Drawing.Size(75, 23);
            this.bntTabela.TabIndex = 8;
            this.bntTabela.Text = "Pontuação";
            this.bntTabela.UseVisualStyleBackColor = true;
            this.bntTabela.Click += new System.EventHandler(this.bntTabela_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 360);
            this.Controls.Add(this.bntTabela);
            this.Controls.Add(this.bntJogar);
            this.Controls.Add(this.textComputador);
            this.Controls.Add(this.textJogador);
            this.Controls.Add(this.textDado2);
            this.Controls.Add(this.textDado1);
            this.Controls.Add(this.labelComputador);
            this.Controls.Add(this.labelJogador);
            this.Controls.Add(this.labelTitulo);
            this.Name = "Form1";
            this.Text = "Jogode dados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelJogador;
        private System.Windows.Forms.Label labelComputador;
        private System.Windows.Forms.TextBox textDado1;
        private System.Windows.Forms.TextBox textDado2;
        private System.Windows.Forms.TextBox textJogador;
        private System.Windows.Forms.TextBox textComputador;
        private System.Windows.Forms.Button bntJogar;
        private System.Windows.Forms.Button bntTabela;
    }
}

