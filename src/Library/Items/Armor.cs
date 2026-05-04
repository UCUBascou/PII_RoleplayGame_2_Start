namespace Ucu.Poo.RolePlayGame
{
public class Armor: IItem, IDefenseItem
{
    private int defenseValue;
    public int DefenseValue
    {
        get{return this.defenseValue;} set{this.defenseValue=value;}
    }
    //Constructor
    public Armor(int DV)
    {
        this.defenseValue = DV;
    }
}
}