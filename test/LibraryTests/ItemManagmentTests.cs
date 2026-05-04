using System.Linq;
using NUnit.Framework;


namespace Ucu.Poo.RolePlayGame.Tests
{
    public class ItemManagmentTests
    {
        /// <summary>
        /// Chequea que se eliminene correctamente los items, deberian ser null cuando los personajes no tienen uno de sus items
        /// </summary>
        [Test]
        public void TestRemoveItem_IteamWasOrNotNull_KeepsNull()
        {
            //Elf Items
            Elf elfo = new Elf("Elden", 100, 20, 10);
            Bow arco = new Bow(5);
            Bow arco2 = new Bow(10);
            elfo.AddItem(arco);

            Assert.That(arco, Is.EqualTo(elfo.Equipamiento.OfType<Bow>().FirstOrDefault()));
            elfo.RemoveItem(typeof(Bow));
            Assert.That(elfo.Equipamiento.OfType<Bow>().FirstOrDefault(), Is.EqualTo(null));
            Assert.That(elfo.Equipamiento.OfType<Sword>().FirstOrDefault(), Is.EqualTo(null));

            //Dwarf Items
            Dwarf enano = new Dwarf("Enzo", 100, 67, 67);
            Helmet cascon = new Helmet(67);
            enano.AddItem(cascon);

            Assert.That(cascon, Is.EqualTo(enano.Equipamiento.OfType<Helmet>().FirstOrDefault()));
            enano.RemoveItem(typeof(Helmet));
            Assert.That(null, Is.EqualTo(enano.Equipamiento.OfType<Helmet>().FirstOrDefault()));
            Assert.That(null, Is.EqualTo(enano.Equipamiento.OfType<Bow>().FirstOrDefault()));

            //Wizard Items
            Wizard gandalf = new Wizard("Gandalf", 100, 10, 0);
            MagicStaff bastonMagico = new MagicStaff(25);
            SpellBook libroDeHechizos = new SpellBook();
            gandalf.AddItem(bastonMagico);
            gandalf.AddItem(libroDeHechizos);

            Assert.That(bastonMagico, Is.EqualTo(gandalf.Equipamiento.OfType<MagicStaff>().FirstOrDefault()));
            gandalf.RemoveItem(typeof(MagicStaff));
            Assert.That(gandalf.Equipamiento.OfType<MagicStaff>().FirstOrDefault(), Is.EqualTo(null));
            Assert.That(gandalf.Equipamiento.OfType<SpellBook>().FirstOrDefault(), Is.EqualTo(libroDeHechizos));
        }

        ///<summary>
        /// Chequea que AddItem remplaze el objeto si habia otro del mismo tipo
        ///<\summary>
        [Test]
        public void TestAddItem_AlreadyHadTypeItem_ReplaceForNewItem()
        {
            //Elf Items
            Elf elfo = new Elf("Elden", 100, 20, 10);
            Bow arco = new Bow(5);
            Bow arco2 = new Bow(10);

            //Se anade uno y despues el otro y el arco2 deberia remplazar al primero
            elfo.AddItem(arco);
            elfo.AddItem(arco2);
            Assert.That(elfo.Equipamiento.OfType<Bow>().FirstOrDefault(), Is.EqualTo(arco2));
            Assert.That(elfo.Equipamiento.Count, Is.EqualTo(1));
        }
    }
}
