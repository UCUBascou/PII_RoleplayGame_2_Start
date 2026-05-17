namespace Ucu.Poo.RolePlayGame
{
public class MagicStaff: IItem, IAttackItem, IDefenseItem, IMagicItem
{
    //Valor del ataque
    private int attackValue;
    public int AttackValue
    {
        get { return attackValue; } set { this.attackValue = value; }
    }
    //Valor de la defensa
    private int defenseValue;
    public int DefenseValue
    {
        get { return defenseValue; } set { this.defenseValue = value; }
    }
    //Constructor
    public MagicStaff(int AV, int DV)
    {
        this.AttackValue = AV;
        this.DefenseValue = DV;
    }
}
}