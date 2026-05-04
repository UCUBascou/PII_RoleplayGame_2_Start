namespace Ucu.Poo.RolePlayGame
{
public class Dwarf: Character
{
    //Constructor
    public Dwarf(string Dname, int basehp, int AV, int DV)
    {
        this.Name=Dname; // Dwarf Name
        this.BaseHealth=basehp; // base health points (no se modifica)
        this.Health=basehp; // Health modificable para el método ReceiveAttack
        this.AttackValue=AV; // Attack value
        this.DefenseValue=DV; // Defense value
    }
}
}