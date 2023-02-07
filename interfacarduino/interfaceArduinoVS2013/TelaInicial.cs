using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaceArduinoVS2013
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TesteSemiPronto novaform = new TesteSemiPronto();
            novaform.Show();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void btPrimeiraTela_Click(object sender, EventArgs e)
        {
            TesteInicial novaform = new TesteInicial();
            novaform.Show();
        }

        private void btnTerceiraTela_Click(object sender, EventArgs e)
        {
            TesteFinalQualidade novaform = new TesteFinalQualidade();
            novaform.Show();
        }
    }
}
