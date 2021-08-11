using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dado
{
    public partial class Form1 : Form
    {       
        public Form1()
        {
            InitializeComponent();
        }

        int pc = 0, pessoa = 0;

        private void bntJogar_Click(object sender, EventArgs e)
        {
            calculo c = new calculo();
            Random Dado = new Random();
            Random Dado2 = new Random();
            string resp;
            int rival; 

            int d1 = Dado.Next(1, 7);
            int d2 = Dado2.Next(1, 7);

            textDado1.Text = d1.ToString();
            textDado2.Text = d2.ToString();
            c.Dados = d1 + d2;
            resp = c.Dados.ToString();


            if (resp != textJogador.Text)
            {                               
                textComputador.Text = c.Dados.ToString();
                MessageBox.Show("Ponto para a máquina");
                pc++;               
            }
            else
            {
                if (resp == textJogador.Text)
                {
                    if (textJogador.Text == "1" || textJogador.Text == "2")
                        rival = c.Dados + 1;
                    else
                        rival = c.Dados - 1;

                    textComputador.Text = rival.ToString();
                    MessageBox.Show("Ponto para o jogador");
                    pessoa++;                   
                }
            }
        }

        private void textJogador_TextChanged(object sender, EventArgs e)
        {
        }

        private void textComputador_TextChanged(object sender, EventArgs e)
        {
        }

        private void bntTabela_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"\r\nPontuação\nJogador: {pessoa}\nMáquina: {pc}");            
        }
    }
}
