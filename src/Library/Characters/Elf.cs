namespace Ucu.Poo.RolePlayGame
{
public class Elf: Character
{
    //Constructor
    public Elf(string ElfName, int basehp, int AV, int DV)
    {
        this.name = ElfName;
        this.health = basehp;
        this.baseHealth = basehp;
        this.attackValue = AV;
        this.defenseValue = DV;
    }
}
}
