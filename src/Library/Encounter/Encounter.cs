using System.Collections.Generic;

namespace Ucu.Poo.RolePlayGame
{
    public class Encounter
    {
        // Personajes dentro del campo de batalla
        private List <Hero> heroes = new List<Hero>();
        public List <Hero> Heroes
        {
            get {return this.heroes;} set {this.heroes = value;}
        }
        private List <Enemy> enemies = new List<Enemy>();
        public List <Enemy> Enemies
        {
            get {return this.enemies;} set {this.enemies = value;}
        }

        // Comienza la batalla
        public void DoEncounter()
        {
            //Chequea que sigan habiendo por lo menos uno de cada bando
            while (this.enemies.Count>0 && this.heroes.Count>0)
            {
                
                //Cuando solo hay un solo heroe, todos pegan a ese heroe
                if (this.heroes.Count==1)
                {
                    foreach (Enemy enemy in enemies)
                    {
                        heroes[0].ReceiveAttack(enemy);
                        if (heroes[0].Health<=0)
                            {
                                heroes[0].Remove(hero);
                            }
                    }
                }
                else //En otro caso los enemigos van uno por uno
                {
                    for (int i=0;i<enemies.Count;i++)
                    {
                        heroes[i%heroes.Count].ReceiveAttack(enemies[i]);

                        //Comprobar si murio, en tal caso eliminar al heroe de la batalla.
                        if (heroes[i%heroes.Count].Health<=0)
                            {
                                heroes[i%heroes.Count].Remove(hero);
                            }
                    }
                }



                //Recorre cada heroe, y cada uno ataca a cada enemigo
                foreach (Hero hero in heroes)
                {
                    if (hero.Health > 0)
                    {
                        foreach (Enemy enemy in enemies)
                        {
                            enemy.ReceiveAttack(hero);
                            
                            //Comprobar si murio, en tal caso darle los puntos de victoria al heroe y eliminar el enemigo de la batalla.
                            if (enemy.Health<=0)
                            {
                                hero.AccumulatedVictoryPoints+=enemy.VictoryPoints;
                                enemies.Remove(enemy);
                            }         
                        }
                    } 
                }
            }

            //Cada heroe que haya ganado mas de 5 puntos de victoria al terminar el encuentro se cura.
            foreach (Hero hero in heroes)
            {
                if (hero.AccumulatedVictoryPoints - hero.BaseVictoryPoints >=5)
                {
                    hero.Cure();
                }
            }
        }

        //Constructor
        public Encounter(List<Hero> heroes, List<Enemy> enemies)
        {
            this.heroes = heroes;
            this.enemies = enemies;
        }
    }
}
