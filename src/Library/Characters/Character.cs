using System.Collections.Generic;
using System;

namespace Ucu.Poo.RolePlayGame
{
    //Abstract Character
    public abstract class Character
    {

    // Atributos del personaje

    //Nombre
    protected string name;
    public string Name
    {
        get {return this.name;} set {this.name=value;}
    }

    // Equipment
    private List<IItem> equipamiento = new List<IItem>();
    public List<IItem> Equipamiento
    {
        get {return this.equipamiento;}
    }

    //Stats
    protected bool canUseMagic; //Este booleano es el que habilita a usar equipamiento magico
    public bool CanUseMagic
    {
        get {return this.canUseMagic;}   set {this.canUseMagic = value;}
    }
    protected int baseHealth;
    public int BaseHealth
    {
        get {return this.baseHealth;} set {this.baseHealth=value;}
    }
    protected int health;
    public int Health
    {
        get {return this.health;} set {this.health=value;}
    }
    protected int attackValue;
    public int AttackValue
    {
        get {return this.attackValue;} set {this.attackValue=value;}
    }
    protected int defenseValue;
    public int DefenseValue
    {
        get {return this.defenseValue;} set {this.defenseValue=value;}
    }

    //Métodos
    public int GetTotalAttack()
    {
        int ataqueTotal = 0;
        ataqueTotal += this.AttackValue;
        foreach (IItem item in Equipamiento)
        {
            ataqueTotal += item.AttackValue;
        }
        return ataqueTotal; // El ataque total es la suma del ataque del personaje y de los ataques de sus ítems
    }
    public int GetTotalDefense()
    {
        int defensaTotal = 0;
        defensaTotal += this.DefenseValue;
        foreach (IItem item in Equipamiento)
        {
            defensaTotal += item.DefenseValue;
        }
        return defensaTotal; // La defensa total es la suma de la defensa del personaje y de las defensas de sus ítems
    }
    public void ReceiveAttack(Character attacker) // ReceiveAttack necesita que se le ingrese el ataque entrante al personaje, luego se calcula el ataque total recibido
    {
        Console.WriteLine($"{attacker.Name} esta atacando a {this.Name}.");
        int dmgReceived= attacker.GetTotalAttack() - this.GetTotalDefense(); // El ataque recibido por el personaje es la resta entre el ataque entrante y la estadística de defensa total
        if (dmgReceived>0) // Si el ataque recibido es positivo (es decir que la defensa no logró bloquear el ataque entrante)
        {
            this.Health-=dmgReceived; // Se resta el daño recibido a la vida actual
        }
    }
    public void Cure()
    {
        this.Health=this.BaseHealth; // Curarse es retaurar la vida actual a la vida base (vida completa)
    }

    }
}