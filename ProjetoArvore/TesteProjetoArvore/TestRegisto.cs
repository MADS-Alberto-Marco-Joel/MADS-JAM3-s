using NUnit.Framework;
using ProjetoArvore;
using System.Configuration;
using System;

namespace TesteProjetoArvore
{
    public class Tests
    {
        [Test]
        public void ValidarRegisto()
        {

            Arvore a = new Arvore(1, 260, 200, 300, DateOnly.Parse("05/05/2022"), 1, "https://goo.gl/maps/85tqVAwUHyitY22GA", 0);
            ConnectBD x = new ConnectBD();
            Assert.AreEqual("Inserido com sucesso", x.InserirArvore(a));
           
        }
       
    }
}