namespace Ucu.Poo.RolePlayGame
{
public class Spell
{
    private int power;
    public int Power
    {
        get { return power; } set { this.power = value; }
    }

    public Spell(int power)
    {
        this.Power = power;
    }
}
}