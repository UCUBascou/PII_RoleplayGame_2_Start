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
            while (this.enemies.Count>0 && this.heroes.Count>0)
            {

                //Poner esto cuando pegan
                foreach (Hero hero in heroes)
                {
                    if (hero.Health<=0)
                    {
                        heroes.Remove(hero);
                    }
                }


                //1 solo heroe, todos pegan a ese heroe
                if (this.heroes.Count==1)
                {
                    foreach (Enemy enemy in enemies)
                    {
                        heroes[0].ReceiveAttack(enemy);
                    }
                }
                else
                {
                    for (int i=0;i<enemies.Count;i++)
                    {
                        heroes[i%heroes.Count].ReceiveAttack(enemies[i]);
                    }
                }
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
            foreach (Hero hero in heroes)
            {
                if (hero.AccumulatedVictoryPoints>=5)
                {
                    hero.Cure();
                }
            }
        }
        public Encounter(List<Hero> heroes, List<Enemy> enemies)
        {
            this.heroes = heroes;
            this.enemies = enemies;
        }
    }
}
