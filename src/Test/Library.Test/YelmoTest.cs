using NUnit.Framework;
using Roleplay_Prog;
using Roleplay_Prog.Library;

namespace Test.Library
{


    public class YelmoTest
    {
        private Yelmo yelmo;
        [SetUp]
        public void Setup()
        {
            this.yelmo = new Yelmo(30);
        }
        /*
            Es necesario probar la asignacion de una defensa valida para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void AsignarDefensaValida()
        {
            this.yelmo.Defensa = 50;
            Assert.AreEqual(this.yelmo.Defensa, 50);
        }
        /*
            Es necesario probar la asignacion de una defensa invalida para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void AsignarDefensaNegativa()
        {
            this.yelmo.Defensa = -30;
            Assert.AreEqual(this.yelmo.Defensa, 0);
        }
    }


}