using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLARProhod
{
    public partial class Form1 : Form
    {
        int N;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            button2.Visible = false;
            if (radioButton1.Checked)
            {
                N = 3;
                Class1.N = 3;

                label2.Visible = true;
                label3.Visible = true;
                dataGridView1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                button2.Visible = true;
            }
            else if (radioButton2.Checked)
            {
                N = 5;
                Class1.N = 5;

                label2.Visible = true;
                label3.Visible = true;
                dataGridView2.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                button2.Visible = true;
            }
            else MessageBox.Show("Оберіть розмір матриці!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            double[,] Arr1 = new double[N, N];
            double[] Arr2 = new double[N];
            for(int i=0; i<N; i++)
            {
                for(int j=0; j<N; j++)
                {
                    Arr1[i, j] = Convert.ToDouble(dataGridView1[j,i].Value);
                }
            }
            if(N==3)
            {
                Arr2[0] = Convert.ToDouble(textBox2.Text);
                Arr2[1] = Convert.ToDouble(textBox3.Text);
                Arr2[2] = Convert.ToDouble(textBox4.Text);
            }
            else if(N==5)
            {
                Arr2[0] = Convert.ToDouble(textBox2.Text);
                Arr2[1] = Convert.ToDouble(textBox3.Text);
                Arr2[2] = Convert.ToDouble(textBox4.Text);
                Arr2[3] = Convert.ToDouble(textBox5.Text);
                Arr2[4] = Convert.ToDouble(textBox6.Text);
            }
            Class1 Pr = new Class1(N, Arr1, Arr2);
            Pr.progonka();
            if(N==3)
            {
                label4.Text = "Результати:\nX1 = " + Pr.matRes[0] + "\nX2 = " + Pr.matRes[1] + "\nX3 = " + Pr.matRes[2];
            }
            else if (N==5)
            {
                label4.Text = "Результати:\nX1 = " + Pr.matRes[0] + "\nX2 = " + Pr.matRes[1] + "\nX3 = " + Pr.matRes[2]+ "\nX4 = "+Pr.matRes[3] + "\nX5 = " + Pr.matRes[4];
            }
        }
    }
}
