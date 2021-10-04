using NUnit.Framework;
using Roleplay_Prog;
using Roleplay_Prog.Library;
using System.Collections.Generic;

namespace Test.Library
{
    public class EncuentroTest
    {
        private Encuentros encuentro;
        private Wizard wizard1 = new Wizard("Merlón");
        private Elfo elf1 = new Elfo("Lego-las");

        private Esqueleto esqueleto1 = new Esqueleto("Esqueleto1");
        private Esqueleto esqueleto2 = new Esqueleto("Esqueleto2");
        private Esqueleto esqueleto3 = new Esqueleto("Esqueleto3");
        private Esqueleto esqueleto4 = new Esqueleto("Esqueleto4");
        private Esqueleto esqueleto5 = new Esqueleto("Esqueleto5");

        private List <IHeroes> listaHeroes = new List<IHeroes>();
        private List <Enemy> listaEnemy1;
        private List <Enemy> listaEnemy3;
        private List <Enemy> listaEnemy7;
        [SetUp]
        public void SetUp()
        {
            listaHeroes.Add(wizard1);
            listaHeroes.Add(elf1);

            listaEnemy1.Add(esqueleto1);
            listaEnemy3.Add(esqueleto1);
            listaEnemy3.Add(esqueleto2);
            listaEnemy3.Add(esqueleto3);
            listaEnemy7.Add(esqueleto1);
            listaEnemy7.Add(esqueleto2);
            listaEnemy7.Add(esqueleto3);
            listaEnemy7.Add(esqueleto4);
            listaEnemy7.Add(esqueleto5);
        }

        [Test]
        public void MayorNumeroEnemigosTest()
        {
            this.encuentro = new Encuentros(listaHeroes, listaEnemy7);
            this.encuentro.DoEnconter();
        }

        [Test]
        public void MayorNumeroHeroesTest()
        {
            this.encuentro = new Encuentros(listaHeroes, listaEnemy1);
            this.encuentro.DoEnconter();
        }

        [Test]
        public void IgualNumeroEnemigosYHeroesTest()
        {
            this.encuentro = new Encuentros(listaHeroes, listaEnemy3);
            this.encuentro.DoEnconter();
        }

        [Test]
        public void GanarVP()
        {
            
        }

    }
}