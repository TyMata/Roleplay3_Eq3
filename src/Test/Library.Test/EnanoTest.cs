using NUnit.Framework;
using Roleplay_Prog;
using Roleplay_Prog.Library;

namespace Test.Library
{


    public class EnanoTest
    {
        private Enano enano;
        [SetUp]
        public void Setup()
        {
            this.enano = new Enano("Robertinho");

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
            Es necesario probar este metodo para confirmar que al curarse queda con la misma vida inicial.
        */
        [Test]
        public void CurarseTest()
        {
            this.enano.Vida = 20;
            this.enano.Curarse();
            Assert.AreEqual(this.enano.Vida, 120);
        }

    }


}