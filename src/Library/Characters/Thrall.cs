namespace Ucu.Poo.RolePlayGame
{
    public class Thrall: Enemy
    {
        //Constructor
        public Thrall(string Tname, int basehp, int AV, int DV, int VP)
        {
            this.name = Tname;
            this.health = basehp;
            this.baseHealth = basehp;
            this.attackValue = AV;
            this.defenseValue = DV;
            this.victoryPoints = VP;
    }
    }
}