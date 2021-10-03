using NUnit.Framework;
using Roleplay_Prog;
using Roleplay_Prog.Library;

namespace Test.Library
{


    public class ElfoTest
    {
        private Elfo elfo;
        [SetUp]
        public void Setup()
        {
            this.elfo = new Elfo("Elfo1");
        }
        /*
            Es necesario probar la asignacion de un valor de vida valido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void VidaValidaTest()
        {
            this.elfo.Vida= 30;
            Assert.AreEqual(this.elfo.Vida, 30);
        }
        /*
            Es necesario probar la asignacion de un valor de vida invalido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void VidaInvalidaTest()
        {
            this.elfo.Vida= -60;
            Assert.AreEqual(this.elfo.Vida, 0);
        }
        /*
            Es necesario probar este metodo para confirmar que al curarse queda con la misma vida inicial.
        */
        [Test]
        public void CurarseTest()
        {
            this.elfo.Vida = 20;
            this.elfo.Curarse();
            Assert.AreEqual(this.elfo.Vida, 100);
        }
    }


}