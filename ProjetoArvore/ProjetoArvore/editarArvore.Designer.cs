namespace ProjetoArvore
{
    partial class editarArvore
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
            this.dtGrid_Arvores = new System.Windows.Forms.DataGridView();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtDiametro = new System.Windows.Forms.TextBox();
            this.txtLocalizacao = new System.Windows.Forms.TextBox();
            this.cmb_especies = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.cmb_Caldeira = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cBox_Caldeira = new System.Windows.Forms.CheckBox();
            this.dtPicker_ValidFrom = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_Arvores)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGrid_Arvores
            // 
            this.dtGrid_Arvores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrid_Arvores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid_Arvores.Location = new System.Drawing.Point(12, 43);
            this.dtGrid_Arvores.Name = "dtGrid_Arvores";
            this.dtGrid_Arvores.RowTemplate.Height = 25;
            this.dtGrid_Arvores.Size = new System.Drawing.Size(818, 295);
            this.dtGrid_Arvores.TabIndex = 1;
            this.dtGrid_Arvores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrid_Arvores_CellContentClick);
            this.dtGrid_Arvores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrid_Arvores_CellDoubleClick);
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(278, 380);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 23);
            this.txtAltura.TabIndex = 22;
            // 
            // txtDiametro
            // 
            this.txtDiametro.Location = new System.Drawing.Point(409, 380);
            this.txtDiametro.Name = "txtDiametro";
            this.txtDiametro.Size = new System.Drawing.Size(100, 23);
            this.txtDiametro.TabIndex = 23;
            // 
            // txtLocalizacao
            // 
            this.txtLocalizacao.Location = new System.Drawing.Point(28, 431);
            this.txtLocalizacao.Name = "txtLocalizacao";
            this.txtLocalizacao.Size = new System.Drawing.Size(392, 23);
            this.txtLocalizacao.TabIndex = 25;
            // 
            // cmb_especies
            // 
            this.cmb_especies.BackColor = System.Drawing.SystemColors.GrayText;
            this.cmb_especies.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmb_especies.FormattingEnabled = true;
            this.cmb_especies.Location = new System.Drawing.Point(28, 380);
            this.cmb_especies.Name = "cmb_especies";
            this.cmb_especies.Size = new System.Drawing.Size(236, 23);
            this.cmb_especies.TabIndex = 26;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_save.Location = new System.Drawing.Point(676, 505);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(102, 40);
            this.btn_save.TabIndex = 27;
            this.btn_save.Text = "Guardar";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nome Cientifico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(278, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "Altura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(409, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "Diametro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(666, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 31;
            this.label4.Text = "ValidFrom";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(28, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 32;
            this.label5.Text = "Localização";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(537, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 34;
            this.label6.Text = "Perimetro";
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Location = new System.Drawing.Point(537, 380);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.Size = new System.Drawing.Size(100, 23);
            this.txtPerimetro.TabIndex = 33;
            // 
            // cmb_Caldeira
            // 
            this.cmb_Caldeira.BackColor = System.Drawing.SystemColors.GrayText;
            this.cmb_Caldeira.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmb_Caldeira.FormattingEnabled = true;
            this.cmb_Caldeira.Location = new System.Drawing.Point(619, 431);
            this.cmb_Caldeira.Name = "cmb_Caldeira";
            this.cmb_Caldeira.Size = new System.Drawing.Size(167, 23);
            this.cmb_Caldeira.TabIndex = 35;
            this.cmb_Caldeira.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(450, 436);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 15);
            this.label8.TabIndex = 38;
            this.label8.Text = "Está numa caldeira?";
            // 
            // cBox_Caldeira
            // 
            this.cBox_Caldeira.AutoSize = true;
            this.cBox_Caldeira.ForeColor = System.Drawing.Color.White;
            this.cBox_Caldeira.Location = new System.Drawing.Point(567, 435);
            this.cBox_Caldeira.Name = "cBox_Caldeira";
            this.cBox_Caldeira.Size = new System.Drawing.Size(46, 19);
            this.cBox_Caldeira.TabIndex = 37;
            this.cBox_Caldeira.Text = "Sim";
            this.cBox_Caldeira.UseVisualStyleBackColor = true;
            this.cBox_Caldeira.CheckedChanged += new System.EventHandler(this.cBox_Caldeira_CheckedChanged);
            // 
            // dtPicker_ValidFrom
            // 
            this.dtPicker_ValidFrom.Location = new System.Drawing.Point(666, 380);
            this.dtPicker_ValidFrom.MaxDate = new System.DateTime(2022, 5, 3, 0, 0, 0, 0);
            this.dtPicker_ValidFrom.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtPicker_ValidFrom.Name = "dtPicker_ValidFrom";
            this.dtPicker_ValidFrom.Size = new System.Drawing.Size(154, 23);
            this.dtPicker_ValidFrom.TabIndex = 39;
            this.dtPicker_ValidFrom.Value = new System.DateTime(2022, 5, 3, 0, 0, 0, 0);
            this.dtPicker_ValidFrom.ValueChanged += new System.EventHandler(this.dtPicker_ValidFrom_ValueChanged);
            // 
            // editarArvore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(860, 568);
            this.Controls.Add(this.dtPicker_ValidFrom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cBox_Caldeira);
            this.Controls.Add(this.cmb_Caldeira);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPerimetro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.cmb_especies);
            this.Controls.Add(this.txtLocalizacao);
            this.Controls.Add(this.txtDiametro);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.dtGrid_Arvores);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "editarArvore";
            this.Text = "editarArvore";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.editarArvore_FormClosed);
            this.Load += new System.EventHandler(this.editarArvore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_Arvores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtGrid_Arvores;
        private TextBox txtAltura;
        private TextBox txtDiametro;
        private TextBox txtLocalizacao;
        public ComboBox cmb_especies;
        public Button btn_save;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtPerimetro;
        public ComboBox cmb_Caldeira;
        private Label label8;
        public CheckBox cBox_Caldeira;
        private DateTimePicker dtPicker_ValidFrom;
    }
}