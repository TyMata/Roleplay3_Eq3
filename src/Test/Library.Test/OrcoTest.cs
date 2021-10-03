using NUnit.Framework;
using Roleplay_Prog;
using Roleplay_Prog.Library;

namespace Test.Library
{


    public class OrcoTest
    {
        private Orco orco;
        [SetUp]
        public void Setup()
        {
            this.orco = new Orco("Joseph");
        }
        /*
            Es necesario probar la asignacion de un valor de vida valido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void VidaValidaTest()
        {
            this.orco.Vida= 100;
            Assert.AreEqual(this.orco.Vida, 100);
        }
        /*
            Es necesario probar la asignacion de un valor de vida invalido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void VidaInvalidaTest()
        {
            this.orco.Vida= -50;
            Assert.AreEqual(this.orco.Vida, 0);
        }
        /*
            Es necesario probar este metodo para confirmar que al curarse queda con la misma vida inicial.
        */
        [Test]
        public void CurarseTest()
        {
            this.orco.Vida = 20;
            this.orco.Curarse();
            Assert.AreEqual(this.orco.Vida, 130);
        }
        
    }


}