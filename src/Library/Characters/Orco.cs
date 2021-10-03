using System;
using System.Collections.Generic;

namespace Roleplay_Prog.Library
{
    public class Orco : CharacterNoMagico
    {

        public Orco(string nombre) : base(nombre)
        {
            this.Vida = 130;
        }
        
        public void Curarse()
        {
            this.vida = 130;
        }
    }
}