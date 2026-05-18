namespace Ucu.Poo.RolePlayGame
{
public class Wizard: Hero , IMagicCharacter
{
    //Constructor
    public Wizard(string Wname, int basehp, int AV, int DV)
    {
        this.name=Wname;
        this.baseHealth=basehp;
        this.health=basehp;
        this.attackValue=AV;
        this.defenseValue=DV;
    }
}
}