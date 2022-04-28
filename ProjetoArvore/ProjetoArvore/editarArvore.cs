using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoArvore
{
    public partial class editarArvore : Form
    {
       

        public editarArvore()
        {
            InitializeComponent();
        }

        private void editarArvore_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            ConnectBD connectBD = new ConnectBD();
            dt = connectBD.GetArvoresToEdit(dt);
            dtGrid_Arvores.DataSource = dt;

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();

        }

        private void dtGrid_Arvores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = new DataTable();
            ConnectBD conn = new ConnectBD();
            dt = conn.GetNomes(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string otherNumber = dt.Rows[i].Field<string>("nomecientifico");
                cmb_especies.Items.Add(otherNumber);

            }


            editarArvore fr = (editarArvore)Application.OpenForms["EditarArvore"];
            int row = e.RowIndex;
            cmb_especies.SelectedValue = Convert.ToString(dtGrid_Arvores[1, row].Value);
            
            fr.cmb_especies.Text = Convert.ToString(dtGrid_Arvores[1, row].Value);
            fr.textBox2.Text = Convert.ToString(dtGrid_Arvores[2, row].Value);
            fr.textBox3.Text = Convert.ToString(dtGrid_Arvores[3, row].Value);
            fr.textBox1.Text = Convert.ToString(dtGrid_Arvores[4, row].Value);
            fr.textBox4.Text = Convert.ToString(dtGrid_Arvores[5, row].Value);
            fr.textBox5.Text = Convert.ToString(dtGrid_Arvores[6, row].Value);
            

            fr.textBox5.Enabled = false;
            fr.textBox4.Enabled=false;

            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Arvore a = new Arvore();
            a.NomeCientifico=;
            a.Altura =float.Parse(textBox2.Text);
            a.Diametro= float.Parse(textBox3.Text);
            a.Perimetro=float.Parse(textBox1.Text);
        }

    }
}
