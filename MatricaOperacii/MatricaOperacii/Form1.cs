using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatricaOperacii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Matritsa.M = 10;
            Matritsa.N = Convert.ToInt16(numericUpDown1.Value);
            for (int i = 0; i < Matritsa.N; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView2.Rows.Add();
                dataGridView3.Rows.Add();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float[,] A = new float[Matritsa.N, Matritsa.M];
            float[,] B = new float[Matritsa.N, Matritsa.M];
            for (int i = 0; i < Matritsa.N; i++)
            {
                for (int j = 0; j < Matritsa.M; j++)
                {
                    A[i, j] = Convert.ToInt16(dataGridView1.Rows[i].Cells[j].Value);
                    B[i, j] = Convert.ToInt16(dataGridView2.Rows[i].Cells[j].Value);
                }
            }
            Matritsa Mtr1 = new Matritsa(A, B);

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Mtr1.MatrPlus();
                    break;
                case 1:
                    Mtr1.RiznitsyaMatr();
                    break;
                case 2:
                    Mtr1.DobutokMatr();
                    break;
                case 3:
                    Mtr1.Dilennya();
                    break;
                case 4:
                    Mtr1.TranspA();
                    break;
                case 5:
                    Mtr1.TranspB();
                    break;
                default: break;
            }
            for (int i = 0; i < Matritsa.N; i++)
            {
                for (int j = 0; j < Matritsa.M; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = Mtr1.A[i, j];
                    dataGridView2.Rows[i].Cells[j].Value = Mtr1.B[i, j];
                    dataGridView3.Rows[i].Cells[j].Value = Mtr1.C[i, j];
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i < Matritsa.N; i++)
            {
                for (int j = 0; j < Matritsa.M; j++)
                {
                    dataGridView1[j, i].Value = r.Next(-10, 10);
                    dataGridView2[j, i].Value = r.Next(-10, 10);
                }
            }
        }
    }
}
