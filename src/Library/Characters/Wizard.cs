using System;

namespace Roleplay_Prog.Library
{
    public class Wizard : CharacterMagico
    {
        public Wizard(string name) : base (name)
        {
           this.vida = 80; 
        }

        public void Curarse()
        {
            this.Vida = 80;
        }
    }

}