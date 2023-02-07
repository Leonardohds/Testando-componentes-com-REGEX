namespace interfaceArduinoVS2013
{
    partial class TesteInicial
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRetorno = new System.Windows.Forms.TextBox();
            this.panel4sp = new System.Windows.Forms.Panel();
            this.label1sp = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.txtCabecalho = new System.Windows.Forms.TextBox();
            this.lblfinal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btLimparf = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblvl2 = new System.Windows.Forms.Label();
            this.txtlv2 = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblvl1 = new System.Windows.Forms.Label();
            this.txtvl1 = new System.Windows.Forms.TextBox();
            this.timerCOM = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel2.SuspendLayout();
            this.panel4sp.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtRetorno);
            this.panel2.Location = new System.Drawing.Point(914, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 432);
            this.panel2.TabIndex = 111;
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
            // panel4sp
            // 
            this.panel4sp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.panel4sp.Controls.Add(this.label1sp);
            this.panel4sp.Controls.Add(this.comboBox1);
            this.panel4sp.Location = new System.Drawing.Point(40, 26);
            this.panel4sp.Name = "panel4sp";
            this.panel4sp.Size = new System.Drawing.Size(199, 234);
            this.panel4sp.TabIndex = 110;
            // 
            // label1sp
            // 
            this.label1sp.AutoSize = true;
            this.label1sp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.label1sp.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1sp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(85)))), ((int)(((byte)(193)))));
            this.label1sp.Location = new System.Drawing.Point(51, 37);
            this.label1sp.Name = "label1sp";
            this.label1sp.Size = new System.Drawing.Size(88, 37);
            this.label1sp.TabIndex = 100;
            this.label1sp.Text = "Porta";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.Location = new System.Drawing.Point(32, 115);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 21);
            this.comboBox1.TabIndex = 1;
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
            this.panel3.TabIndex = 109;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // txtFinal
            // 
            this.txtFinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.txtFinal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFinal.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(100)))), ((int)(((byte)(139)))));
            this.txtFinal.Location = new System.Drawing.Point(3, 370);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.ReadOnly = true;
            this.txtFinal.Size = new System.Drawing.Size(628, 36);
            this.txtFinal.TabIndex = 115;
            this.txtFinal.TabStop = false;
            this.txtFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCabecalho
            // 
            this.txtCabecalho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.txtCabecalho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCabecalho.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCabecalho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(85)))), ((int)(((byte)(193)))));
            this.txtCabecalho.Location = new System.Drawing.Point(3, 16);
            this.txtCabecalho.Name = "txtCabecalho";
            this.txtCabecalho.ReadOnly = true;
            this.txtCabecalho.Size = new System.Drawing.Size(628, 36);
            this.txtCabecalho.TabIndex = 115;
            this.txtCabecalho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblfinal
            // 
            this.lblfinal.Location = new System.Drawing.Point(0, 0);
            this.lblfinal.Name = "lblfinal";
            this.lblfinal.Size = new System.Drawing.Size(100, 23);
            this.lblfinal.TabIndex = 116;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btLimparf);
            this.panel1.Location = new System.Drawing.Point(40, 285);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 173);
            this.panel1.TabIndex = 112;
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
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.panel9.Controls.Add(this.lblvl2);
            this.panel9.Controls.Add(this.txtlv2);
            this.panel9.Location = new System.Drawing.Point(807, 483);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(199, 197);
            this.panel9.TabIndex = 114;
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
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.panel8.Controls.Add(this.lblvl1);
            this.panel8.Controls.Add(this.txtvl1);
            this.panel8.Location = new System.Drawing.Point(148, 483);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(199, 197);
            this.panel8.TabIndex = 113;
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
            // 
            // timerCOM
            // 
            this.timerCOM.Enabled = true;
            this.timerCOM.Interval = 1000;
            this.timerCOM.Tick += new System.EventHandler(this.timerCOM_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // TesteInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1164, 707);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4sp);
            this.Controls.Add(this.panel3);
            this.Name = "TesteInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TesteInicial";
            this.Load += new System.EventHandler(this.TesteInicial_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4sp.ResumeLayout(false);
            this.panel4sp.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRetorno;
        private System.Windows.Forms.Panel panel4sp;
        private System.Windows.Forms.Label label1sp;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblfinal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btLimparf;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblvl2;
        private System.Windows.Forms.TextBox txtlv2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblvl1;
        private System.Windows.Forms.TextBox txtvl1;
        private System.Windows.Forms.Timer timerCOM;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox txtCabecalho;
        private System.Windows.Forms.TextBox txtFinal;
    }
}