namespace Ucu.Poo.RolePlayGame
{
public class Axe
{
    //Valor de ataque del axe
    private int attackValue;
    public int AttackValue
    {
        get {return attackValue;} set {this.attackValue=value;}
    }
    //Valor de defensa del axe
    private int defenseValue;
    public int DefenseValue
    {
        get {return defenseValue;} set {this.defenseValue=value;}
    }
    //Constructor
    public Axe (int attackValue, int defenseValue)
    {
        this.AttackValue=attackValue;
        this.DefenseValue=defenseValue;
    }
}
}