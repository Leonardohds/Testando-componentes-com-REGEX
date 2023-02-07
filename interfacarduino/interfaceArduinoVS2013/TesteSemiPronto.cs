using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;  // necessário para ter acesso as portas
using System.IO;
using System.Text.RegularExpressions;

namespace interfaceArduinoVS2013
{
    public partial class TesteSemiPronto : Form
    {
        int contador1 = 0, contador2 = 0;
        string RxString;

        public TesteSemiPronto()
        {
            InitializeComponent();
            txtgy.AppendText("OFF");
            txtvl1.AppendText("OFF");
            txtlv2.AppendText("OFF");
        }
        public void atualizaListaCOMs()
        {
            int i; bool quantDiferente; i = 0;
            quantDiferente = false;
            SerialPort.GetPortNames();
            if (comboBox1.Items.Count == SerialPort.GetPortNames().Length)
            {
                foreach (string s in SerialPort.GetPortNames())
                {
                    if (comboBox1.Items[i++].Equals(s) == false)
                    {
                        quantDiferente = true;
                    }
                }
            }
            else { quantDiferente = true; }

            if (quantDiferente == false) { return; }
            comboBox1.Items.Clear();
            foreach (string s in SerialPort.GetPortNames()) { comboBox1.Items.Add(s); }
            comboBox1.SelectedIndex = 0;
            var dados = new Regex(@". +");

            for (int j = 0; j < SerialPort.GetPortNames().Length; j++)
            {
                serialPort1.Close();
                serialPort1.PortName = SerialPort.GetPortNames()[j];
                serialPort1.Open();
                if (serialPort1.ReadExisting() == dados.ToString())
                {
                    if (serialPort1.IsOpen == false)
                    {
                        try
                        {
                            serialPort1.PortName = comboBox1.Items[comboBox1.SelectedIndex].ToString();
                            serialPort1.Open();
                        }
                        catch { return; }
                        if (serialPort1.IsOpen)
                        {
                            comboBox1.Enabled = false;
                        }
                    }
                    else
                    {

                        try
                        {
                            serialPort1.Close();
                            comboBox1.Enabled = true;
                        }
                        catch
                        {
                            return;
                        }
                    }
                }
            }
        }
            private void timer1_Tick(object sender, EventArgs e)
        {
            atualizaListaCOMs();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen == true)
                serialPort1.Close();
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            RxString = serialPort1.ReadExisting();

            this.Invoke(new EventHandler(trataDadoRecebido));

        }

        private void trataDadoRecebido(object sender, EventArgs e)
        {
            txtCabecalho.Text = "Teste em andamento, siga as instruções abaixo";
            txtFinal.Text = "Teste o sensor 1 por cinco vezes";
            txtRetorno.AppendText(RxString);
            var rgxgy = new Regex(@"<axia>.+<axia>");
            string gyok = rgxgy.Match(txtRetorno.Text).ToString();
            var rgxv1 = new Regex(@"<axia>.+<axia>");
            string v1ok = rgxv1.Match(txtRetorno.Text).ToString();
            var rgxv2 = new Regex(@"<axia>.+<axia>");
            string v2ok = rgxv2.Match(txtRetorno.Text).ToString();
            try
            {
                if (gyok == "<axia>gyok<axia>")
                {
                    txtgy.Clear();
                    txtgy.ForeColor = Color.SeaGreen;
                    txtgy.AppendText("OK");
                    txtRetorno.Clear();
                }

                if (v1ok == "<axia>v1ok<axia>")
                {

                    txtRetorno.Clear();
                    contador1 += 1;
                    if (contador1 == 2)
                    {
                        txtFinal.Text = "";
                        txtFinal.Text = "Teste o sensor 2 por cinco vezes";
                        txtvl1.ForeColor = Color.SeaGreen;
                        txtvl1.Clear();
                        txtvl1.AppendText("OK");
                    }
                }

                if (v2ok == "<axia>v2ok<axia>")
                {

                    txtRetorno.Clear();
                    contador2 += 1;
                    if (contador2 == 2)
                    {
                        txtFinal.Text = "";
                        txtlv2.ForeColor = Color.SeaGreen;
                        txtlv2.Clear();
                        txtlv2.AppendText("OK");
                    }
                }

                if (txtgy.Text == "OK" && txtvl1.Text == "OK" && txtlv2.Text == "OK")
                {
                    txtFinal.Text = "Teste Concluído!";
                }

            }
            catch (Exception teste)
            {
                Console.WriteLine($"The file could not be opened: '{teste}'");
            }

        }

        private void btLimparf_Click(object sender, EventArgs e)
        {
            txtvl1.Text = "";
            txtgy.Text = "";
            txtlv2.Text = "";
        }

        private void TesteSemiPronto_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timerCOM_Tick(object sender, EventArgs e)
        {

        }

    }
}



