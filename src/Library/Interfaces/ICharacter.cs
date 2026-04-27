namespace Ucu.Poo.RolePlayGame
{
    public interface ICharacter
    {
        string Name { get; set; }
        int Health { get; }
        int BaseHealth { get; }

        int GetTotalAttack();
        int GetTotalDefense();

        void ReceiveAttack(int damage);
        void Cure();
    }
}