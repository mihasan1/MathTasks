using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, eps;
            a = Convert.ToDouble(textBox2.Text);
            b = Convert.ToDouble(textBox3.Text);
            eps = Convert.ToDouble(textBox4.Text);

            HodraKlas Horda111 = new HodraKlas(a, b, eps);
            label8.Text= "Відповідь: "+Horda111.Reshenie(a,b,eps);
        }
    }
}
