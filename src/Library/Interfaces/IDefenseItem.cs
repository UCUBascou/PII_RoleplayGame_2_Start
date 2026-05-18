namespace Ucu.Poo.RolePlayGame
{
    public interface IDefenseItem : IItem // Interfaz para objetos defensivos con solo un valor de defensa
    {
        int DefenseValue { get; }
    }
}