using System.Collections.Generic;

namespace Ucu.Poo.RolePlayGame
{
public class SpellBook: IItem, IMagicItem, IAttackItem, IDefenseItem // El libro de hechizos es un item mágico (solo puede ser portado por un mago) y es un item de ataque y defensa (sus hechizos pueden ser ofensivos o defensivos)
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
                total += spell.AttackValue;  // El ataque total del Libro es la suma del ataque de sus hechizos
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
                total += spell.DefenseValue;  // El ataque total del Libro es la suma de la defensa de sus hechizos
            }
            return total;
        }
    }

    //Constructor
    public SpellBook(List<Spell> spells = null) // Para crear un libro de hechizos, se necesita una lista de hechizos la cual comienza vacía y a la cual se le van agregando hechizos
    {
        this.Spells = spells;
    }
}
}