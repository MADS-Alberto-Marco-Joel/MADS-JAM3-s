using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoArvore
{
    public partial class ListarArvores : Form
    {
        public ListarArvores()
        {
            InitializeComponent();
        }
        public static int Id;
        private void ListarArvores_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            //dtGrid_Arvores.DataSource = dt;
            ConnectBD connectBD = new ConnectBD();
            dt = connectBD.GetArvoresToEdit(dt);
            dtGrid_Arvores.DataSource = dt;
        }

        private void dtGrid_Arvores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ListarArvores_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void dtGrid_Arvores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int id = Convert.ToInt32(dtGrid_Arvores[0, row].Value);
            Id = id;
            Observacoes obs = new Observacoes();
            obs.Show();
            this.Hide();
        }
    }
}
