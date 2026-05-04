namespace Ucu.Poo.RolePlayGame
{
public class Helmet: IItem, IDefenseItem
{
    //Valor de defensa del helmet
    private int defenseValue;
    public int DefenseValue
    {
        get {return defenseValue;} set {this.defenseValue=value;}
    }
    //Constructor
    public Helmet (int DV)
    {
        this.DefenseValue = DV;
    }
}
}