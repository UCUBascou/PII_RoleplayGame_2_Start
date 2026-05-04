namespace Ucu.Poo.RolePlayGame
{
public class Dwarf: Character
{
    //Constructor
    public Dwarf(string Dname, int basehp, int AV, int DV)
    {
        this.Name=Dname;
        this.BaseHealth=basehp; //base health point (no se modifica)
        this.Health=basehp; // Health modificable para el método ReceiveAttack
        this.AttackValue=AV; // Attack points
        this.DefenseValue=DV; // Defense points
    }
}
}