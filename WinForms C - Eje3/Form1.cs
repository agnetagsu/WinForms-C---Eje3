using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_C___Eje3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valores = "Valores seleccionados:\n";
            if (this.radioButton1.Checked)
            {
                valores = valores + "Windows\n";
            }
            else
            {
                if (this.radioButton2.Checked)
                {
                    valores = valores + "Linux\n";
                }
                else
                {
                    valores = valores + "Mac\n";
                }
            }
            if (this.checkBox1.Checked)
            {
                valores = valores + "Programación\n";
            }
            if (this.checkBox2.Checked)
            {
                valores = valores + "Diseño gráfico\n";
            }
            if (this.checkBox3.Checked)
            {
                valores = valores + "Administración\n";
            }
            valores = valores + Convert.ToString(this.trackBar1.Value);

            MessageBox.Show(valores);
        }
    }
}
