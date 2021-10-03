using NUnit.Framework;
using Roleplay_Prog;
using Roleplay_Prog.Library;

namespace Test.Library
{


    public class CharacterNoMagicoNoMagicoTest
    {
        private Elfo characternomagico;
        private CharacterNoMagico dummy;
        [SetUp]
        public void Setup()
        {
            this.characternomagico = new Elfo("CharacterNoMagico1");
            Arco arco = new Arco(50);
            this.characternomagico.CambiarItemOf(arco);
            Armadura armadura = new Armadura(20);
            this.characternomagico.CambiarItemDef(armadura);
            this.dummy = new Elfo("Jose");
        }
        /*
            Es necesario probar este metodo para confirmar que
            el ataque que devuelve es el mismo ataque que el de su ItemOf
        */
        [Test]
        public void GetAtaqueTest()
        {
            Assert.AreEqual(this.characternomagico.GetAtaque(), this.characternomagico.ItemOf.Ataque);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al realizar un cambio de ItemOf se realiza el cambio correctamente
        */
        [Test]
        public void CambiarItemOfTest()
        {
            Arco arcoNue = new Arco(60);
            this.characternomagico.CambiarItemOf(arcoNue);
            Assert.AreEqual(this.characternomagico.GetAtaque(), arcoNue.Ataque);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al quitar el ItemOf este queda en null
        */
        [Test]
        public void QuitarItemOfTest()
        {
            this.characternomagico.QuitarItemOf();
            Assert.AreEqual(this.characternomagico.ItemOf, null);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al atacar a otro personaje, con un ataque menor 
            a su armadura, la vida de este no se ve afectada
        */
        [Test]
        public void DanioAtacarMenorOIgualQueArmaduraTest()
        {
            ItemDefensa tunicaCuero = new TunicaCuero(60);
            this.dummy.CambiarItemDef(tunicaCuero);
            this.characternomagico.Atacar(this.dummy);
            Assert.AreEqual(this.dummy.Vida, 100);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al atacar a otro personaje, con un ataque mayor 
            a su armadura, la vida de este se ve afectada
        */
        [Test]
        public void DanioAtacarMayorQueArmaduraTest()
        {
            ItemDefensa tunicaCuero = new TunicaCuero(20);
            this.dummy.CambiarItemDef(tunicaCuero);
            this.characternomagico.Atacar(this.dummy);
            Assert.AreEqual(this.dummy.Vida, 70);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al atacar a otro personaje, con un ataque mayor 
            a la suma de su armadura y vida, la vida de este 
            queda en 0
        */
        [Test]
        public void DanioAtacarMayorQueArmaduraYVidaTest()
        {
            ItemDefensa tunicaCuero = new TunicaCuero(0);
            this.dummy.CambiarItemDef(tunicaCuero);
            ItemAtaque mazo2 = new Mazo(999);
            this.characternomagico.CambiarItemOf(mazo2);
            this.characternomagico.Atacar(this.dummy);
            Assert.AreEqual(this.dummy.Vida, 0);
        }
    }


}