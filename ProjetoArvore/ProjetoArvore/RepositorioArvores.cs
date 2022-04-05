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
            Arvore arvore = new() { Id = 1, NomeCientifico = "Arvoris Grandolis", Altura = 2.50f, Diametro = 3.60f, Perimetro = 100f, Classificacao = 10, IdConstrucao = 1, Localizacao = "porto", ValidFrom = DateOnly.Parse("2022-02-06"), ValidTo = default };
            list_arvore.Add(arvore);
        }
        public bool AddArvore(Arvore a)
        {
            try
            {
                bool existe = list_arvore.Exists(x => x.Id == a.Id);
                if (existe == false)
                {
                    list_arvore.Add(a);
                    return false;
                }
                else
                    return true;
            }
            catch
            {
                return true;
            }
        }

        public bool EditArvore(Arvore a)
        {
            int index = list_arvore.FindIndex(x => x.Id == a.Id);
            if (index == -1)
                return false;
            else
            {
                list_arvore[index] = a;
                return true;
            }
           // MessageBox.Show(index.ToString());

        }

        public bool MorteArvore(int id,DateOnly dt)
        {
            int index = list_arvore.FindIndex(x => x.Id == id);
            if (index == -1)
                return false;
            else
            {
                DateOnly validFrom = list_arvore[index].ValidFrom;
                if (dt > validFrom)
                {
                    list_arvore[index].ValidTo = dt;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
        }

    }
}
