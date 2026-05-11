using System.Collections.Generic;

namespace Ucu.Poo.RolePlayGame
{
    public class Encounter
    {
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
        public void DoEncounter()
        {
            if (this.enemies.Count>0 && this.heroes.Count>0)
            {
                if (this.heroes.Count==1)
                {
                    foreach (Enemy enemy in enemies)
                    {
                        heroes[0].ReceiveAttack(enemy);
                    }
                }
                else
                {
                    for (int i=0;i<=enemies.Count;i++)
                    {
                        heroes[i%heroes.Count].ReceiveAttack(enemies[i]);
                    }
                }
                
            }
        }
    }
}