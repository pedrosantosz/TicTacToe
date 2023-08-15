using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public bool choose = true;
        public int clicks = 0;
        public int[,] tabela = { { -10, -10, -10 }, { -10, -10, -10 }, { -10, -10, -10 } };
        public Form1()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (choose == true)
            {
                label1.Text = "X";
                tabela[0, 0] = 1;
            }
            else
            {
                label1.Text = "O";
                tabela[0, 0] = 0;
            }
            choose = !choose;
            result();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (choose == true)
            {
                label2.Text = "X";
                tabela[0, 1] = 1;
            }
            else
            {
                label2.Text = "O";
                tabela[0, 1] = 0;
            }
            choose = !choose;
            result();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (choose == true)
            {
                label3.Text = "X";
                tabela[0, 2] = 1;
            }
            else
            {
                label3.Text = "O";
                tabela[0, 2] = 0;
            }
            choose = !choose;
            result();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (choose == true)
            {
                label4.Text = "X";
                tabela[1, 0] = 1;
            }
            else
            {
                label4.Text = "O";
                tabela[1, 0] = 0;
            }
            choose = !choose;
            result();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (choose == true)
            {
                label5.Text = "X";
                tabela[1, 1] = 1;
            }
            else
            {
                label5.Text = "O";
                tabela[1, 1] = 0;
            }
            choose = !choose;
            result();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (choose == true)
            {
                label6.Text = "X";
                tabela[1, 2] = 1;
            }
            else
            {
                label6.Text = "O";
                tabela[1, 2] = 0;
            }
            choose = !choose;
            result();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (choose == true)
            {
                label7.Text = "X";
                tabela[2, 0] = 1;
            }
            else
            {
                label7.Text = "O";
                tabela[2, 0] = 0;
            }
            choose = !choose;
            result();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (choose == true)
            {
                label8.Text = "X";
                tabela[2, 1] = 1;
            }
            else
            {
                label8.Text = "O";
                tabela[2, 1] = 0;
            }
            choose = !choose;
            result();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (choose == true)
            {
                label9.Text = "X";
                tabela[2, 2] = 1;
            }
            else
            {
                label9.Text = "O";
                tabela[2, 2] = 0;
            }
            choose = !choose;
            result();
        }
        public void result()
        {
            //verificação das possibilidades de ganhar o jogo: em horizontal, vertical e diagonal
            int horizontal1 = tabela[0, 0] + tabela[0, 1] + tabela[0, 2];
            int horizontal2 = tabela[1, 0] + tabela[1, 1] + tabela[1, 2];
            int horizontal3 = tabela[2, 0] + tabela[2, 1] + tabela[2, 2];

            int vertical1 = tabela[0, 0] + tabela[1, 0] + tabela[2, 0];
            int vertical2 = tabela[0, 1] + tabela[1, 1] + tabela[2, 1];
            int vertical3 = tabela[0, 2] + tabela[1, 2] + tabela[2, 2];

            int diagonal1 = tabela[0, 0] + tabela[1, 1] + tabela[2, 2];
            int diagonal2 = tabela[2, 0] + tabela[1, 1] + tabela[0, 2];

            if (horizontal1 == 3 || horizontal2 == 3 || horizontal3 == 3
                || vertical1 == 3 || vertical2 == 3 || vertical3 == 3
                || diagonal1 == 3 || diagonal2 == 3)
            {
                lbResult.Text = $"X ganhou";
                semMaisBotoes();

            } else if (horizontal1 == 0 || horizontal2 == 0 || horizontal3 == 0 
                || vertical1 == 0 || vertical2 == 0 || vertical3 == 0
                || diagonal1 == 0 || diagonal2 == 0)
            {
                lbResult.Text = $"O ganhou";
                semMaisBotoes();
            } else
            {
                clicks++;
                if (clicks == 9) { lbResult.Text = "Deu Velha"; semMaisBotoes(); }
            }
        }

        public void semMaisBotoes()
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            btReset.Visible = true;
        }

        private void btReset_Click(object sender, EventArgs e)
        {

            Application.Restart();
            Environment.Exit(0);
        }
    }
}