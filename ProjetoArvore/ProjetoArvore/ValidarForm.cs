using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArvore
{
    public class ValidarForm
    {
        int Especie { get; set; }
        float Altura { get; set; }
        float Diametro { get; set; }
        float Perimetro { get; set; }
        DateOnly Dataplantacao { get; set; }
        bool Caldeira { get; set; }
        int Tipocaldeira { get; set; }
        string Localizacao { get; set; }
        public ValidarForm(int especie,float altura,float diametro,float perimetro,DateOnly data,bool caldeira,int tipocaldeira,string localizacao)
        {
            Especie= especie;
            Altura= altura;
            Diametro= diametro;
            Perimetro= perimetro;
            Dataplantacao= data;
            Caldeira= caldeira;
            Tipocaldeira= tipocaldeira;
            Localizacao= localizacao;

        }
        public ValidarForm()
        {

        }
        
    }
}
