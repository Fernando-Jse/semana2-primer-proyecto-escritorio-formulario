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

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Fernando José";
            label2.Text = "Edwin Emerson";
            label3.Text = "Nilderson Alexis";
            label4.Text = "Diego Enmanuel";
            label5.Text = "Henry Anderson";
            label6.Text = "Christian Alexander";
        }
}
