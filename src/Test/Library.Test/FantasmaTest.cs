using NUnit.Framework;
using Roleplay_Prog;
using Roleplay_Prog.Library;

namespace Test.Library
{


    public class FantasmaTest
    {
        private Fantasma fantasma;
        [SetUp]
        public void Setup()
        {
            this.fantasma = new Fantasma("Aurelio");
        }
        /*
            Es necesario probar la asignacion de un valor de vida valido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void VidaValidaTest()
        {
            this.fantasma.Vida= 100;
            Assert.AreEqual(this.fantasma.Vida, 100);
        }
        /*
            Es necesario probar la asignacion de un valor de vida invalido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void VidaInvalidaTest()
        {
            this.fantasma.Vida= -40;
            Assert.AreEqual(this.fantasma.Vida, 0);
        }
    }
}
