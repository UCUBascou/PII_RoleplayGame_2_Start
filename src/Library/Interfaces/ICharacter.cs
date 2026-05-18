using System.Collections.Generic;
using System;

namespace Ucu.Poo.RolePlayGame
{
    public interface ICharacter //Interfaz para los personajes
    {
        string Name {get;}
        List<IItem> Equipamiento {get;}
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