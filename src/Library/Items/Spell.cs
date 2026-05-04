namespace Ucu.Poo.RolePlayGame
{
public class Spell // Los hechizos tienen un valor de ataque y defensa, aunque alguno pueda ser 0
{
    private int attackValue;
    public int AttackValue
    {
        get { return attackValue; } set { this.attackValue = value; }
    }
    private int defenseValue;
    public int DefenseValue
    {
        get { return defenseValue; } set { this.defenseValue = value; }
    }
    public Spell(int AV, int DV)
    {
        this.AttackValue=AV;
        this.DefenseValue=DV;
    }
}
}