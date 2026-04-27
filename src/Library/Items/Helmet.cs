namespace Ucu.Poo.RolePlayGame
{
public class Helmet
{
    //Valor de ataque del helmet
    private int attackValue;
    public int AttackValue
    {
        get {return attackValue;} set {this.attackValue=value;}
    }
    //Valor de defensa del helmet
    private int defenseValue;
    public int DefenseValue
    {
        get {return defenseValue;} set {this.defenseValue=value;}
    }
    //Constructor
    public Helmet (int attackValue, int defenseValue)
    {
        this.AttackValue=attackValue;
        this.DefenseValue=defenseValue;
    }
}
}