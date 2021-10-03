using NUnit.Framework;
using Roleplay_Prog;
using Roleplay_Prog.Library;

namespace Test.Library
{


    public class OrcoTest
    {
        private Orco orco;
        private ICharacter dummy;
        [SetUp]
        public void Setup()
        {
            this.orco = new Orco("Joseph");
            Mazo mazo = new Mazo(50);
            this.orco.CambiarItemOf(mazo);
            Yelmo yelmo = new Yelmo(30);
            this.orco.CambiarItemDef(yelmo);
            
            this.dummy = new Wizard("Jose");
        }
        /*
            Es necesario probar la asignacion de un nombre valido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void NombreValidoTest()
        {
            this.orco.Nombre= "Mata";
            Assert.AreEqual(this.orco.Nombre, "Mata");
        }
        /*
            Es necesario probar la asignacion de un nombre invalido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void NombreInvalidoTest()
        {
            this.orco.Nombre= "";
            Assert.AreEqual(this.orco.Nombre, "Joseph");
        }
        /*
            Es necesario probar la asignacion de un valor de vida valido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void VidaValidaTest()
        {
            this.orco.Vida= 100;
            Assert.AreEqual(this.orco.Vida, 100);
        }
        /*
            Es necesario probar la asignacion de un valor de vida invalido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void VidaInvalidaTest()
        {
            this.orco.Vida= -50;
            Assert.AreEqual(this.orco.Vida, 0);
        }
        /*
            Es necesario probar este metodo para confirmar que
            el ataque que devuelve es el mismo ataque que el de su ItemOf
        */
        [Test]
        public void GetAtaqueTest()
        {
            Assert.AreEqual(this.orco.GetAtaque(), this.orco.ItemOf.Ataque);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al realizar un cambio de ItemOf se realiza el cambio correctamente
        */
        [Test]
        public void CambiarItemOfTest()
        {
            Mazo mazoNu = new Mazo(60);
            this.orco.CambiarItemOf(mazoNu);
            Assert.AreEqual(this.orco.GetAtaque(), mazoNu.Ataque);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al quitar el ItemOf este queda en null
        */
        [Test]
        public void QuitarItemOfTest()
        {
            this.orco.QuitarItemOf();
            Assert.AreEqual(this.orco.ItemOf, null);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al realizar un cambio de ItemDef se realiza el cambio correctamente
        */
         [Test]
        public void CambiarItemDefTest()
        {
            Yelmo yelmoNu = new Yelmo(50);
            this.orco.CambiarItemDef(yelmoNu);
            Assert.AreEqual(this.orco.ItemDef, yelmoNu);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al quitar el ItemDef este queda en null
        */
        [Test]
        public void QuitarItemDefTest()
        {
            this.orco.QuitarItemDef();
            Assert.AreEqual(this.orco.ItemDef, null);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al atacar a otro personaje, con un ataque menor 
            a su armadura, la vida de este no se ve afectada
        */
        [Test]
        public void DanioAtacarMenorOIgualQueArmaduraTest()
        {
            IItemDefensa tunicaCuero = new TunicaCuero(60);
            this.dummy.CambiarItemDef(tunicaCuero);
            this.orco.Atacar(this.dummy);
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
            IItemDefensa tunicaCuero = new TunicaCuero(20);
            this.dummy.CambiarItemDef(tunicaCuero);
            this.orco.Atacar(this.dummy);
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
            IItemDefensa tunicaCuero = new TunicaCuero(0);
            this.dummy.CambiarItemDef(tunicaCuero);
            IItemAtaque mazo2 = new Mazo(80);
            this.orco.CambiarItemOf(mazo2);
            this.orco.Atacar(this.dummy);
            Assert.AreEqual(this.dummy.Vida, 0);
        }

        /*
            Es necesario probar este metodo para confirmar que al curarse queda con la misma vida inicial.
        */
        [Test]
        public void CurarseTest()
        {
            this.orco.Vida = 20;
            this.orco.Curarse();
            Assert.AreEqual(this.orco.Vida, 130);
        }
        
    }


}