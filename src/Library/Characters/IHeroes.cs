using System;
using Roleplay_Prog.Library;

namespace Roleplay_Prog.Library
{
    public interface IHeroes
    {
        ItemDefensa ItemDef{get;set;}
        int Vida{get;set;}
        int VP {get;set;}
        void Atacar(Character chara);
        void Curarse();
    }
}
