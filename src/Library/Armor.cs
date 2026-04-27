
namespace Ucu.Poo.RolePlayGame
{
public class Armor
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
    public Armor(int AV, int DV)
    {
        this.defenseValue = DV;
        this.defenseValue = DV;
    }
}
}