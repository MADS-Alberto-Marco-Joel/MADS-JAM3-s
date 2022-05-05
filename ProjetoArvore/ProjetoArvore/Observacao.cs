using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArvore
{
    public class Observacao
    {

        public Observacao()
        {

        }
        public int IDArvore { get; set; }
        public DateOnly Data { get; set; }
        public int InclTronco { get; set; }
        public int CodoTronco { get; set; }
        public int CodoRamos { get; set; }
        public int CascTronco { get; set; }
        public int CascRamos { get; set; }
        public int CicatrizesTronco { get; set; }
        public int CicatrizesRamos { get; set; }
        public int TorcaoTronco { get; set; }
        public int PodridaoColo { get; set; }
        public int PodridaoRamos { get; set; }
        public int CavidadesColo { get; set; }
        public int CavidadesRamos { get; set; }
        public int CavidadesTronco { get; set; }
        public int FungoColo { get; set; }
        public int FungoTronco { get; set; }
        public int FungoRamos { get; set; }
        public int ExsudacaoColo { get; set; }
        public int ExsudacaoTronco { get; set; }
        public int ExsudacaoRamos { get; set; }
        public int MadeiraMorta { get; set; }
        public int CancroTronco { get; set; }
        public int CancroRamos { get; set; }
        public int Epicormicos { get; set; }
        public int PragasTronco { get; set; }
        public int PragasRamos { get; set; }

        public Observacao(int iDArvore, DateOnly data, int inclTronco, int codoTronco, int codoRamos, int cascTronco, int cascRamos, int cicatrizesTronco, int cicatrizesRamos, int torcaoTronco, int podridaoColo, int podridaoRamos, int cavidadesColo, int cavidadesRamos, int cavidadesTronco, int fungoColo, int fungoTronco, int fungoRamos, int exsudacaoColo, int exsudacaoTronco, int exsudacaoRamos, int madeiraMorta, int cancroTronco, int cancroRamos, int epicormicos, int pragasTronco, int pragasRamos)
        {
            IDArvore = iDArvore;
            Data = data;
            InclTronco = inclTronco;
            CodoTronco = codoTronco;
            CodoRamos = codoRamos;
            CascTronco = cascTronco;
            CascRamos = cascRamos;
            CicatrizesTronco = cicatrizesTronco;
            CicatrizesRamos = cicatrizesRamos;
            TorcaoTronco = torcaoTronco;
            PodridaoColo = podridaoColo;
            PodridaoRamos = podridaoRamos;
            CavidadesColo = cavidadesColo;
            CavidadesRamos = cavidadesRamos;
            CavidadesTronco = cavidadesTronco;
            FungoColo = fungoColo;
            FungoTronco = fungoTronco;
            FungoRamos = fungoRamos;
            ExsudacaoColo = exsudacaoColo;
            ExsudacaoTronco = exsudacaoTronco;
            ExsudacaoRamos = exsudacaoRamos;
            MadeiraMorta = madeiraMorta;
            CancroTronco = cancroTronco;
            CancroRamos = cancroRamos;
            Epicormicos = epicormicos;
            PragasTronco = pragasTronco;
            PragasRamos = pragasRamos;
        }
    }
}
