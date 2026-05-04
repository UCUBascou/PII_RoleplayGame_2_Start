namespace Ucu.Poo.RolePlayGame
{
public class Axe: IItem, IAttackItem
{
    //Valor de ataque del axe
    private int attackValue;
    public int AttackValue
    {
        get {return attackValue;} set {this.attackValue=value;}
    }
    //Constructor
    public Axe (int AV)
    {
        this.AttackValue = AV;
    }
}
}