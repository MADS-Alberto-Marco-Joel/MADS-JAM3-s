﻿namespace ProjetoArvore
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_registar = new System.Windows.Forms.Button();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.cmb_especies = new System.Windows.Forms.ComboBox();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.txtDiametro = new System.Windows.Forms.TextBox();
            this.datePicker_validfrom = new System.Windows.Forms.DateTimePicker();
            this.cmbCaldeira = new System.Windows.Forms.ComboBox();
            this.txtLocalizacao = new System.Windows.Forms.TextBox();
            this.connectBDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cBox_Caldeira = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.connectBDBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_registar
            // 
            this.btn_registar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_registar.Location = new System.Drawing.Point(361, 339);
            this.btn_registar.Name = "btn_registar";
            this.btn_registar.Size = new System.Drawing.Size(102, 40);
            this.btn_registar.TabIndex = 0;
            this.btn_registar.Text = "Registar";
            this.btn_registar.UseVisualStyleBackColor = true;
            this.btn_registar.Click += new System.EventHandler(this.btn_registar_Click);
            // 
            // txtAltura
            // 
            this.txtAltura.BackColor = System.Drawing.SystemColors.GrayText;
            this.txtAltura.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtAltura.Location = new System.Drawing.Point(382, 140);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(236, 23);
            this.txtAltura.TabIndex = 1;
            this.txtAltura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAltura_KeyPress);
            // 
            // cmb_especies
            // 
            this.cmb_especies.BackColor = System.Drawing.SystemColors.GrayText;
            this.cmb_especies.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmb_especies.FormattingEnabled = true;
            this.cmb_especies.Location = new System.Drawing.Point(382, 111);
            this.cmb_especies.Name = "cmb_especies";
            this.cmb_especies.Size = new System.Drawing.Size(236, 25);
            this.cmb_especies.TabIndex = 2;
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.BackColor = System.Drawing.SystemColors.GrayText;
            this.txtPerimetro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPerimetro.Location = new System.Drawing.Point(382, 169);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.Size = new System.Drawing.Size(236, 23);
            this.txtPerimetro.TabIndex = 3;
            this.txtPerimetro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPerimetro_KeyPress);
            // 
            // txtDiametro
            // 
            this.txtDiametro.BackColor = System.Drawing.SystemColors.GrayText;
            this.txtDiametro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDiametro.Location = new System.Drawing.Point(382, 198);
            this.txtDiametro.Name = "txtDiametro";
            this.txtDiametro.Size = new System.Drawing.Size(236, 23);
            this.txtDiametro.TabIndex = 4;
            this.txtDiametro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiametro_KeyPress);
            // 
            // datePicker_validfrom
            // 
            this.datePicker_validfrom.CalendarForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.datePicker_validfrom.CalendarTitleBackColor = System.Drawing.SystemColors.GrayText;
            this.datePicker_validfrom.CalendarTitleForeColor = System.Drawing.SystemColors.GrayText;
            this.datePicker_validfrom.Location = new System.Drawing.Point(382, 227);
            this.datePicker_validfrom.Name = "datePicker_validfrom";
            this.datePicker_validfrom.Size = new System.Drawing.Size(236, 23);
            this.datePicker_validfrom.TabIndex = 5;
            // 
            // cmbCaldeira
            // 
            this.cmbCaldeira.BackColor = System.Drawing.SystemColors.GrayText;
            this.cmbCaldeira.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cmbCaldeira.FormattingEnabled = true;
            this.cmbCaldeira.Location = new System.Drawing.Point(488, 257);
            this.cmbCaldeira.Name = "cmbCaldeira";
            this.cmbCaldeira.Size = new System.Drawing.Size(130, 25);
            this.cmbCaldeira.TabIndex = 6;
            this.cmbCaldeira.Visible = false;
            // 
            // txtLocalizacao
            // 
            this.txtLocalizacao.BackColor = System.Drawing.SystemColors.GrayText;
            this.txtLocalizacao.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtLocalizacao.Location = new System.Drawing.Point(382, 285);
            this.txtLocalizacao.Name = "txtLocalizacao";
            this.txtLocalizacao.Size = new System.Drawing.Size(236, 23);
            this.txtLocalizacao.TabIndex = 7;
            // 
            // connectBDBindingSource
            // 
            this.connectBDBindingSource.DataSource = typeof(ProjetoArvore.ConnectBD);
            // 
            // cBox_Caldeira
            // 
            this.cBox_Caldeira.AutoSize = true;
            this.cBox_Caldeira.Location = new System.Drawing.Point(382, 259);
            this.cBox_Caldeira.Name = "cBox_Caldeira";
            this.cBox_Caldeira.Size = new System.Drawing.Size(49, 21);
            this.cBox_Caldeira.TabIndex = 8;
            this.cBox_Caldeira.Text = "Sim";
            this.cBox_Caldeira.UseVisualStyleBackColor = true;
            this.cBox_Caldeira.CheckedChanged += new System.EventHandler(this.cBox_Caldeira_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome Cientifico";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Altura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Diametro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Perimetro Copa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Data plantação";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Está numa caldeira?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(235, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Localização";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(1, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 383);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Location = new System.Drawing.Point(230, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 75);
            this.panel2.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Location = new System.Drawing.Point(651, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(23, 22);
            this.panel3.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.Location = new System.Drawing.Point(-646, -2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(23, 22);
            this.panel4.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(678, 410);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBox_Caldeira);
            this.Controls.Add(this.txtLocalizacao);
            this.Controls.Add(this.cmbCaldeira);
            this.Controls.Add(this.datePicker_validfrom);
            this.Controls.Add(this.txtDiametro);
            this.Controls.Add(this.txtPerimetro);
            this.Controls.Add(this.cmb_especies);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.btn_registar);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Inserir nova árvore";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.connectBDBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BindingSource connectBDBindingSource;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        public Button btn_registar;
        public TextBox txtAltura;
        public TextBox txtPerimetro;
        public TextBox txtDiametro;
        public DateTimePicker datePicker_validfrom;
        public ComboBox cmbCaldeira;
        public TextBox txtLocalizacao;
        public CheckBox cBox_Caldeira;
        public ComboBox cmb_especies;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}