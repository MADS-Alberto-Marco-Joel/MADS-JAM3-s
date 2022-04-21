using NUnit.Framework;
using ProjetoArvore;
using System;

namespace TesteProjetoArvore
{
    public class Tests
    {
        RepositorioArvores x = new RepositorioArvores();
        Arvore arvore = new() { Id = 2, NomeCientifico = 1, Altura = 2.50f, Diametro = 3.60f, Perimetro = 100f, Classificacao = 10, IdConstrucao = 1, Localizacao = "porto", ValidFrom = DateOnly.Parse("2022-02-06"), ValidTo = default };

        [Test]
        public void ValidarRegisto()
        {
           Assert.AreEqual(false, x.AddArvore(arvore));
           

        }
        public void EditaArvore()
        {
             Assert.AreEqual(true, x.EditArvore(arvore));
        }
        public void MorteArvore()
        {
            Assert.AreEqual(true, x.EditArvore(arvore));
        }
    }
}