using NUnit.Framework;
using ProjetoArvore;
using System;

namespace TesteProjetoArvore
{
    public class Tests
    {
       [Test]
        public void ValidarRegisto()
        {
            //Assert.AreEqual(false,"1","Arvore Plantis",3.50f,);
            RepositorioArvores x = new RepositorioArvores();
            Arvore arvore= new() { Id = 2, NomeCientifico = "Arvoris Grandolis", Altura = 2.50f, Diametro = 3.60f, Perimetro = 100f, Classificacao = 10, IdConstrucao = 1, Localizacao = "porto", ValidFrom = DateOnly.Parse("2022-02-06"), ValidTo = default };
            //Arvore arvore2 = new() { Id = 1, NomeCientifico = "Arvoris Grandolis", Altura = 2.50f, Diametro = 3.60f, Perimetro = 100f, Classificacao = 10, IdConstrucao = 1, Localizacao = "porto", ValidFrom = DateOnly.Parse("2022-02-06"), ValidTo = DateOnly.Parse("2022-02-06") };
            Assert.AreEqual(false, x.AddArvore(arvore));
            Assert.AreEqual(true, x.EditArvore(arvore));
            Assert.AreEqual(true, x.MorteArvore(1, DateOnly.Parse("2022-05-04")));


        }
    }
}