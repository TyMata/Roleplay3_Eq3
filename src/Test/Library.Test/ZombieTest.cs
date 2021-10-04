using NUnit.Framework;
using Roleplay_Prog;
using Roleplay_Prog.Library;

namespace Test.Library
{


    public class ZombieTest
    {
        private Zombie zombie;
        [SetUp]
        public void Setup()
        {
            this.zombie = new Zombie("Sancho");

        }
        /*
            Es necesario probar la asignacion de un valor de vida valido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void VidaValidaTest()
        {
            this.zombie.Vida= 20;
            Assert.AreEqual(this.zombie.Vida, 20);
        }
        /*
            Es necesario probar la asignacion de un valor de vida invalido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void VidaInvalidaTest()
        {
            this.zombie.Vida= -60;
            Assert.AreEqual(this.zombie.Vida, 0);
        }
       
       

    }


}