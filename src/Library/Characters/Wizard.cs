using System;

namespace Ucu.Poo.RolePlayGame
{
public class Wizard
{
    // Atributos de Wizard

    //Nombre
    private string name;
    public string Name
    {
        get {return this.name;} set {this.name=value;}
    }

    // Equipments
    private MagicStaff staff;
    public MagicStaff Staff
    {
        get {return this.staff;} set {this.staff=value;}
    }

    private SpellBook spellBook;
    public SpellBook SpellBook
    {
        get {return this.spellBook;} set {this.spellBook=value;}
    }

    //Stats
    private int baseHealth;
    public int BaseHealth
    {
        get {return this.baseHealth;} set {this.baseHealth=value;}
    }

    private int health;
    public int Health
    {
        get {return this.health;} set {this.health=value;}
    }

    private int attackValue;
    public int AttackValue
    {
        get {return this.attackValue;} set {this.attackValue=value;}
    }

    private int defenseValue;
    public int DefenseValue
    {
        get {return this.defenseValue;} set {this.defenseValue=value;}
    }

    //Métodos
    public void RemoveStaff()
    {
        this.Staff = null;
    }

    public void RemoveSpellBook()
    {
        this.SpellBook = null;
    }

    public int GetTotalAttack()
    {
        int ataqueTotal = 0;
        ataqueTotal += this.AttackValue;
        if (this.Staff != null){ataqueTotal += this.Staff.AttackValue;}
        if (this.SpellBook != null){ataqueTotal += this.SpellBook.AttackValue;}
        return ataqueTotal;
    }

    public int GetTotalDefense()
    {
        int defensaTotal = 0;
        defensaTotal += this.DefenseValue;
        if (this.Staff != null){defensaTotal += this.Staff.DefenseValue;}
        if (this.SpellBook != null){defensaTotal += this.SpellBook.DefenseValue;}
        return defensaTotal;
    }

    public void ReceiveAttack(int incomingDMG)
    {
        int dmgReceived=incomingDMG-this.GetTotalDefense();
        if (dmgReceived>0)
        {
            this.Health-=dmgReceived;
        }
    }

    public void Cure()
    {
        this.Health=this.BaseHealth;
    }

    //Constructor
    public Wizard(string name, int basehp, int ap, int dp)
    {
        this.Name=name;
        this.BaseHealth=basehp;
        this.Health=basehp;
        this.AttackValue=ap;
        this.DefenseValue=dp;
    }
}
}