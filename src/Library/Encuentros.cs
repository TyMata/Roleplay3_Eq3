using System;
using System.Collections.Generic;
using Roleplay_Prog.Library;

namespace Roleplay_Prog.Library
{
    public class Encuentros
    {
        private List<IHeroes> heroes;
        private List<Enemy> enemigos;
        public Encuentros(List<IHeroes> listaHeroes, List<Enemy> listaEnemigos)
        {
            this.heroes = listaHeroes;
            this.enemigos = listaEnemigos;
        }
        
        public bool DoEnconter()
        {
            int h = 0;
            while (this.enemigos.Count > 0 && this.heroes.Count > 0)
            {
                for (int i = 0; i < this.enemigos.Count - 1; i++) //Inicia ataque de los enemigos
                {
                    if (this.enemigos.Count <= this.heroes.Count)
                    {
                        this.enemigos[i].Atacar(this.heroes[i]);
                    }
                    else
                    {
                        if(i > this.heroes.Count - 1)
                        {
                            h = i - this.heroes.Count;
                            while(h > this.heroes.Count)
                            {
                                h = h - this.heroes.Count;
                            }
                            this.enemigos[i].Atacar(this.heroes[h]);
                        }
                        else
                        {
                            this.enemigos[i].Atacar(this.heroes[i]);
                        }
                        if(i % this.heroes.Count-1 == 0)
                        {
                            foreach (var heroe in this.heroes)
                            {
                                if (heroe.Vida == 0)
                                {
                                    heroes.Remove(heroe);
                                }
                            }
                        }
                    }
                }                                       //Termina ataque de los enemigos
                
                
                foreach (var heroe in this.heroes) //Comienza ataque de los heroes
                {
                    if (heroe.Vida != 0)
                    {
                        foreach (var enemigo in this.enemigos)
                        {
                            if (enemigo.Vida > 0)
                            {
                                heroe.Atacar(enemigo);
                                if(enemigo.Vida == 0)
                                {
                                    heroe.VP += enemigo.VP;
                                    enemigo.VP = 0;
                                }
                                if (heroe.VP >= 5)
                                {
                                    heroe.Curarse();
                                    heroe.VP = heroe.VP - 5;
                                }
                            }
                        }
                        foreach (var enemigo in this.enemigos)
                        {
                            if(enemigo.Vida == 0) enemigos.Remove(enemigo);
                        }
                    }
                }                                   //Termina ataque de los heroes
            }

            if (this.enemigos.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }

}
