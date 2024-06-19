using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volume_de_uma_esfera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Raio = Convert.ToInt32(textBox1.Text);

            double volume = (4 * 3.14 * Raio * Raio * Raio) / 3;

            lblResultado.Text = (" " + volume);
        }
    }
}
