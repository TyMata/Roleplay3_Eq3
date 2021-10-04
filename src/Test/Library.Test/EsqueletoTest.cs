using NUnit.Framework;
using Roleplay_Prog;
using Roleplay_Prog.Library;

namespace Test.Library
{


    public class EsqueletoTest
    {
        private Esqueleto esqueleto;
        [SetUp]
        public void Setup()
        {
            this.esqueleto = new Esqueleto("Esqueleto");
        }
        /*
            Es necesario probar la asignacion de un valor de vida valido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void VidaValidaTest()
        {
            this.esqueleto.Vida= 30;
            Assert.AreEqual(this.esqueleto.Vida, 30);
        }
        /*
            Es necesario probar la asignacion de un valor de vida invalido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void VidaInvalidaTest()
        {
            this.esqueleto.Vida= -60;
            Assert.AreEqual(this.esqueleto.Vida, 0);
        }
    }
}