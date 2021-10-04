using System;

namespace Roleplay_Prog.Library
{
    public class Enano : HeroeNoMagico
    {
        public Enano(string nombre) : base(nombre)
        {
            this.Vida = 120;
        }
        
        public override void Curarse()
        {
            this.vida = 120;
        }
    }
}


