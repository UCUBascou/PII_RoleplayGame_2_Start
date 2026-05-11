namespace Ucu.Poo.RolePlayGame
{
public class Dwarf: Hero
{
    //Constructor
    public Dwarf(string Dname, int basehp, int AV, int DV, int VP)
    {
        this.name=Dname; // Dwarf Name
        this.baseHealth=basehp; // base health points (no se modifica)
        this.health=basehp; // Health modificable para el método ReceiveAttack
        this.attackValue=AV; // Attack value
        this.defenseValue=DV; // Defense value
        this.victoryPoints=VP;
    }
}
}