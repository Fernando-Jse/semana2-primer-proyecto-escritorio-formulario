using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace semana2_primer_proyecto_escritorio_formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            label8.Text = "1-Fernando José";
            label9.Text = "2-Edwin Emerson";
            label10.Text = "3-Nilderson Alexis";
            label11.Text = "4-Diego Enmanuel";
            label12.Text = "5-Henry Anderson";
            label13.Text = "6-Christian Alexander";
            label14.Text = "Integrantes:";
        }
    }
}
