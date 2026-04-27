namespace Ucu.Poo.RolePlayGame
{
public class MagicStaff
{
    //Valor del ataque
    private int attackValue;
    public int AttackValue
    {
        get { return attackValue; } set { this.attackValue = value; }
    }

    //Valor de la def
    private int defenseValue;
    public int DefenseValue
    {
        get { return defenseValue; } set { this.defenseValue = value; }
    }

    //Constructor
    public MagicStaff(int attackValue, int defenseValue)
    {
        this.AttackValue = attackValue;
        this.DefenseValue = defenseValue;
    }
}
}