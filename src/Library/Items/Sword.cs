namespace Ucu.Poo.RolePlayGame
{
public class Sword: IItem, IAttackItem
{
    //Stats
    private int attackValue;
    public int AttackValue
    {
        get{return this.attackValue;} set{this.attackValue = value;}
    }
    //Constructor
    public Sword(int AV)
    {
        this.attackValue = AV;
    }
}
}