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

            AtualizaDataGrid();
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
            cmb_Caldeira.Items.Clear();
            cmb_especies.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string otherNumber = dt.Rows[i].Field<string>("nomecientifico");
                cmb_especies.Items.Add(otherNumber);

            }
            dt.Clear();
            dt = conn.GetCaldeiras(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string otherNumber = dt.Rows[i].Field<string>("tipoconstrucao");
                cmb_Caldeira.Items.Add(otherNumber);

            }
            cmb_Caldeira.SelectedIndex = 0;
            cmb_Caldeira.Visible = false;

            editarArvore fr = (editarArvore)Application.OpenForms["EditarArvore"];
            int row = e.RowIndex;
            int id= Convert.ToInt32(dtGrid_Arvores[0, row].Value);
            int index = cmb_especies.Items.IndexOf(Convert.ToString(dtGrid_Arvores[1, row].Value));
            cmb_especies.SelectedIndex = index;
            fr.cmb_especies.Text = Convert.ToString(dtGrid_Arvores[1, row].Value);
            fr.txtAltura.Text = Convert.ToString(dtGrid_Arvores[2, row].Value);
            fr.txtPerimetro.Text = Convert.ToString(dtGrid_Arvores[3, row].Value);
            fr.txtDiametro.Text = Convert.ToString(dtGrid_Arvores[4, row].Value);
            string dataS = dtGrid_Arvores[5, row].Value.ToString();
            DateTime data = DateTime.Parse(dataS);
            dtPicker_ValidFrom.Value = DateTime.Parse(data.ToShortDateString());
            fr.txtLocalizacao.Text = Convert.ToString(dtGrid_Arvores[6, row].Value);
            string caldeira = dtGrid_Arvores[7, row].Value.ToString();

            if ( caldeira != "Sem caldeira")
            {
                cmb_Caldeira.Visible = true;
                index = cmb_Caldeira.Items.IndexOf(caldeira);
                cmb_Caldeira.SelectedIndex=index;
                cBox_Caldeira.Checked = true;
            }
            else
            {
                cmb_Caldeira.Visible = false;
                cBox_Caldeira.Checked = false;
            }
            


            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Arvore novaArvore = new Arvore();
            string valores = TudoPreenchido(ref novaArvore);
            if (valores == "")
            {
                ConnectBD conn = new ConnectBD();
                string res = conn.EditarArvore(novaArvore);
                MessageBox.Show(res);
                AtualizaDataGrid();
            }
            else
            {
                MessageBox.Show(valores, "Campos Invalidos:");
            }
        }
        public string TudoPreenchido(ref Arvore novaarvore)
        {
            string erros = "";
            try
            {
                int especie = (cmb_especies.SelectedIndex) + 1;
                novaarvore.NomeCientifico = especie;
            }
            catch
            {
                erros += "Nome Cientifico inexistente";
            }
            try
            {
                string abc = txtAltura.Text;
                float altura = float.Parse(txtAltura.Text);
                novaarvore.Altura = altura;
            }
            catch
            {
                erros += "Altura nula ou invalida \n";
            }
            try
            {
                float diametro = float.Parse(txtDiametro.Text);
                novaarvore.Diametro = diametro;
            }
            catch
            {
                erros += "Diametro nulo ou invalido \n";
            }
            try
            {
                float perimetro = float.Parse(txtPerimetro.Text);
                novaarvore.Perimetro = perimetro;
            }
            catch
            {
                erros += "Perimetro nulo ou invalido \n";
            }
            try
            {
                DateOnly dataplantacao = DateOnly.Parse(dtPicker_ValidFrom.Value.ToShortDateString());
                DateOnly dt = DateOnly.Parse(DateTime.Now.ToShortDateString());
                if (dataplantacao > dt)
                {
                    erros += "Data plantacao superior à data atual \n";
                }
                else
                {
                    novaarvore.ValidFrom = dataplantacao;
                }

            }
            catch
            {
                erros += "Data nula ou invalida \n";
            }

            bool caldeira;
            int tipocaldeira = -1;
            try
            {
                if (cBox_Caldeira.Checked)
                {
                    caldeira = true;
                    tipocaldeira = (cmb_Caldeira.SelectedIndex) + 1;
                    novaarvore.IdConstrucao = tipocaldeira;
                }
                else
                {
                    caldeira = false;
                    novaarvore.IdConstrucao = -1;
                }
            }
            catch
            {

            }
            try
            {
                string localizacao = txtLocalizacao.Text;
                novaarvore.Localizacao = localizacao;
            }
            catch
            {
                erros += "Localizacao nula ou invalida \n";
            }
            if (erros == "")
            {

            }
            return erros;
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void cBox_Caldeira_CheckedChanged(object sender, EventArgs e)
        {
            if (cBox_Caldeira.Checked == true)
            {
                cmb_Caldeira.Visible = true; 
            }
            else
            {
                cmb_Caldeira.Visible = false;
            }
        }

        public void AtualizaDataGrid()
        {
            
            DataTable dt = new DataTable();
            //dtGrid_Arvores.DataSource = dt;
            ConnectBD connectBD = new ConnectBD();
            dt = connectBD.GetArvoresToEdit(dt);
            dtGrid_Arvores.DataSource = dt;
        }

        private void dtPicker_ValidFrom_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void editarArvore_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void dtGrid_Arvores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtGrid_Arvores_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Linha selecionada, por favor edite as informações a baixo!");
            cmb_especies.Focus();
        }
    }
}
