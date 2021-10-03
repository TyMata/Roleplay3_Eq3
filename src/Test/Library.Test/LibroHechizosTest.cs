using NUnit.Framework;
using Roleplay_Prog;
using Roleplay_Prog.Library;

namespace Test.Library
{
    public class LibroHechizosTest
    {
        private LibroHechizos libroHechizos;
        private Spell spell= new Spell(50,30);
        private Spell spell2= new Spell(20,10);
        [SetUp]
        public void SetUp()
        {
            //this.spell = ;
            this.libroHechizos = new LibroHechizos();
            this.libroHechizos.AniadirSpell(this.spell);
            //this.spell2 = ;
        }
        /*
            Es necesesario probar este metodo para confirmar que 
            el ataque que devuelve es el mismo que el del spell que tiene
        */
        [Test]
        public void UnSpellGetAtaqueTest()
        {
            Assert.AreEqual(this.libroHechizos.Ataque, this.spell.Ataque);
        }
        /*
            Es necesesario probar este metodo para confirmar que 
            la defensa que devuelve es la misma que la del spell que tiene
        */
        [Test]
        public void UnSpellGetDefensaTest()
        {
            Assert.AreEqual(this.libroHechizos.Defensa, this.spell.Defensa);
        }
        /*
            Es necesesario probar este metodo para confirmar que 
            el ataque que devuelve es el mismo que el del spell que tiene
        */
        [Test]
        public void VariosSpellsGetAtaqueTest()
        {
            this.libroHechizos.AniadirSpell(this.spell2);
            Assert.AreEqual(this.libroHechizos.Ataque, this.spell.Ataque+this.spell2.Ataque);
        }
        /*
            Es necesesario probar este metodo para confirmar que 
            la defensa que devuelve es la misma que la del spell que tiene
        */
        [Test]
        public void VariosSpellsGetDefensaTest()
        {
            this.libroHechizos.AniadirSpell(this.spell2);
            Assert.AreEqual(this.libroHechizos.Defensa, this.spell.Defensa+this.spell2.Defensa);
        }

    }
}