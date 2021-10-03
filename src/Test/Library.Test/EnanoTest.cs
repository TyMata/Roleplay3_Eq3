using NUnit.Framework;
using Roleplay_Prog;
using Roleplay_Prog.Library;

namespace Test.Library
{


    public class EnanoTest
    {
        private Enano enano;
        private ICharacter dummy;
        [SetUp]
        public void Setup()
        {
            this.enano = new Enano("Robertinho");
            Cuchillo cuchillo = new Cuchillo(50);
            this.enano.CambiarItemOf(cuchillo);
            Escudo escudo = new Escudo(30);
            this.enano.CambiarItemDef(escudo);
            this.dummy = new Wizard("Jose");

        }
        /*
            Es necesario probar la asignacion de un nombre valido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void NombreValidoTest()
        {
            this.enano.Nombre= "Fatiga";
            Assert.AreEqual(this.enano.Nombre, "Fatiga");
        }
        /*
            Es necesario probar la asignacion de un nombre invalido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void NombreInvalidoTest()
        {
            this.enano.Nombre= "";
            Assert.AreEqual(this.enano.Nombre, "Robertinho");
        }
        /*
            Es necesario probar la asignacion de un valor de vida valido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void VidaValidaTest()
        {
            this.enano.Vida= 20;
            Assert.AreEqual(this.enano.Vida, 20);
        }
        /*
            Es necesario probar la asignacion de un valor de vida invalido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void VidaInvalidaTest()
        {
            this.enano.Vida= -60;
            Assert.AreEqual(this.enano.Vida, 0);
        }
        /*
            Es necesario probar este metodo para confirmar que
            el ataque que devuelve es el mismo ataque que el de su ItemOf
        */
        [Test]
        public void GetAtaqueTest()
        {
            Assert.AreEqual(this.enano.GetAtaque(), this.enano.ItemOf.Ataque);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al realizar un cambio de ItemOf se realiza el cambio correctamente
        */
        [Test]
        public void CambiarItemOfTest()
        {
            Cuchillo cuchilloNue = new Cuchillo(40);
            this.enano.CambiarItemOf(cuchilloNue);
            Assert.AreEqual(this.enano.GetAtaque(), cuchilloNue.Ataque);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al quitar el ItemOf este queda en null
        */
        [Test]
        public void QuitarItemOfTest()
        {
            this.enano.QuitarItemOf();
            Assert.AreEqual(this.enano.ItemOf, null);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al realizar un cambio de ItemDef se realiza el cambio correctamente
        */
         [Test]
        public void CambiarItemDefTest()
        {
            Escudo escudoNue = new Escudo(50);
            this.enano.CambiarItemDef(escudoNue);
            Assert.AreEqual(this.enano.ItemDef, escudoNue);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al quitar el ItemDef este queda en null
        */
        [Test]
        public void QuitarItemDefTest()
        {
            this.enano.QuitarItemDef();
            Assert.AreEqual(this.enano.ItemDef, null);
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
            this.enano.Atacar(this.dummy);
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
            this.enano.Atacar(this.dummy);
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
            this.enano.CambiarItemOf(mazo2);
            this.enano.Atacar(this.dummy);
            Assert.AreEqual(this.dummy.Vida, 0);
        }
        /*
            Es necesario probar este metodo para confirmar que al curarse queda con la misma vida inicial.
        */
        [Test]
        public void CurarseTest()
        {
            this.enano.Vida = 20;
            this.enano.Curarse();
            Assert.AreEqual(this.enano.Vida, 110);
        }

    }


}