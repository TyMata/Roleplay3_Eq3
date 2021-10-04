using NUnit.Framework;
using Roleplay_Prog;
using Roleplay_Prog.Library;

namespace Test.Library
{


    public class FantasmaTest
    {
        private Fantasma Fantasma;
        [SetUp]
        public void Setup()
        {
            this.Fantasma = new Fantasma("Aurelio");
        }
        /*
            Es necesario probar la asignacion de un valor de vida valido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void VidaValidaTest()
        {
            this.rata.Vida= 100;
            Assert.AreEqual(this.Fantasma.Vida, 100);
        }
        /*
            Es necesario probar la asignacion de un valor de vida invalido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void VidaInvalidaTest()
        {
            this.rata.Vida= -40;
            Assert.AreEqual(this.Fantasma.Vida, 0);
        }
    }
}
