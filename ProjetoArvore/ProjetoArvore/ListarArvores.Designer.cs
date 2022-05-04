namespace ProjetoArvore
{
    partial class ListarArvores
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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_Arvores)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGrid_Arvores
            // 
            this.dtGrid_Arvores.AllowUserToAddRows = false;
            this.dtGrid_Arvores.AllowUserToDeleteRows = false;
            this.dtGrid_Arvores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrid_Arvores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid_Arvores.Location = new System.Drawing.Point(12, 79);
            this.dtGrid_Arvores.Name = "dtGrid_Arvores";
            this.dtGrid_Arvores.ReadOnly = true;
            this.dtGrid_Arvores.RowTemplate.Height = 25;
            this.dtGrid_Arvores.Size = new System.Drawing.Size(865, 278);
            this.dtGrid_Arvores.TabIndex = 2;
            this.dtGrid_Arvores.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrid_Arvores_CellContentDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 72);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecione uma árvore!";
            // 
            // ListarArvores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(889, 375);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtGrid_Arvores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ListarArvores";
            this.Text = "ListarArvores";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ListarArvores_FormClosed);
            this.Load += new System.EventHandler(this.ListarArvores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_Arvores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtGrid_Arvores;
        private Label label1;
    }
}