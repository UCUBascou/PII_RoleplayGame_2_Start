using System.Collections.Generic;
using System;

namespace Ucu.Poo.RolePlayGame
{
    //Interfaz IAttackItem
    public interface ICharacter // Interfaz para objetos ofensivos con solo un valor de ataque
    {
        string Name {get;}
        List<IItem> Equipamiento {get;}
        bool CanUseMagic {get;}
        int BaseHealth {get;}
        int Health {get;}
        int AttackValue {get;}
        int DefenseValue {get;}


        void RemoveItem(Type item);
        void AddItem(IItem itemToAdd);
        int GetTotalAttack();
        int GetTotalDefense();
        void ReceiveAttack(ICharacter attacker);
        void Cure();
    }
}