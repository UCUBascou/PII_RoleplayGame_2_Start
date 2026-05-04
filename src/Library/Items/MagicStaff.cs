namespace Ucu.Poo.RolePlayGame
{
public class MagicStaff: IItem, IAttackItem, IMagicItem
{
    //Valor del ataque
    private int attackValue;
    public int AttackValue
    {
        get { return attackValue; } set { this.attackValue = value; }
    }
    //Constructor
    public MagicStaff(int AV)
    {
        this.AttackValue = AV;
    }
}
}