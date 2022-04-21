using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArvore
{
    public class Arvore
    {
        public Arvore()
        {

        }
        
        public int Id { get; set; }
        public int NomeCientifico { get; set; }  
        public float Altura { get; set; }
        public float Diametro { get; set; }
        public float Perimetro { get; set; }
        public DateOnly ValidFrom { get; set; }
        public DateOnly ValidTo { get; set; }
        public int IdConstrucao { get; set; } //Id do tipo de caldeira
        public string Localizacao { get; set; }
        public int Classificacao { get; set; } // Somatorio das observacoes

        public Arvore(int nomecientifico,float altura,float diamentro,float perimetro,DateOnly validfrom,DateOnly validto,int idconstrucao,string localizacao,int classificacao)
        {
            NomeCientifico = nomecientifico;
            Altura = altura;
            Diametro = diamentro;
            Perimetro = perimetro;
            ValidFrom = validfrom;
            ValidTo = default;
            IdConstrucao = idconstrucao;
            Localizacao = localizacao;
            Classificacao = 0;
        }

        public static bool Existe(List<Arvore> list_arvores,Arvore nova)
        {
            return false;
        }
    }
}
