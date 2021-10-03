using System.Collections.Generic;

namespace Roleplay_Prog.Library
{
    public interface ICharacter
    {
        string Nombre {get;set;}
        int Vida{get;set;}
        IItemAtaque ItemOf{get;set;}
        IItemDefensa ItemDef{get;set;}

        void CambiarItemOf(IItemAtaque a);

        void QuitarItemOf();
        
        void CambiarItemDef(IItemDefensa a);
        
        void QuitarItemDef();

        int GetAtaque();

        void Atacar(ICharacter a);

        void Curarse();
    }
}