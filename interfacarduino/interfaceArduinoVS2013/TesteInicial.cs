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
using System.Text.RegularExpressions;

namespace interfaceArduinoVS2013
{
    public partial class TesteInicial : Form
    {
        string RxString;
        public TesteInicial()
        {
            InitializeComponent();
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

        private void timerCOM_Tick(object sender, EventArgs e)
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
            txtFinal.Text = "Teste se os VL's são páreos";
            txtRetorno.AppendText(RxString);
            var rgxv1 = new Regex(@"<axia>.+<axia>");
            string v1ok = rgxv1.Match(txtRetorno.Text).ToString();
            var rgxv2 = new Regex(@"<axia>.+<axia>");
            string v2ok = rgxv2.Match(txtRetorno.Text).ToString();
            try
            {

                if (v1ok == "<axia>v1ok<axia>")
                {
                    txtvl1.Clear();
                    txtvl1.ForeColor = Color.SeaGreen;
                    txtvl1.AppendText("OK");
                    txtRetorno.Clear();
                }

                if (v2ok == "<axia>v2ok<axia>")
                {
                    txtlv2.Clear();
                    txtlv2.ForeColor = Color.SeaGreen;
                    txtlv2.AppendText("OK");
                    txtRetorno.Clear();
                }

                if (txtvl1.Text == "OK" && txtlv2.Text == "OK")
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
            txtlv2.Text = "";
        }
        private void TesteInicial_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
