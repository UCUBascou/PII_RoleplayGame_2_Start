namespace Ucu.Poo.RolePlayGame
{
    public class Undead: Enemy
    {
        //Constructor
        public Undead(string Uname, int basehp, int AV, int DV, int VP)
        {
            this.name = Uname;
            this.health = basehp;
            this.baseHealth = basehp;
            this.attackValue = AV;
            this.defenseValue = DV;
            this.victoryPoints = VP;
    }
    }
}