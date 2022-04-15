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
    }
}