using System;

namespace Roleplay_Prog.Library
{
    public class Elfo : CharacterNoMagico
    {
        public Elfo(string nombre) : base(nombre)
        {
            this.Vida = 100;
        }
        
        public void Curarse()
        {
            this.vida = 100;
        }
    }
        
}