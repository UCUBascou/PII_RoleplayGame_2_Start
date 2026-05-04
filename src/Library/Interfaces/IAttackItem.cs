namespace Ucu.Poo.RolePlayGame
{
    //Interfaz IAttackItem
    public interface IAttackItem : IItem // Interfaz para objetos ofensivos con solo un valor de ataque
    {
        int AttackValue { get; }
    }
}