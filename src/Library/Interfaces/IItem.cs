namespace Ucu.Poo.RolePlayGame
{
    //Interfaz Item
    public interface IItem
    {
        bool MagicalItem { get; }
        int AttackValue { get; }
        int DefenseValue { get; }
    }
}