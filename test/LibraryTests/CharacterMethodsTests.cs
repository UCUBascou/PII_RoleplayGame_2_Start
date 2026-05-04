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
            Bow arco = new Bow(15);
            elf.AddItem(arco);
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
            Dwarf enano = new Dwarf("Atacante", 100, 20, 20);
            elf.ReceiveAttack(enano);
            Assert.That(elf.Health, Is.EqualTo(85));
        }
        /// <summary>
        /// Verifica que el ataque total incluye staff y spellbook.
        /// </summary>
        [Test]
        public void GetTotalAttack_WithStaffAndSpellBook_ReturnsCorrectSum()
        {
            Wizard wizard = new Wizard("Amigacin", 100, 10, 5);

            MagicStaff staff = new MagicStaff(15);

            SpellBook book = new SpellBook();
            book.Spells.Add(new Spell(20,0));

            wizard.AddItem(staff);
            wizard.AddItem(book);

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

            Axe hacha = new Axe(10);
            Shield escudo = new Shield(20);
            Helmet casco = new Helmet(5);
            int total = dwarf.GetTotalDefense();
            Assert.That(total, Is.EqualTo(40));
        }
        /// <summary>
        /// Verifica que curarse restaura la vida base.
        /// </summary>
        [Test]
        public void Cure_AfterDamage_RestoresHealthToBase()
        {
            //Crea Personajes
            Elf Noche_de_pelis = new Elf("Noche de pelis", 100, 10, 10);
            Dwarf dwarf = new Dwarf("Super friend", 100, 10, 5);

            //ACciones
            dwarf.ReceiveAttack(Noche_de_pelis);
            dwarf.Cure();
            Assert.That(dwarf.Health, Is.EqualTo(100));
        }

        /// <summary>
        /// Atacar a un personaje con la informacion de otro personaje
        /// </summary>
        [Test]
        public void RecieveAttack_WithTwoCharactersInGame_ReducesHealth()
        {
            //Crea personajes
            Dwarf amigazo = new Dwarf("Amigazo", 100, 10, 0);
            Wizard amigaza = new Wizard("Amigaza", 100, 10, 5);
            
            //Anade Items
            Helmet casco = new Helmet(15);
            MagicStaff bastonazo = new MagicStaff(15);
            amigazo.AddItem(casco);
            amigaza.AddItem(bastonazo);
            SpellBook book = new SpellBook();
            book.Spells.Add(new Spell(20,0));
            amigaza.AddItem(book);

            //Acciones
            amigazo.ReceiveAttack(amigaza);
            Assert.That(amigazo.Health, Is.EqualTo(70));
        }

    }
}