namespace ProjetoArvore
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmb_especies = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbCaldeira = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.connectBDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cBox_Caldeira = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.connectBDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_registar
            // 
            this.btn_registar.Location = new System.Drawing.Point(163, 248);
            this.btn_registar.Name = "btn_registar";
            this.btn_registar.Size = new System.Drawing.Size(102, 40);
            this.btn_registar.TabIndex = 0;
            this.btn_registar.Text = "Registar";
            this.btn_registar.UseVisualStyleBackColor = true;
            this.btn_registar.Click += new System.EventHandler(this.btn_registar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 23);
            this.textBox1.TabIndex = 1;
            // 
            // cmb_especies
            // 
            this.cmb_especies.FormattingEnabled = true;
            this.cmb_especies.Location = new System.Drawing.Point(83, 35);
            this.cmb_especies.Name = "cmb_especies";
            this.cmb_especies.Size = new System.Drawing.Size(236, 23);
            this.cmb_especies.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(83, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(236, 23);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(83, 122);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(236, 23);
            this.textBox3.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(83, 151);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(236, 23);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // cmbCaldeira
            // 
            this.cmbCaldeira.FormattingEnabled = true;
            this.cmbCaldeira.Location = new System.Drawing.Point(189, 181);
            this.cmbCaldeira.Name = "cmbCaldeira";
            this.cmbCaldeira.Size = new System.Drawing.Size(130, 23);
            this.cmbCaldeira.TabIndex = 6;
            this.cmbCaldeira.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(83, 209);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(236, 23);
            this.textBox4.TabIndex = 7;
            // 
            // connectBDBindingSource
            // 
            this.connectBDBindingSource.DataSource = typeof(ProjetoArvore.ConnectBD);
            // 
            // cBox_Caldeira
            // 
            this.cBox_Caldeira.AutoSize = true;
            this.cBox_Caldeira.Location = new System.Drawing.Point(83, 183);
            this.cBox_Caldeira.Name = "cBox_Caldeira";
            this.cBox_Caldeira.Size = new System.Drawing.Size(46, 19);
            this.cBox_Caldeira.TabIndex = 8;
            this.cBox_Caldeira.Text = "Sim";
            this.cBox_Caldeira.UseVisualStyleBackColor = true;
            this.cBox_Caldeira.CheckedChanged += new System.EventHandler(this.cBox_Caldeira_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 308);
            this.Controls.Add(this.cBox_Caldeira);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.cmbCaldeira);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.cmb_especies);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_registar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.connectBDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_registar;
        private TextBox textBox1;
        private ComboBox cmb_especies;
        private TextBox textBox2;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private ComboBox cmbCaldeira;
        private TextBox textBox4;
        private BindingSource connectBDBindingSource;
        private CheckBox cBox_Caldeira;
    }
}