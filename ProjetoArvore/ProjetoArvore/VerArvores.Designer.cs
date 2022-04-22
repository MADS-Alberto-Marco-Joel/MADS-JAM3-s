namespace ProjetoArvore
{
    partial class VerArvores
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
            this.dtGrid_Arvores = new System.Windows.Forms.DataGridView();
            this.connectBDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_Arvores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectBDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGrid_Arvores
            // 
            this.dtGrid_Arvores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid_Arvores.Location = new System.Drawing.Point(12, 101);
            this.dtGrid_Arvores.Name = "dtGrid_Arvores";
            this.dtGrid_Arvores.RowTemplate.Height = 25;
            this.dtGrid_Arvores.Size = new System.Drawing.Size(776, 295);
            this.dtGrid_Arvores.TabIndex = 0;
            // 
            // connectBDBindingSource
            // 
            this.connectBDBindingSource.DataSource = typeof(ProjetoArvore.ConnectBD);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 23);
            this.textBox1.TabIndex = 1;
            // 
            // VerArvores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dtGrid_Arvores);
            this.Name = "VerArvores";
            this.Text = "VerArvores";
            this.Load += new System.EventHandler(this.VerArvores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_Arvores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectBDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtGrid_Arvores;
        private BindingSource connectBDBindingSource;
        private TextBox textBox1;
    }
}