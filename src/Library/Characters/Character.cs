using System.Collections.Generic;
using System;
using System.Linq;

namespace Ucu.Poo.RolePlayGame
{
    public abstract class Character: ICharacter
    {

        // Atributos del personaje

        //Nombre
        protected string name;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // Equipment
        private List<IItem> equipamiento = new List<IItem>();
        public List<IItem> Equipamiento
        {
            get { return this.equipamiento; }
        }

        //Stats
        protected int baseHealth;
        public int BaseHealth
        {
            get { return this.baseHealth; }
            set { this.baseHealth = value; }
        }
        protected int health;
        public int Health
        {
            get { return this.health; }
            set { this.health = value; }
        }
        protected int attackValue;
        public int AttackValue
        {
            get { return this.attackValue; }
            set { this.attackValue = value; }
        }
        protected int defenseValue;
        public int DefenseValue
        {
            get { return this.defenseValue; }
            set { this.defenseValue = value; }
        }

        //Métodos
        public void RemoveItem(Type tipo) // Recorre la lista de items del personaje y elimina el ingresado en el método RemoveItem
        {
            for (int i=0; i < Equipamiento.Count; i++) 
            {
                if (Equipamiento[i].GetType() == tipo)
                {
                    Equipamiento.RemoveAt(i);
                    return;
                }
            }
        }

        public void AddItem(IItem itemToAdd) // Agrega un item a la lista de items del personaje
        {
            Type tipo = itemToAdd.GetType();

            //Si el item ya existe es reemplazado por el nuevo ya que no queremos que tenga mas de un mismo item
            for (int i=0; i < Equipamiento.Count; i++)
            {
                if (Equipamiento[i].GetType() == tipo)
                {
                    Equipamiento.RemoveAt(i);
                }
            }
            Equipamiento.Add(itemToAdd);
        }

        public int GetTotalAttack() // Calcula el ataque total del personaje al sumar el ataque intrínseco del personaje más el ataque de todos sus objetos
        {
            int ataqueTotal = 0;
            ataqueTotal += this.AttackValue;

            //Recorre los items de ataque
            foreach (IAttackItem item in Equipamiento.OfType<IAttackItem>())
            {
                if (!(item is IMagicItem))
                {
                    ataqueTotal += item.AttackValue;
                }
                else if(this is IMagicCharacter) //Si es magico y puede usar magia se suma
                {
                    ataqueTotal += item.AttackValue;                   
                }
            }
            return ataqueTotal; // El ataque total es la suma del ataque del personaje y de los ataques de sus ítems
        }

        public int GetTotalDefense() // Calcula la defensa total del personaje al sumar la defensa intrínseca del personaje más la defensa de todos sus objetos
        {
            int defensaTotal = 0;
            defensaTotal += this.DefenseValue;
            
            //Recorre los items de defensa
            foreach (IDefenseItem item in Equipamiento.OfType<IDefenseItem>())
            {
                if (!(item is IMagicItem))
                {
                    defensaTotal += item.DefenseValue;
                }
                else if(this is IMagicCharacter) //Si es magico y puede usar magia se suma
                {
                    defensaTotal += item.DefenseValue;                   
                }
            }
            return defensaTotal; // La defensa total es la suma de la defensa del personaje y de las defensas de sus ítems
        }
        public void ReceiveAttack(ICharacter attacker) // ReceiveAttack necesita que se le ingrese el atacante, luego se calcula el ataque total de ese atacante para determinar el daño recibido
        {
            Console.WriteLine($"{attacker.Name} esta atacando a {this.Name}.");
            int dmgReceived = attacker.GetTotalAttack() - this.GetTotalDefense(); // El ataque recibido por el personaje es la resta entre el ataque total entrante y defensa total de quien recibe el ataque
            if (dmgReceived > 0) // Si el ataque recibido es positivo (es decir que la defensa no logró bloquear el ataque entrante)
            {
                this.Health -= dmgReceived; // Se resta el daño recibido a la vida actual
            }
        }
        public void Cure()
        {
            this.Health = this.BaseHealth; // Curarse es retaurar la vida actual a la vida base (vida completa)
        }

    }
}