namespace Ucu.Poo.RolePlayGame
{
    //Interfaz IAttackItem
    public interface IDefenseItem : IItem // Interfaz para objetos defensivos con solo un valor de defensa
    {
        int DefenseValue { get; }
    }
}