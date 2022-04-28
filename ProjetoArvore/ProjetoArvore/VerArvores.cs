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
    public partial class VerArvores : Form
    {
        public VerArvores()
        {
            InitializeComponent();
        }

        private void VerArvores_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            ConnectBD connectBD = new ConnectBD();
            dt = connectBD.GetArvores(dt);
            dtGrid_Arvores.DataSource = dt;
        }

        private void dtGrid_Arvores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
