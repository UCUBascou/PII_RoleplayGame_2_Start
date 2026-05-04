namespace Ucu.Poo.RolePlayGame
{
public class Wizard: Character
{
    //Constructor
    public Wizard(string name, int basehp, int ap, int dp)
    {
        this.Name=name;
        this.BaseHealth=basehp;
        this.Health=basehp;
        this.AttackValue=ap;
        this.DefenseValue=dp;
    }
}
}