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
            
            //MessageBox.Show(id.ToString());
            DefaultSelectedIndex();


        }

        private void Observacoes_FormClosed(object sender, FormClosedEventArgs e)
        {
            ListarArvores la = new ListarArvores();
            la.Show();
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
           Observacao observacao = new Observacao();
           GetObsArvore(ref observacao);
            ConnectBD conn = new ConnectBD();
            string res = conn.InserirObservacao(observacao);
            MessageBox.Show(res);
        }

        public void GetObsArvore(ref Observacao observacao)
        {
            observacao.IDArvore= ListarArvores.Id;
            DateOnly data = DateOnly.Parse(DateTime.Now.ToShortDateString());
            observacao.Data = data;
            observacao.InclTronco = cmbInclTronco.SelectedIndex;
            observacao.CodoTronco = cmbCondoTronco.SelectedIndex;
            observacao.CodoRamos = cmbCodoRamos.SelectedIndex;
            observacao.CascTronco = cmbcascTronco.SelectedIndex;
            observacao.CascRamos = cmbCascRamos.SelectedIndex;
            observacao.CicatrizesTronco = cmbCicatrizesTronco.SelectedIndex;
            observacao.CicatrizesRamos = cmbCicatrizesRamos.SelectedIndex;
            observacao.TorcaoTronco = cmbTorcaoTronco.SelectedIndex;
            observacao.PodridaoColo = cmbPodridaoColo.SelectedIndex;
            observacao.PodridaoRamos = cmbPodridaoRamos.SelectedIndex;
            observacao.CavidadesColo = cmbCavidadesColo.SelectedIndex;
            observacao.CavidadesTronco = cmbCavidadesTronco.SelectedIndex;
            observacao.CavidadesRamos = cmbCavidadesRamos.SelectedIndex;
            observacao.FungoColo = cmbFungoColo.SelectedIndex;
            observacao.FungoTronco = cmbFungoTronco.SelectedIndex;
            observacao.FungoRamos = cmbFungoRamos.SelectedIndex;
            observacao.ExsudacaoColo = cmbExsudacaoColo.SelectedIndex;
            observacao.ExsudacaoTronco = cmbExsudacaoTronco.SelectedIndex;
            observacao.ExsudacaoRamos = cmbExsudacaoRamos.SelectedIndex;
            observacao.MadeiraMorta = cmbMadeiraMorta.SelectedIndex;
            observacao.CancroTronco = cmbCancroTronco.SelectedIndex;
            observacao.CancroRamos = cmbCancroRamos.SelectedIndex;
            observacao.Epicormicos = cmbEpicormicos.SelectedIndex;
            observacao.PragasRamos = cmbPragasRamos.SelectedIndex;
            observacao.PragasTronco = cmbPragasTronco.SelectedIndex;


           


        }
        public void DefaultSelectedIndex()
        {
            cmbCancroRamos.SelectedIndex = 0;
            cmbCondoTronco.SelectedIndex = 0;
            cmbCavidadesColo.SelectedIndex = 0;
            cmbCancroTronco.SelectedIndex = 0;
            cmbCascRamos.SelectedIndex = 0;
            cmbcascTronco.SelectedIndex = 0;
            cmbCavidadesRamos.SelectedIndex = 0;
            cmbCavidadesTronco.SelectedIndex = 0;
            cmbCicatrizesRamos.SelectedIndex = 0;
            cmbCicatrizesTronco.SelectedIndex = 0;
            cmbCodoRamos.SelectedIndex = 0;
            cmbEpicormicos.SelectedIndex = 0;
            cmbExsudacaoColo.SelectedIndex = 0;
            cmbExsudacaoRamos.SelectedIndex = 0;
            cmbExsudacaoTronco.SelectedIndex = 0;
            cmbFungoColo.SelectedIndex = 0;
            cmbFungoRamos.SelectedIndex = 0;
            cmbFungoTronco.SelectedIndex = 0;
            cmbInclTronco.SelectedIndex = 0;
            cmbMadeiraMorta.SelectedIndex = 0;
            cmbPodridaoColo.SelectedIndex = 0;
            cmbPodridaoRamos.SelectedIndex = 0;
            cmbPragasRamos.SelectedIndex = 0;
            cmbPragasTronco.SelectedIndex = 0;
            cmbTorcaoTronco.SelectedIndex=0;
            
        }
    }
}
