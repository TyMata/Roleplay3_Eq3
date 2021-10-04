using NUnit.Framework;
using Roleplay_Prog;
using Roleplay_Prog.Library;

namespace Test.Library
{


    public class EnemyTest
    {
        private Esqueleto esqueleto;
        private Wizard dummy;
        [SetUp]
        public void Setup()
        {
            this.esqueleto = new Esqueleto("Esqueleto1");
            Arco arco = new Arco(50);
            this.esqueleto.CambiarItemOf(arco);
            Armadura armadura = new Armadura(20);
            this.esqueleto.CambiarItemDef(armadura);
            this.dummy = new Wizard("Jose");
        }
        /*
            Es necesario probar este metodo para confirmar que
            el ataque que devuelve es el mismo ataque que el de su ItemOf
        */
        [Test]
        public void GetAtaqueTest()
        {
            Assert.AreEqual(this.esqueleto.GetAtaque(), this.esqueleto.ItemOf.Ataque);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al realizar un cambio de ItemOf se realiza el cambio correctamente
        */
        [Test]
        public void CambiarItemOfTest()
        {
            Arco arcoNue = new Arco(60);
            this.esqueleto.CambiarItemOf(arcoNue);
            Assert.AreEqual(this.esqueleto.GetAtaque(), arcoNue.Ataque);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al quitar el ItemOf este queda en null
        */
        [Test]
        public void QuitarItemOfTest()
        {
            this.esqueleto.QuitarItemOf();
            Assert.AreEqual(this.esqueleto.ItemOf, null);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al atacar a otro personaje, con un ataque menor 
            a su armadura, la vida de este no se ve afectada
        */
        [Test]
        public void DanioAtacarMenorOIgualQueArmaduraTest()
        {
            ItemDefensa tunicaCuero = new TunicaCuero(60);
            this.dummy.CambiarItemDef(tunicaCuero);
            this.esqueleto.Atacar(this.dummy);
            Assert.AreEqual(this.dummy.Vida, 80);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al atacar a otro personaje, con un ataque mayor 
            a su armadura, la vida de este se ve afectada
        */
        [Test]
        public void DanioAtacarMayorQueArmaduraTest()
        {
            ItemDefensa tunicaCuero = new TunicaCuero(20);
            this.dummy.CambiarItemDef(tunicaCuero);
            this.esqueleto.Atacar(this.dummy);
            Assert.AreEqual(this.dummy.Vida, 50);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al atacar a otro personaje, con un ataque mayor 
            a la suma de su armadura y vida, la vida de este 
            queda en 0
        */
        [Test]
        public void DanioAtacarMayorQueArmaduraYVidaTest()
        {
            ItemDefensa tunicaCuero = new TunicaCuero(0);
            this.dummy.CambiarItemDef(tunicaCuero);
            ItemAtaque mazo2 = new Mazo(300);
            this.esqueleto.CambiarItemOf(mazo2);
            this.esqueleto.Atacar(this.dummy);
            Assert.AreEqual(this.dummy.Vida, 0);
        }
    }
}