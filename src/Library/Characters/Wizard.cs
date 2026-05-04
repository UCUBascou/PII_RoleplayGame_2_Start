namespace Ucu.Poo.RolePlayGame
{
public class Wizard: Character
{
    //Constructor
    public Wizard(string Wname, int basehp, int ap, int dp)
    {
        this.Name=Wname;
        this.BaseHealth=basehp;
        this.Health=basehp;
        this.AttackValue=ap;
        this.DefenseValue=dp;
    }
}
}