using NUnit.Framework;
using Roleplay_Prog;
using Roleplay_Prog.Library;

namespace Test.Library
{

    public class CuchilloTest
    {
        private Cuchillo cuchillo;
        [SetUp]
        public void Setup()
        {
            this.cuchillo = new Cuchillo(70);
        }
        /*
            Es necesario probar la asignacion de un ataque valido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void AsignarAtaqueValido()
        {
            this.cuchillo.Ataque = 20;
            Assert.AreEqual(this.cuchillo.Ataque, 20);
        }
        /*
            Es necesario probar la asignacion de un ataque invalido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void AsignarAtaqueNegativo()
        {
            this.cuchillo.Ataque = -20;
            Assert.AreEqual(this.cuchillo.Ataque, 0);
        }
        
    }


}