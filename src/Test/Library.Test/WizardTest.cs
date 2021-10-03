using NUnit.Framework;
using Roleplay_Prog;
using Roleplay_Prog.Library;
using System.Collections;

namespace Test.Library
{


    public class WizardTest
    {
        private Wizard wizard;
        [SetUp]
        public void Setup()
        {
            this.wizard = new Wizard("Joseph");

        }
        /*
            Es necesario probar la asignacion de un valor de vida valido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void VidaValidaTest()
        {
            this.wizard.Vida= 100;
            Assert.AreEqual(this.wizard.Vida, 100);
        }
        /*
            Es necesario probar la asignacion de un valor de vida invalido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void VidaInvalidaTest()
        {
            this.wizard.Vida= -50;
            Assert.AreEqual(this.wizard.Vida, 0);
        }
        /*
            Es necesario probar este metodo para confirmar que al curarse queda con la misma vida inicial.
        */
        [Test]
        public void CurarseTest()
        {
            this.wizard.Vida = 20;
            this.wizard.Curarse();
            Assert.AreEqual(this.wizard.Vida, 80);
        }
    }
}