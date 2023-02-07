namespace interfaceArduinoVS2013
{
    partial class TesteFinalQualidade
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
 

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerCOM = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.txtgy = new System.Windows.Forms.TextBox();
            this.lblgy = new System.Windows.Forms.Label();
            this.txtvl1 = new System.Windows.Forms.TextBox();
            this.lblvl1 = new System.Windows.Forms.Label();
            this.txtRetorno = new System.Windows.Forms.TextBox();
            this.btLimparf = new System.Windows.Forms.Button();
            this.txtmodem = new System.Windows.Forms.TextBox();
            this.txtlv2 = new System.Windows.Forms.TextBox();
            this.txtwd = new System.Windows.Forms.TextBox();
            this.lblvl2 = new System.Windows.Forms.Label();
            this.lblwd = new System.Windows.Forms.Label();
            this.lblmodem = new System.Windows.Forms.Label();
            this.lblsteps = new System.Windows.Forms.Label();
            this.lblfim = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.txtCabecalho = new System.Windows.Forms.TextBox();
            this.lblfinal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerCOM
            // 
            this.timerCOM.Interval = 1000;
            this.timerCOM.Tick += new System.EventHandler(this.timerCOM_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // txtgy
            // 
            this.txtgy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.txtgy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtgy.Font = new System.Drawing.Font("Nirmala UI", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(100)))), ((int)(((byte)(139)))));
            this.txtgy.Location = new System.Drawing.Point(42, 87);
            this.txtgy.Name = "txtgy";
            this.txtgy.Size = new System.Drawing.Size(117, 80);
            this.txtgy.TabIndex = 5;
            this.txtgy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtgy.TextChanged += new System.EventHandler(this.txtgy_TextChanged);
            // 
            // lblgy
            // 
            this.lblgy.AutoSize = true;
            this.lblgy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.lblgy.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(85)))), ((int)(((byte)(193)))));
            this.lblgy.Location = new System.Drawing.Point(72, 12);
            this.lblgy.Name = "lblgy";
            this.lblgy.Size = new System.Drawing.Size(52, 37);
            this.lblgy.TabIndex = 6;
            this.lblgy.Text = "GY";
            this.lblgy.Click += new System.EventHandler(this.lblgy_Click);
            // 
            // txtvl1
            // 
            this.txtvl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.txtvl1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtvl1.Font = new System.Drawing.Font("Nirmala UI", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(100)))), ((int)(((byte)(139)))));
            this.txtvl1.Location = new System.Drawing.Point(42, 87);
            this.txtvl1.Name = "txtvl1";
            this.txtvl1.Size = new System.Drawing.Size(117, 80);
            this.txtvl1.TabIndex = 48;
            this.txtvl1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtvl1.TextChanged += new System.EventHandler(this.txtvl_TextChanged);
            // 
            // lblvl1
            // 
            this.lblvl1.AutoSize = true;
            this.lblvl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.lblvl1.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(85)))), ((int)(((byte)(193)))));
            this.lblvl1.Location = new System.Drawing.Point(66, 12);
            this.lblvl1.Name = "lblvl1";
            this.lblvl1.Size = new System.Drawing.Size(65, 37);
            this.lblvl1.TabIndex = 49;
            this.lblvl1.Text = "VL1";
            // 
            // txtRetorno
            // 
            this.txtRetorno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(32)))));
            this.txtRetorno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRetorno.ForeColor = System.Drawing.Color.White;
            this.txtRetorno.Location = new System.Drawing.Point(27, 69);
            this.txtRetorno.Multiline = true;
            this.txtRetorno.Name = "txtRetorno";
            this.txtRetorno.Size = new System.Drawing.Size(145, 338);
            this.txtRetorno.TabIndex = 72;
            // 
            // btLimparf
            // 
            this.btLimparf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.btLimparf.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(100)))), ((int)(((byte)(139)))));
            this.btLimparf.FlatAppearance.BorderSize = 2;
            this.btLimparf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimparf.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimparf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(100)))), ((int)(((byte)(139)))));
            this.btLimparf.Location = new System.Drawing.Point(32, 65);
            this.btLimparf.Name = "btLimparf";
            this.btLimparf.Size = new System.Drawing.Size(133, 45);
            this.btLimparf.TabIndex = 92;
            this.btLimparf.Text = "Limpar";
            this.btLimparf.UseVisualStyleBackColor = false;
            this.btLimparf.Click += new System.EventHandler(this.btLimparf_Click);
            // 
            // txtmodem
            // 
            this.txtmodem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.txtmodem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmodem.Font = new System.Drawing.Font("Nirmala UI", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmodem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(100)))), ((int)(((byte)(139)))));
            this.txtmodem.Location = new System.Drawing.Point(42, 87);
            this.txtmodem.Name = "txtmodem";
            this.txtmodem.Size = new System.Drawing.Size(117, 80);
            this.txtmodem.TabIndex = 94;
            this.txtmodem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtmodem.TextChanged += new System.EventHandler(this.txtmodem_TextChanged);
            // 
            // txtlv2
            // 
            this.txtlv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.txtlv2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtlv2.Font = new System.Drawing.Font("Nirmala UI", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlv2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(100)))), ((int)(((byte)(139)))));
            this.txtlv2.Location = new System.Drawing.Point(42, 87);
            this.txtlv2.Name = "txtlv2";
            this.txtlv2.Size = new System.Drawing.Size(117, 80);
            this.txtlv2.TabIndex = 93;
            this.txtlv2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtlv2.TextChanged += new System.EventHandler(this.txtlv2_TextChanged);
            // 
            // txtwd
            // 
            this.txtwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.txtwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtwd.Font = new System.Drawing.Font("Nirmala UI", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(100)))), ((int)(((byte)(139)))));
            this.txtwd.Location = new System.Drawing.Point(42, 87);
            this.txtwd.Name = "txtwd";
            this.txtwd.Size = new System.Drawing.Size(117, 80);
            this.txtwd.TabIndex = 95;
            this.txtwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtwd.TextChanged += new System.EventHandler(this.txtwd_TextChanged);
            // 
            // lblvl2
            // 
            this.lblvl2.AutoSize = true;
            this.lblvl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.lblvl2.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(85)))), ((int)(((byte)(193)))));
            this.lblvl2.Location = new System.Drawing.Point(64, 12);
            this.lblvl2.Name = "lblvl2";
            this.lblvl2.Size = new System.Drawing.Size(65, 37);
            this.lblvl2.TabIndex = 96;
            this.lblvl2.Text = "VL2";
            // 
            // lblwd
            // 
            this.lblwd.AutoSize = true;
            this.lblwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.lblwd.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(85)))), ((int)(((byte)(193)))));
            this.lblwd.Location = new System.Drawing.Point(21, 12);
            this.lblwd.Name = "lblwd";
            this.lblwd.Size = new System.Drawing.Size(159, 37);
            this.lblwd.TabIndex = 97;
            this.lblwd.Text = "Watch Dog";
            // 
            // lblmodem
            // 
            this.lblmodem.AutoSize = true;
            this.lblmodem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.lblmodem.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmodem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(85)))), ((int)(((byte)(193)))));
            this.lblmodem.Location = new System.Drawing.Point(35, 12);
            this.lblmodem.Name = "lblmodem";
            this.lblmodem.Size = new System.Drawing.Size(117, 37);
            this.lblmodem.TabIndex = 98;
            this.lblmodem.Text = "Modem";
            // 
            // lblsteps
            // 
            this.lblsteps.Location = new System.Drawing.Point(0, 0);
            this.lblsteps.Name = "lblsteps";
            this.lblsteps.Size = new System.Drawing.Size(100, 23);
            this.lblsteps.TabIndex = 112;
            // 
            // lblfim
            // 
            this.lblfim.Location = new System.Drawing.Point(0, 0);
            this.lblfim.Name = "lblfim";
            this.lblfim.Size = new System.Drawing.Size(100, 23);
            this.lblfim.TabIndex = 111;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btLimparf);
            this.panel1.Location = new System.Drawing.Point(40, 285);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 173);
            this.panel1.TabIndex = 102;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtRetorno);
            this.panel2.Location = new System.Drawing.Point(914, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 432);
            this.panel2.TabIndex = 103;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(85)))), ((int)(((byte)(193)))));
            this.label2.Location = new System.Drawing.Point(51, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 37);
            this.label2.TabIndex = 100;
            this.label2.Text = "Serial";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.panel4.Location = new System.Drawing.Point(40, 26);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(199, 234);
            this.panel4.TabIndex = 105;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(85)))), ((int)(((byte)(193)))));
            this.label1.Location = new System.Drawing.Point(94, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 37);
            this.label1.TabIndex = 99;
            this.label1.Text = "Porta";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.panel5.Controls.Add(this.txtmodem);
            this.panel5.Controls.Add(this.lblmodem);
            this.panel5.Location = new System.Drawing.Point(40, 483);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(199, 197);
            this.panel5.TabIndex = 106;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.panel6.Controls.Add(this.txtwd);
            this.panel6.Controls.Add(this.lblwd);
            this.panel6.Location = new System.Drawing.Point(260, 483);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(199, 197);
            this.panel6.TabIndex = 107;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.panel7.Controls.Add(this.lblgy);
            this.panel7.Controls.Add(this.txtgy);
            this.panel7.Location = new System.Drawing.Point(477, 483);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(199, 197);
            this.panel7.TabIndex = 108;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.panel8.Controls.Add(this.lblvl1);
            this.panel8.Controls.Add(this.txtvl1);
            this.panel8.Location = new System.Drawing.Point(695, 483);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(199, 197);
            this.panel8.TabIndex = 109;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.panel9.Controls.Add(this.lblvl2);
            this.panel9.Controls.Add(this.txtlv2);
            this.panel9.Location = new System.Drawing.Point(914, 483);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(199, 197);
            this.panel9.TabIndex = 110;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.Location = new System.Drawing.Point(72, 135);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 21);
            this.comboBox1.TabIndex = 113;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.panel3.BackgroundImage = global::interfaceArduinoVS2013.Properties.Resources.front;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.txtFinal);
            this.panel3.Controls.Add(this.txtCabecalho);
            this.panel3.Controls.Add(this.lblfinal);
            this.panel3.Location = new System.Drawing.Point(260, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(634, 432);
            this.panel3.TabIndex = 104;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // txtFinal
            // 
            this.txtFinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.txtFinal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFinal.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(100)))), ((int)(((byte)(139)))));
            this.txtFinal.Location = new System.Drawing.Point(3, 366);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.ReadOnly = true;
            this.txtFinal.Size = new System.Drawing.Size(628, 36);
            this.txtFinal.TabIndex = 116;
            this.txtFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCabecalho
            // 
            this.txtCabecalho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.txtCabecalho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCabecalho.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCabecalho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(85)))), ((int)(((byte)(193)))));
            this.txtCabecalho.Location = new System.Drawing.Point(3, 25);
            this.txtCabecalho.Name = "txtCabecalho";
            this.txtCabecalho.ReadOnly = true;
            this.txtCabecalho.Size = new System.Drawing.Size(628, 36);
            this.txtCabecalho.TabIndex = 115;
            this.txtCabecalho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblfinal
            // 
            this.lblfinal.AutoSize = true;
            this.lblfinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.lblfinal.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(85)))), ((int)(((byte)(193)))));
            this.lblfinal.Location = new System.Drawing.Point(205, 370);
            this.lblfinal.Name = "lblfinal";
            this.lblfinal.Size = new System.Drawing.Size(0, 37);
            this.lblfinal.TabIndex = 113;
            this.lblfinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TesteFinalQualidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1164, 707);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblfim);
            this.Controls.Add(this.lblsteps);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TesteFinalQualidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TesteFinalQualidade";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerCOM;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox txtgy;
        private System.Windows.Forms.Label lblgy;
        private System.Windows.Forms.TextBox txtvl1;
        private System.Windows.Forms.Label lblvl1;
        private System.Windows.Forms.TextBox txtRetorno;
        private System.Windows.Forms.Button btLimparf;
        private System.Windows.Forms.TextBox txtmodem;
        private System.Windows.Forms.TextBox txtlv2;
        private System.Windows.Forms.TextBox txtwd;
        private System.Windows.Forms.Label lblvl2;
        private System.Windows.Forms.Label lblwd;
        private System.Windows.Forms.Label lblmodem;
        private System.Windows.Forms.Label lblsteps;
        private System.Windows.Forms.Label lblfim;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblfinal;
        private System.Windows.Forms.TextBox txtCabecalho;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
