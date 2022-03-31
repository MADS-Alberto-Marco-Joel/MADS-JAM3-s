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
        public string NomeCientifico { get; set; }  
        public float Altura { get; set; }
        public float Diamentro { get; set; }
        public float Perimetro { get; set; }
        public DateOnly ValidFrom { get; set; }
        public DateOnly ValidTo { get; set; }
        public int IdConstrucao { get; set; } //Id do tipo de caldeira
        public string Localizacao { get; set; }
        public int Classificacao { get; set; } // Somatorio das observacoes

        //arroz






        //public static bool Existe()
    }
}
