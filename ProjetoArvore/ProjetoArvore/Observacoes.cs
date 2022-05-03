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
    public partial class Observacoes : Form
    {
        public Observacoes()
        {
            
            InitializeComponent();
           
        }

        private void Observacoes_Load(object sender, EventArgs e)
        {
            int id = ListarArvores.Id;
            MessageBox.Show(id.ToString());
        }

        private void Observacoes_FormClosed(object sender, FormClosedEventArgs e)
        {
            ListarArvores la = new ListarArvores();
            la.Show();
        }
    }
}
