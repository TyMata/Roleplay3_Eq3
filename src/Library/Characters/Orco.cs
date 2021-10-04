using System;
using System.Collections.Generic;

namespace Roleplay_Prog.Library
{
    public class Orco : HeroeNoMagico , IHeroes
    {

        public Orco(string nombre) : base(nombre)
        {
            this.Vida = 130;
        }
        
        public override void Curarse()
        {
            this.vida = 130;
        }
    }
}