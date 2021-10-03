using NUnit.Framework;
using Roleplay_Prog;
using Roleplay_Prog.Library;
using System.Collections;

namespace Test.Library
{


    public class WizardTest
    {
        private Wizard wizard;
        private ICharacter dummy;
        [SetUp]
        public void Setup()
        {
            this.wizard = new Wizard("Joseph");
            Spell spell = new Spell(50,0);
            LibroHechizos libroHechizos = new LibroHechizos();
            libroHechizos.Spells.Add(spell);
            this.wizard.CambiarItemOf(libroHechizos);
            TunicaCuero tunicaCuero = new TunicaCuero(30);
            this.wizard.CambiarItemDef(tunicaCuero);

            this.dummy = new Wizard("Jose");

        }
        /*
            Es necesario probar la asignacion de un nombre valido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void NombreValidoTest()
        {
            this.wizard.Nombre= "Mata";
            Assert.AreEqual(this.wizard.Nombre, "Mata");
        }
        /*
            Es necesario probar la asignacion de un nombre invalido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void NombreInvalidoTest()
        {
            this.wizard.Nombre= "";
            Assert.AreEqual(this.wizard.Nombre, "Joseph");
        }
        /*
            Es necesario probar la asignacion de un valor de vida valido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void VidaValidaTest()
        {
            this.wizard.Vida= 100;
            Assert.AreEqual(this.wizard.Vida, 100);
        }
        /*
            Es necesario probar la asignacion de un valor de vida invalido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void VidaInvalidaTest()
        {
            this.wizard.Vida= -50;
            Assert.AreEqual(this.wizard.Vida, 0);
        }
        /*
            Es necesario probar este metodo para confirmar que
            el ataque que devuelve es el mismo ataque que el de su LibroHechizos
        */
        [Test]
        public void GetAtaqueTest()
        {
            Assert.AreEqual(this.wizard.GetAtaque(), this.wizard.ItemOf.Ataque);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al realizar un cambio de LibroHechizos se realiza el cambio correctamente
        */
        [Test]
        public void CambiarLibroHechizosTest()
        {
            Spell spellNu = new Spell(30, 0);
            LibroHechizos libroHechizosNu = new LibroHechizos();
            libroHechizosNu.Spells.Add(spellNu);
            this.wizard.CambiarItemOf(libroHechizosNu);
            Assert.AreEqual(this.wizard.GetAtaque(), libroHechizosNu.Ataque);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al quitar el LibroHechizos este queda en null
        */
        [Test]
        public void QuitarLibroHechizosTest()
        {
            this.wizard.QuitarItemOf();
            Assert.AreEqual(this.wizard.ItemOf, null);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al realizar un cambio de ItemDef se realiza el cambio correctamente
        */
         [Test]
        public void CambiarItemDefTest()
        {
            TunicaCuero tunicaCueroNu = new TunicaCuero(50);
            this.wizard.CambiarItemDef(tunicaCueroNu);
            Assert.AreEqual(this.wizard.ItemDef, tunicaCueroNu);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al quitar el ItemDef este queda en null
        */
        [Test]
        public void QuitarItemDefTest()
        {
            this.wizard.QuitarItemDef();
            Assert.AreEqual(this.wizard.ItemDef, null);
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
            this.wizard.Atacar(this.dummy);
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
            this.wizard.Atacar(this.dummy);
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
            Spell spellSuperior = new Spell(100,0);
            LibroHechizos libroHechizosSuperior = new LibroHechizos();
            libroHechizosSuperior.Spells.Add(spellSuperior);
            this.wizard.CambiarItemOf(libroHechizosSuperior);
            this.wizard.Atacar(this.dummy);
            Assert.AreEqual(this.dummy.Vida, 0);
        }
        /*
            Es necesario probar este metodo para confirmar que al curarse queda con la misma vida inicial.
        */
        [Test]
        public void CurarseTest()
        {
            this.wizard.Vida = 20;
            this.wizard.Curarse();
            Assert.AreEqual(this.wizard.Vida, 80);
        }
    }
}