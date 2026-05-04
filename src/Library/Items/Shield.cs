namespace Ucu.Poo.RolePlayGame
{
public class Shield: IItem, IDefenseItem
{
    //Valor de defensa del shield
    private int defenseValue;
    public int DefenseValue
    {
        get {return defenseValue;} set {this.defenseValue=value;}
    }
    public Shield (int DV)
    {
        this.DefenseValue = DV;
    }
}
}