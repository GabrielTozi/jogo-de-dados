
namespace interface
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
            this.labeltitulo = new System.Windows.Forms.Label();
            this.labeljogador = new System.Windows.Forms.Label();
            this.labelcomputador = new System.Windows.Forms.Label();
            this.textDado1 = new System.Windows.Forms.TextBox();
            this.textDado2 = new System.Windows.Forms.TextBox();
            this.bntjogar = new System.Windows.Forms.Button();
            this.textjogador = new System.Windows.Forms.TextBox();
            this.textcomputador = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labeltitulo
            // 
            this.labeltitulo.AutoSize = true;
            this.labeltitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeltitulo.Location = new System.Drawing.Point(111, 28);
            this.labeltitulo.Name = "labeltitulo";
            this.labeltitulo.Size = new System.Drawing.Size(74, 30);
            this.labeltitulo.TabIndex = 0;
            this.labeltitulo.Text = "Dados";
            // 
            // labeljogador
            // 
            this.labeljogador.AutoSize = true;
            this.labeljogador.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeljogador.Location = new System.Drawing.Point(24, 187);
            this.labeljogador.Name = "labeljogador";
            this.labeljogador.Size = new System.Drawing.Size(80, 25);
            this.labeljogador.TabIndex = 1;
            this.labeljogador.Text = "Jogador";
            // 
            // labelcomputador
            // 
            this.labelcomputador.AutoSize = true;
            this.labelcomputador.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelcomputador.Location = new System.Drawing.Point(13, 258);
            this.labelcomputador.Name = "labelcomputador";
            this.labelcomputador.Size = new System.Drawing.Size(118, 25);
            this.labelcomputador.TabIndex = 2;
            this.labelcomputador.Text = "Computador";
            // 
            // textDado1
            // 
            this.textDado1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textDado1.Location = new System.Drawing.Point(61, 94);
            this.textDado1.Name = "textDado1";
            this.textDado1.Size = new System.Drawing.Size(70, 36);
            this.textDado1.TabIndex = 3;
            // 
            // textDado2
            // 
            this.textDado2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textDado2.Location = new System.Drawing.Point(185, 94);
            this.textDado2.Name = "textDado2";
            this.textDado2.Size = new System.Drawing.Size(73, 36);
            this.textDado2.TabIndex = 4;
            // 
            // bntjogar
            // 
            this.bntjogar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bntjogar.Location = new System.Drawing.Point(110, 338);
            this.bntjogar.Name = "bntjogar";
            this.bntjogar.Size = new System.Drawing.Size(75, 28);
            this.bntjogar.TabIndex = 5;
            this.bntjogar.Text = "Jogar";
            this.bntjogar.UseVisualStyleBackColor = true;
            // 
            // textjogador
            // 
            this.textjogador.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textjogador.Location = new System.Drawing.Point(158, 187);
            this.textjogador.Name = "textjogador";
            this.textjogador.Size = new System.Drawing.Size(100, 32);
            this.textjogador.TabIndex = 6;
            // 
            // textcomputador
            // 
            this.textcomputador.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textcomputador.Location = new System.Drawing.Point(158, 258);
            this.textcomputador.Name = "textcomputador";
            this.textcomputador.Size = new System.Drawing.Size(100, 32);
            this.textcomputador.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 388);
            this.Controls.Add(this.textcomputador);
            this.Controls.Add(this.textjogador);
            this.Controls.Add(this.bntjogar);
            this.Controls.Add(this.textDado2);
            this.Controls.Add(this.textDado1);
            this.Controls.Add(this.labelcomputador);
            this.Controls.Add(this.labeljogador);
            this.Controls.Add(this.labeltitulo);
            this.Name = "Form1";
            this.Text = "Jogo de Dados";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labeltitulo;
    private System.Windows.Forms.Label labeljogador;
    private System.Windows.Forms.Label labelcomputador;
    private System.Windows.Forms.TextBox textDado1;
    private System.Windows.Forms.TextBox textDado2;
    private System.Windows.Forms.Button bntjogar;
    private System.Windows.Forms.TextBox textjogador;
    private System.Windows.Forms.TextBox textcomputador;
}
}

