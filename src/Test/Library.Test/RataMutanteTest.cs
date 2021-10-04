using NUnit.Framework;
using Roleplay_Prog;
using Roleplay_Prog.Library;

namespace Test.Library
{


    public class RataMutanteTest
    {
        private RataMutante rata;
        [SetUp]
        public void Setup()
        {
            this.rata = new RataMutante("Joseph");
        }
        /*
            Es necesario probar la asignacion de un valor de vida valido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void VidaValidaTest()
        {
            this.rata.Vida= 100;
            Assert.AreEqual(this.rata.Vida, 100);
        }
        /*
            Es necesario probar la asignacion de un valor de vida invalido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void VidaInvalidaTest()
        {
            this.rata.Vida= -50;
            Assert.AreEqual(this.rata.Vida, 0);
        }
    }
}