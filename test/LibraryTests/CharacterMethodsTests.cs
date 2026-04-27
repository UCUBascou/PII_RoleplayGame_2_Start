using NUnit.Framework;

namespace Ucu.Poo.RolePlayGame.Tests
{
    public class CharacterMethodsTests
    {
        /// <summary>
        /// Verifica que el ataque total incluye el arco equipado.
        /// </summary>
        [Test]
        public void GetTotalAttack_WithBow_ReturnsCorrectResult()
        {
            Elf elf = new Elf("Juan", 100, 10, 5);
            elf.Bow = new Bow(15, 0);
            int total = elf.GetTotalAttack(); 
            Assert.That(total, Is.EqualTo(25));
        }
        /// <summary>
        /// Verifica que recibir daño reduce la vida.
        /// </summary>
        [Test]
        public void ReceiveAttack_DamageGreaterThanDefense_ReducesHealth()
        {
            Elf elf = new Elf("Amigazo", 100, 10, 5);
            elf.ReceiveAttack(20);
            Assert.That(elf.Health, Is.EqualTo(85));
        }
        /// <summary>
        /// Verifica que el ataque total incluye staff y spellbook.
        /// </summary>
        [Test]
        public void GetTotalAttack_WithStaffAndSpellBook_ReturnsCorrectSum()
        {
            Wizard wizard = new Wizard("Daniel", 100, 10, 5);

            wizard.Staff = new MagicStaff(15, 0);

            SpellBook book = new SpellBook(0);
            book.Spells.Add(new Spell(20));
            wizard.SpellBook = book;

            int total = wizard.GetTotalAttack();

            Assert.That(total, Is.EqualTo(45));
        }
        /// <summary>
        /// Verifica que la defensa total incluye todos los ítems.
        /// </summary>
        [Test]
        public void GetTotalDefense_WithAllItems_ReturnsCorrectSum()
        {
            Dwarf dwarf = new Dwarf("Amigazon", 100, 10, 5);

            dwarf.Axe = new Axe(0, 10);
            dwarf.Shield = new Shield(0, 20);
            dwarf.Helmet = new Helmet(0, 5);
            int total = dwarf.GetTotalDefense();
            Assert.That(total, Is.EqualTo(40));
        }
        /// <summary>
        /// Verifica que curarse restaura la vida base.
        /// </summary>
        [Test]
        public void Cure_AfterDamage_RestoresHealthToBase()
        {
            Dwarf dwarf = new Dwarf("dwarf", 100, 10, 5);
            dwarf.ReceiveAttack(20);
            dwarf.Cure();
            Assert.That(dwarf.Health, Is.EqualTo(100));
        }

        /// <summary>
        /// Atacar a un personaje con la informacion de otro personaje
        /// </summary>
        [Test]
        public void RecieveAttack_WithTwoCharactersInGame_ReducesHealth()
        {
            Dwarf dwarf = new Dwarf("Enzo", 100, 10, 0);
            Wizard wizard = new Wizard("Cecilia", 100, 10, 5);
            
            //Anade Items
            Helmet casco = new Helmet(0, 15);
            dwarf.Helmet = casco;
            wizard.Staff = new MagicStaff(15, 0);
            SpellBook book = new SpellBook(0);
            book.Spells.Add(new Spell(20));
            wizard.SpellBook = book;

            dwarf.ReceiveAttack(wizard.GetTotalAttack());
            Assert.That(dwarf.Health, Is.EqualTo(70));
        }

    }
}