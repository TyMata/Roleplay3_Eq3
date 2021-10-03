using NUnit.Framework;
using Roleplay_Prog;
using Roleplay_Prog.Library;
using System.Collections;

namespace Test.Library
{


    public class CharacterMagicoTest
    {
        private Wizard wizard;
        private Character dummy;
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
            Es necesario probar este metodo para confirmar que
            el ataque que devuelve es el mismo ataque que el de su LibroHechizos
        */
        [Test]
        public void GetAtaqueTest()
        {
            Assert.AreEqual(this.wizard.GetAtaque(), this.wizard.ItemOf.GetAtaque());
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
            Assert.AreEqual(this.wizard.GetAtaque(), libroHechizosNu.GetAtaque());
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
            al atacar a otro personaje, con un ataque menor 
            a su armadura, la vida de este no se ve afectada
        */
        [Test]
        public void DanioAtacarMenorOIgualQueArmaduraTest()
        {
            ItemDefensa tunicaCuero = new TunicaCuero(60);
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
            ItemDefensa tunicaCuero = new TunicaCuero(20);
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
            ItemDefensa tunicaCuero = new TunicaCuero(0);
            this.dummy.CambiarItemDef(tunicaCuero);
            Spell spellSuperior = new Spell(100,0);
            LibroHechizos libroHechizosSuperior = new LibroHechizos();
            libroHechizosSuperior.Spells.Add(spellSuperior);
            this.wizard.CambiarItemOf(libroHechizosSuperior);
            this.wizard.Atacar(this.dummy);
            Assert.AreEqual(this.dummy.Vida, 0);
        }
    }
}