using NUnit.Framework;
using Roleplay_Prog;
using Roleplay_Prog.Library;
using System.Collections.Generic;

namespace Test.Library
{
    public class EncuentroTest
    {
        private Encuentros encuentro;
        private Orco orco1 = new Orco("Orquito");
        private Elfo elfo1 = new Elfo("Lego-las");

        private Esqueleto esqueleto1 = new Esqueleto("Esqueleto1");
        private Esqueleto esqueleto2 = new Esqueleto("Esqueleto2");
        private Esqueleto esqueleto3 = new Esqueleto("Esqueleto3");
        private Esqueleto esqueleto4 = new Esqueleto("Esqueleto4");
        private Esqueleto esqueleto5 = new Esqueleto("Esqueleto5");

        private List <IHeroes> listaHeroes = new List<IHeroes>();
        private List <Enemy> listaEnemy1 = new List<Enemy>();
        private List <Enemy> listaEnemy3 = new List<Enemy>();
        private List <Enemy> listaEnemy5 = new List<Enemy>();
        [SetUp]
        public void SetUp()
        {
            this.listaHeroes.Add(this.orco1);
            this.listaHeroes.Add(this.elfo1);

            this.listaEnemy1.Add(this.esqueleto1);
            this.listaEnemy3.Add(this.esqueleto1);
            this.listaEnemy3.Add(this.esqueleto2);
            this.listaEnemy3.Add(this.esqueleto3);
            this.listaEnemy5.Add(this.esqueleto1);
            this.listaEnemy5.Add(this.esqueleto2);
            this.listaEnemy5.Add(this.esqueleto3);
            this.listaEnemy5.Add(this.esqueleto4);
            this.listaEnemy5.Add(this.esqueleto5);

            ItemDefensa tunicaCuero = new TunicaCuero(20);
            this.esqueleto1.CambiarItemDef(tunicaCuero);
            this.esqueleto2.CambiarItemDef(tunicaCuero);
            this.esqueleto3.CambiarItemDef(tunicaCuero);
            this.esqueleto4.CambiarItemDef(tunicaCuero);
            this.esqueleto5.CambiarItemDef(tunicaCuero);
            this.orco1.CambiarItemDef(tunicaCuero);
            this.elfo1.CambiarItemDef(tunicaCuero);
            ItemAtaque mazo = new Mazo(30);
            this.esqueleto1.CambiarItemOf(mazo);
            this.esqueleto2.CambiarItemOf(mazo);
            this.esqueleto3.CambiarItemOf(mazo);
            this.esqueleto4.CambiarItemOf(mazo);
            this.esqueleto5.CambiarItemOf(mazo);

            this.elfo1.CambiarItemOf(mazo);
            this.orco1.CambiarItemOf(mazo);

        }

        [Test]
        public void MayorNumeroEnemigosTest()
        {
            Encuentros encuentro = new Encuentros(this.listaHeroes, this.listaEnemy5);
            Assert.IsTrue(encuentro.DoEnconter());
        }
    }
}