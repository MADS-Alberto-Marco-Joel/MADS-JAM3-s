using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArvore
{
    public class RepositorioArvores
    {
        private List<Arvore> list_arvore;
        
        // list_arvore.Add(new Arvore() { Id = 0, NomeCientifico = "Arvoris Grandolis", Altura = 2.50f,Diametro = 3.60f,Perimetro = 100f,"20" })
        public RepositorioArvores()
        {
            list_arvore = new List<Arvore>();
            //Inserir um valor à lista para testar inserçoes repetidas
            Arvore arvore = new() { Id = 1, NomeCientifico = "Arvoris Grandolis", Altura = 2.50f, Diametro = 3.60f, Perimetro = 100f, Classificacao = 10, IdConstrucao = 1, Localizacao = "porto", ValidFrom = DateOnly.Parse("2022-02-06"), ValidTo = DateOnly.Parse("2022-02-06") };
            list_arvore.Add(arvore);
        }
        public bool AddArvore(Arvore a)
        {
            bool existe =list_arvore.Exists(x => x.Id == a.Id);
            if (existe == false)
            {
                list_arvore.Add(a);
                return false;
            }
            else
            return true;
        }
    }
}
