namespace Ucu.Poo.RolePlayGame
{
public class Sword
{
    //Atributos

    //Stats
    private int attackValue;
    public int AttackValue
    {
        get{return this.attackValue;} set{this.attackValue = value;}
    }
    private int defenseValue;
    public int DefenseValue
    {
        get{return this.defenseValue;} set{this.defenseValue=value;}
    }

    //Constructor
    public Sword(int AV, int DV)
    {
        this.attackValue = AV;
        this.defenseValue = DV;
    }
}
}