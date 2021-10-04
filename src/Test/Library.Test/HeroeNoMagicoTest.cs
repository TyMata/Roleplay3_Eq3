using NUnit.Framework;
using Roleplay_Prog;
using Roleplay_Prog.Library;

namespace Test.Library
{


    public class HeroeNoMagicoNoMagicoTest
    {
        private Elfo HeroeNoMagico;
        private HeroeNoMagico dummy;
        [SetUp]
        public void Setup()
        {
            this.HeroeNoMagico = new Elfo("HeroeNoMagico1");
            Arco arco = new Arco(50);
            this.HeroeNoMagico.CambiarItemOf(arco);
            Armadura armadura = new Armadura(20);
            this.HeroeNoMagico.CambiarItemDef(armadura);
            this.dummy = new Elfo("Jose");
        }
        /*
            Es necesario probar este metodo para confirmar que
            el ataque que devuelve es el mismo ataque que el de su ItemOf
        */
        [Test]
        public void GetAtaqueTest()
        {
            Assert.AreEqual(this.HeroeNoMagico.GetAtaque(), this.HeroeNoMagico.ItemOf.Ataque);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al realizar un cambio de ItemOf se realiza el cambio correctamente
        */
        [Test]
        public void CambiarItemOfTest()
        {
            Arco arcoNue = new Arco(60);
            this.HeroeNoMagico.CambiarItemOf(arcoNue);
            Assert.AreEqual(this.HeroeNoMagico.GetAtaque(), arcoNue.Ataque);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al quitar el ItemOf este queda en null
        */
        [Test]
        public void QuitarItemOfTest()
        {
            this.HeroeNoMagico.QuitarItemOf();
            Assert.AreEqual(this.HeroeNoMagico.ItemOf, null);
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
            this.HeroeNoMagico.Atacar(this.dummy);
            Assert.AreEqual(this.dummy.Vida, 100);
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
            this.HeroeNoMagico.Atacar(this.dummy);
            Assert.AreEqual(this.dummy.Vida, 70);
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
            ItemAtaque mazo2 = new Mazo(999);
            this.HeroeNoMagico.CambiarItemOf(mazo2);
            this.HeroeNoMagico.Atacar(this.dummy);
            Assert.AreEqual(this.dummy.Vida, 0);
        }
    }


}