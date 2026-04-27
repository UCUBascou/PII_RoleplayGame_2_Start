namespace Ucu.Poo.RolePlayGame
{
public class Shield
{
    //Valor de ataque del shield
    private int attackValue;
    public int AttackValue
    {
        get {return attackValue;} set {this.attackValue=value;}
    }
    //Valor de defensa del shield
    private int defenseValue;
    public int DefenseValue
    {
        get {return defenseValue;} set {this.defenseValue=value;}
    }
    //Constructor
    public Shield (int attackValue, int defenseValue)
    {
        this.AttackValue=attackValue;
        this.DefenseValue=defenseValue;
    }
}
}