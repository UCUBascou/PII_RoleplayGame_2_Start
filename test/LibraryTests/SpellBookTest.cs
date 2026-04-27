using NUnit.Framework;
using Ucu.Poo.RolePlayGame;

public class SpellBookTests
{
    [Test]
    public void TestAttackValue_WithSpells_ReturnsSum()
    {
        //Crear libro y sus hechizos 
        SpellBook libro = new SpellBook(0);
        Spell hechizo1 = new Spell(10);
        Spell hechizo2 = new Spell(20);

        //Agregar hechizos
        libro.Spells.Add(hechizo1);
        libro.Spells.Add(hechizo2);

        //Verificar suma de ataque
        Assert.That(libro.AttackValue, Is.EqualTo(30));
    }
}
