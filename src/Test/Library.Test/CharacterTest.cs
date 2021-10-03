using NUnit.Framework;
using Roleplay_Prog;
using Roleplay_Prog.Library;

namespace Test.Library
{


    public class CharacterTest
    {
        private Character character;
        private Character dummy;
        [SetUp]
        public void Setup()
        {
            this.character = new Elfo("Character1");
            Armadura armadura = new Armadura(20);
            this.character.CambiarItemDef(armadura);
            this.dummy = new Wizard("Jose");
        }
        /*
            Es necesario probar la asignacion de un nombre valido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void NombreValidoTest()
        {
            this.character.Nombre= "Ebola";
            Assert.AreEqual(this.character.Nombre, "Ebola");
        }
        /*
            Es necesario probar la asignacion de un nombre invalido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void NombreInvalidoTest()
        {
            this.character.Nombre= "";
            Assert.AreEqual(this.character.Nombre, "Character1");
        }
        /*
            Es necesario probar la asignacion de un valor de vida valido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void VidaValidaTest()
        {
            this.character.Vida= 30;
            Assert.AreEqual(this.character.Vida, 30);
        }
        /*
            Es necesario probar la asignacion de un valor de vida invalido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void VidaInvalidaTest()
        {
            this.character.Vida= -60;
            Assert.AreEqual(this.character.Vida, 0);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al realizar un cambio de ItemDef se realiza el cambio correctamente
        */
         [Test]
        public void CambiarItemDefTest()
        {
            Armadura armaduraNue = new Armadura(40);
            this.character.CambiarItemDef(armaduraNue);
            Assert.AreEqual(this.character.ItemDef, armaduraNue);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al quitar el ItemDef este queda en null
        */
        [Test]
        public void QuitarItemDefTest()
        {
            this.character.QuitarItemDef();
            Assert.AreEqual(this.character.ItemDef, null);
        }
    }
}