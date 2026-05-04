using System.Collections.Generic;

namespace Ucu.Poo.RolePlayGame
{
public class SpellBook: IItem, IMagicItem, IAttackItem, IDefenseItem
{
    //Lista de hechizos
    private List<Spell> spells = new List<Spell>();
    public List<Spell> Spells
    {
        get { return spells; } set { this.spells = value; }
    }

    // Valor de ataque
    public int AttackValue
    {
        get
        {
            int total = 0;
            foreach (Spell spell in spells)
            {
                total += spell.AttackValue;  // El ataque total del Libro es la suma del poder de sus hechizos
            }
            return total;
        }
    }
    // Valor de defensa
    public int DefenseValue
    {
        get
        {
            int total = 0;
            foreach (Spell spell in spells)
            {
                total += spell.DefenseValue;  // El ataque total del Libro es la suma del poder de sus hechizos
            }
            return total;
        }
    }

    //Constructor
    public SpellBook(List<Spell> spells)
    {
        this.Spells = spells;
    }
}
}