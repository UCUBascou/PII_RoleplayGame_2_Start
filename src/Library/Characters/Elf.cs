namespace Ucu.Poo.RolePlayGame
{
public class Elf: Character
{
    //Constructor
    public Elf(string Ename, int basehp, int AV, int DV)
    {
        this.name = Ename;
        this.health = basehp;
        this.baseHealth = basehp;
        this.attackValue = AV;
        this.defenseValue = DV;
    }
}
}
