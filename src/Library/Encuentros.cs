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
        public bool IsEnemyDead(Enemy enemigo)
        {
            return enemigo.Vida == 0;
        }
        public bool DoEnconter()
        {
            int h = 0;
            int loops = 0;
            List<int> eliminados = new List<int>();
            while (this.enemigos.Count > 0 && this.enemigos.Count > 0)
            {
                for (int i = 0; i < this.enemigos.Count - 1; i++) //Inicia ataque de los enemigos
                {
                    if (this.enemigos.Count <= this.heroes.Count)
                    {
                        this.enemigos[i].Atacar(this.heroes[i]);
                        if (this.heroes[i].Vida==0) eliminados.Add(i);
                    }
                    else
                    {
                        if(i > this.heroes.Count - 1)
                        {
                            h = i - this.heroes.Count - 1;
                            while(h > this.heroes.Count - 1)
                            {
                                h = h - this.heroes.Count;
                            }
                            if(h < 0) h = 0;
                            while (this.heroes[h].Vida == 0 && loops <2)
                            {
                                h++;
                                if(h > this.heroes.Count - 1)
                                {
                                    h = 0;
                                    loops++;
                                }
                            }
                            this.enemigos[i].Atacar(this.heroes[h]);
                        }
                        else
                        {
                            this.enemigos[i].Atacar(this.heroes[i]);
                        }
                    }
                }                                       //Termina ataque de los enemigos
                
                foreach (var heroe in this.heroes)                  //Comienza eliminacion de heroes
                {
                    if (heroe.Vida == 0) eliminados.Add(this.heroes.IndexOf(heroe));
                }                           
                foreach (var index in eliminados)
                {
                    this.heroes.RemoveAt(index);
                }
                eliminados.Clear();                       //Termina eliminacion de hereoes
                                                
                foreach (var heroe in this.heroes)                  //Comienza ataque de los heroes
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
                    }
                }                                   //Termina ataque de los heroes                     
                this.enemigos.RemoveAll(IsEnemyDead);
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
