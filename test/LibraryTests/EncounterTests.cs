using NUnit.Framework;
using System.Collections.Generic;



namespace Ucu.Poo.RolePlayGame.Tests
{
    public class EncounterTests
    {
        /// <summary>
        /// Chequea que se eliminene correctamente los items, deberian ser null cuando los personajes no tienen uno de sus items
        /// </summary>
        [Test]
        public void TestDoEncounter_HeroesWin_HeroesAliveAndEnemiesDead()
        {
            //Craer heroes y el equipo de heroes
            Elf elfo = new Elf("Elden", 100, 20, 10);
            Bow arco = new Bow(5);
            elfo.AddItem(arco);

            Dwarf enano = new Dwarf("Enzo", 100, 10, 5);
            Helmet cascon = new Helmet(67);
            Axe superAxe = new Axe(67);
            enano.AddItem(cascon);
            enano.AddItem(superAxe);

            Dwarf superEnano = new Dwarf("Minneto", 100, 40, 40);
            Axe axell = new Axe(40);
            enano.AddItem(axell);

            Dwarf weakEnano = new Dwarf("Renzo", 20, 10, 10);



            Wizard gandalf = new Wizard("Gandalf", 100, 10, 0);
            MagicStaff bastonMagico = new MagicStaff(25, 0);
            SpellBook libroDeHechizos = new SpellBook();
            gandalf.AddItem(bastonMagico);
            gandalf.AddItem(libroDeHechizos);

            List<Hero> HeroTeam = new List<Hero> {gandalf, enano, elfo};
            List<Hero> DwarfTeam = new List<Hero> {enano, superEnano, weakEnano};

            //Crear Enemigos y el grupo de enemigos
            Thrall thrall1 = new Thrall("sech1", 150, 5, 0, 5);
            Thrall thrall2 = new Thrall("sech2", 150, 5, 0, 5);
            Thrall thrall3 = new Thrall("sech3", 150, 5, 0, 5);
            Undead undead = new Undead("DeadGus", 200, 10, 15, 10);
            Undead tankUndead = new Undead("DeadWalter", 300, 1, 20, 25);

            List<Enemy> GrupoDeEnemigos = new List<Enemy>{thrall1, thrall2, thrall3, undead, tankUndead};


            //Create and Start Encounter
            Encounter BattleOfWesterLands = new Encounter(DwarfTeam, GrupoDeEnemigos);
            BattleOfWesterLands.DoEncounter();

            //Revivo/curo a los enemigos para volverlos a usar en el test
            thrall1.Cure();
            thrall2.Cure();
            thrall3.Cure();
            undead.Cure();
            tankUndead.Cure();

            //Create and Start New Encounter
            Encounter BattleOfWaterloo = new Encounter(HeroTeam, GrupoDeEnemigos);
            BattleOfWesterLands.DoEncounter();



        }
    }
}