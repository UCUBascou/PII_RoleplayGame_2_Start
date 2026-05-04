namespace Ucu.Poo.RolePlayGame
{
public class Bow: IItem, IAttackItem
{
    private int attackValue;
    public int AttackValue
    {
        get{return this.attackValue;} set{this.attackValue = value;}
    }
    //Constructor
    public Bow(int AV)
    {
        this.attackValue = AV;
    }
}
}