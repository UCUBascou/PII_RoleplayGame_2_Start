namespace Ucu.Poo.RolePlayGame
{
    //Interfaz de Character
    public interface ICharacter 
    {
        string Name { get; set; }
        int Health { get; }
        int BaseHealth { get; }

        int GetTotalAttack();
        int GetTotalDefense();
        void Cure();
        void ReceiveAttack(ICharacter attacker);
        void AddItem(IItem item);
        void RemoveItem(IItem item);
    }
}