using System;

namespace Roleplay_Prog.Library
{
    public class Zombie : Enemy
    {
        public Zombie(string nombre) : base(nombre)
        {
            this.Vida = 40;
            this.VP = 4;
        }
        
        
    }
}