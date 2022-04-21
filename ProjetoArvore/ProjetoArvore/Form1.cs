using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoArvore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            datePicker_validfrom.MaxDate = DateTime.Now;
            DataTable dt = new DataTable();
            ConnectBD conn = new ConnectBD();
            dt = conn.GetNomes(dt);
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                string otherNumber = dt.Rows[i].Field<string>("nomecientifico");
                cmb_especies.Items.Add(otherNumber);
                
            }
            cmb_especies.SelectedIndex = 0;
            dt.Clear();
            dt = conn.GetCaldeiras(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string otherNumber = dt.Rows[i].Field<string>("tipoconstrucao");
                cmbCaldeira.Items.Add(otherNumber);

            }
            cmbCaldeira.SelectedIndex = 0;
        }

        private void btn_registar_Click(object sender, EventArgs e)
        {
            //Verificar se campos estao preenchidos
            //Validar dados inseridos

            Arvore novaArvore= new Arvore();
            string valores=TudoPreenchido(ref novaArvore);
            if (valores == "")
            {
                ConnectBD conn = new ConnectBD();
                string res=conn.InserirArvore(novaArvore);
                MessageBox.Show(res);
            }
            else
            {
                MessageBox.Show(valores, "Campos Invalidos:");
            }
            
            
            
        }

        public void LoadComboBox()
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cBox_Caldeira_CheckedChanged(object sender, EventArgs e)
        {
            if (cBox_Caldeira.Checked)
            {
                cmbCaldeira.Visible = true;
            }
            else
                cmbCaldeira.Visible=false;
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
                DateOnly dataplantacao = DateOnly.Parse(datePicker_validfrom.Value.ToShortDateString());
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
                    tipocaldeira = (cmbCaldeira.SelectedIndex) + 1;
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


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtPerimetro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
     (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtDiametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
     (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}