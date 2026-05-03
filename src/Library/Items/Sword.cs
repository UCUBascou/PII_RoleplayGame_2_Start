namespace Ucu.Poo.RolePlayGame
{
public class Sword: IItem
{
    //Atributos
    private bool magicalItem; //false por defecto
    public bool MagicalItem
    {
        get {return this.magicalItem;}
    }
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