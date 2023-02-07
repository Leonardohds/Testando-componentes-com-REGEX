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
    public partial class TesteFinalQualidade : Form
    {
        string RxString;

        public TesteFinalQualidade()
        {
            InitializeComponent();
            timerCOM.Enabled = true;
            txtmodem.AppendText("OFF");
            txtwd.AppendText("OFF");
            txtgy.AppendText("OFF");
            txtvl1.AppendText("OFF");
            txtlv2.AppendText("OFF");
        }

        public void atualizaListaCOMs()
        {
            int i; bool quantDiferente; i = 0;
            quantDiferente = false;
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
        }

        private void timerCOM_Tick(object sender, EventArgs e)
        {
            atualizaListaCOMs();
        }

        private void btConectar_Click(object sender, EventArgs e)
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
                    btConectar.Text = "Desconectar";
                    comboBox1.Enabled = false;
                }
            }
            else
            {

                try
                {
                    serialPort1.Close();
                    comboBox1.Enabled = true;
                    btConectar.Text = "Conectar";
                }
                catch
                {
                    return;
                }
            }
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

            txtRetorno.AppendText(RxString);
            var rgxmd = new Regex(@"<axia>.+<axia>");
            string modemok = rgxmd.Match(txtRetorno.Text).ToString();
            var rgxwd = new Regex(@"<axia>.+<axia>");
            string wdok = rgxwd.Match(txtRetorno.Text).ToString();
            var rgxgy = new Regex(@"<axia>.+<axia>");
            string gyok = rgxgy.Match(txtRetorno.Text).ToString();
            var rgxv1 = new Regex(@"<axia>.+<axia>");
            string v1ok = rgxv1.Match(txtRetorno.Text).ToString();
            var rgxv2 = new Regex(@"<axia>.+<axia>");
            string v2ok = rgxv2.Match(txtRetorno.Text).ToString();
            lblsteps.Text = "Conecte o sensor e aguarda o início automático do teste";
            try
            {
                    if (modemok == "<axia>mdok<axia>")
                    {
                        txtmodem.Clear();
                        txtmodem.ForeColor = Color.SeaGreen;
                        txtmodem.AppendText("OK");
                        txtRetorno.Clear();
                    }

                    if (wdok == "<axia>wdok<axia>")
                    {
                        txtwd.Clear();
                        txtwd.ForeColor = Color.SeaGreen;
                        txtwd.AppendText("OK");
                        txtRetorno.Clear();
                    }

                    if (gyok == "<axia>gyok<axia>")
                    {
                        txtgy.Clear();
                        txtgy.ForeColor = Color.SeaGreen;
                        txtgy.AppendText("OK");
                        txtRetorno.Clear();
                    }

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

                    if (txtmodem.Text == "OK" && txtwd.Text == "OK" && txtgy.Text == "OK" && txtvl1.Text == "OK" && txtlv2.Text == "OK")
                    {
                        lblfinal.Text = "Teste Concluído";
                    }
                    #region
                    //if (txtRetorno.Text.IndexOf("START") > -1 && txtRetorno.Text.IndexOf("END") > -1 && txtRetorno.Text.IndexOf("START") < txtRetorno.Text.IndexOf("END"))
                    //{
                    //    string texto = txtRetorno.Text.Substring(txtRetorno.Text.IndexOf("START") + 5, txtRetorno.Text.Length - (txtRetorno.Text.IndexOf("START") + 5));

                    //    string[] str = texto.Replace("\n", "").Split('\r');

                    //    for (int i = 0; i < str.Length; i++)
                    //    {
                    //        if (str[i].Length > 10)
                    //        {

                    //            if (str[i].Substring(0, 6) == "*gy*")
                    //            {

                    //                txtgy.AppendText(str[i].Replace("*TELA*", "") + "\r\n");
                    //            }

                    //            if (str[i].Substring(0, 6) == "*vl*")
                    //            {
                    //              txtvl.AppendText(str[i].Replace("*TELA*", "") + "\r\n");

                    //            }


                    //        }
                    //    }

                    //    txtRetorno.Text = txtRetorno.Text.Substring(txtRetorno.Text.IndexOf("END") + 3, (txtRetorno.Text.Length - txtRetorno.Text.IndexOf("END")) - 3);
                    //}
                    #endregion

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
            txtmodem.Text = "";
            txtwd.Text = "";
            txtRetorno.Text = "";
            lblsteps.Text = "";
            lblfim.Text = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void txtvl_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtgy_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblgy_Click(object sender, EventArgs e)
        {

        }

        private void txtmodem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtlv2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblsteps_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
