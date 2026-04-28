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

        void ReceiveAttack(ICharacter attacker);
        void Cure();
    }
}