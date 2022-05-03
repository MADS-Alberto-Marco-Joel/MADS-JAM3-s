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
            // ListarArvores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 375);
            this.Controls.Add(this.dtGrid_Arvores);
            this.Name = "ListarArvores";
            this.Text = "ListarArvores";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ListarArvores_FormClosed);
            this.Load += new System.EventHandler(this.ListarArvores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_Arvores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dtGrid_Arvores;
    }
}