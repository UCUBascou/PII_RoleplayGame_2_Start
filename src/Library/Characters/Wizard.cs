namespace Ucu.Poo.RolePlayGame
{
public class Wizard: Hero
{
    //Constructor
    public Wizard(string Wname, int basehp, int AV, int DV, int VP)
    {
        this.name=Wname;
        this.baseHealth=basehp;
        this.health=basehp;
        this.attackValue=AV;
        this.defenseValue=DV;
        this.victoryPoints=VP;
    }
}
}