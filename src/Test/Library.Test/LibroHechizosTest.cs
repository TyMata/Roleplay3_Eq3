using NUnit.Framework;
using Roleplay_Prog;
using Roleplay_Prog.Library;

namespace Test.Library
{
    public class LibroHechizosTest
    {
        private LibroHechizos libroHechizos;
        private Spell spell= new Spell(50,30);
        [SetUp]
        public void SetUp()
        {
            this.libroHechizos = new LibroHechizos();
        }

        [Test]
        public void AniadirSpellTest()
        {
            this.libroHechizos.AniadirSpell(spell);
            Assert.IsNotEmpty(this.libroHechizos.Spells);
        }
    }
}