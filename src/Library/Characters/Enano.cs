using System;

namespace Roleplay_Prog.Library
{
    public class Enano : HeroeNoMagico
    {
        public Enano(string nombre) : base(nombre)
        {
            this.Vida = 120;
        }
        
        public void Curarse()
        {
            this.vida = 120;
        }
    }
}


