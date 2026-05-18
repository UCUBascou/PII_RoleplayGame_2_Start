using NUnit.Framework;
using System.Collections.Generic;
using System.IO;
using System;

namespace Ucu.Poo.RolePlayGame.Tests
{
    public class EncounterTests
    {
        /// <summary>
        /// Chequea que se eliminene correctamente los items, deberian ser null cuando los personajes no tienen uno de sus items
        /// </summary>
        [Test]
        public void TestDoEncounter_MultipleHeroesTeamsAndEnemiesRevived_HeroesWinBothAndEnemiesDead()
        {
            //Craer heroes y el equipo de heroes
            Elf elfo = new Elf("Elden", 100, 20, 10);
            Bow arco = new Bow(5);
            elfo.AddItem(arco);

            Dwarf enano = new Dwarf("Enzo", 100, 20, 40);
            Helmet cascon = new Helmet(67);
            Axe superAxe = new Axe(67);
            enano.AddItem(cascon);
            enano.AddItem(superAxe);

            Dwarf enano2 = new Dwarf("Minneto", 200, 40, 20);
            Axe axell = new Axe(40);
            enano2.AddItem(axell);

            Dwarf enano3 = new Dwarf("Renzo", 300, 40, 20);

            Wizard gandalf = new Wizard("Gandalf", 100, 10, 0);
            MagicStaff bastonMagico = new MagicStaff(25, 0);
            SpellBook libroDeHechizos = new SpellBook();
            gandalf.AddItem(bastonMagico);
            gandalf.AddItem(libroDeHechizos);

            List<Hero> HeroTeam = new List<Hero> {gandalf, enano, elfo};
            List<Hero> DwarfTeam = new List<Hero> {enano, enano2, enano3};

            //Crear Enemigos y el grupo de enemigos
            Thrall thrall1 = new Thrall("sech1", 150, 5, 0, 5);
            Thrall thrall2 = new Thrall("sech2", 150, 5, 0, 5);
            Thrall thrall3 = new Thrall("sech3", 150, 5, 0, 5);
            Undead undead = new Undead("DeadGus", 200, 10, 15, 10);
            Undead tankUndead = new Undead("DeadWalter", 300, 1, 20, 25);

            List<Enemy> GrupoDeEnemigos = new List<Enemy>{thrall1, thrall2, thrall3, undead, tankUndead};


            //Create and Start Encounter
            Encounter BattleOfWesterLands = new Encounter(DwarfTeam, GrupoDeEnemigos);
            BattleOfWesterLands.DoEncounter(); //En el log se puede verificar quien gano

            //Verificar que haya por lo menos un heroe vivo
            bool aliveHeros = false;
            foreach (Hero hero in DwarfTeam)
            {
                if (hero.Health > 0)
                {
                    aliveHeros = true;
                    break;
                }
            } 
            Assert.That(aliveHeros, Is.EqualTo(true));

            //Verificar que esten todos muertos
            foreach (Enemy enemy in GrupoDeEnemigos)
            {
                Assert.That(enemy.Health, Is.LessThanOrEqualTo(0));
            }

            //Revivo/curo a los enemigos para volverlos a usar en el test
            thrall1.Cure();
            thrall2.Cure();
            thrall3.Cure();
            undead.Cure();
            tankUndead.Cure();

            //Create and Start New Encounter
            Encounter BattleOfWaterloo = new Encounter(HeroTeam, GrupoDeEnemigos);
            BattleOfWaterloo.DoEncounter(); //En el log se puede verificar quien gano

            //Verificar que haya por lo menos un heroe vivo
            aliveHeros = false;
            foreach (Hero hero in HeroTeam)
            {
                if (hero.Health > 0)
                {
                    aliveHeros = true;
                    break;
                }
            } 
            Assert.That(aliveHeros, Is.EqualTo(true));

            //Verificar que esten todos muertos
            foreach (Enemy enemy in GrupoDeEnemigos)
            {
                Assert.That(enemy.Health, Is.LessThanOrEqualTo(0));
            }



        }
        [Test]
        public void TestDoEncounter_MultipleEncounters_HeroGetsExpectedVictoryPointsAndCures()
        {
            Dwarf enano_supremo = new Dwarf("amigazon",999999,9999,9999);

            List<Hero> HeroTeam = new List<Hero> {enano_supremo};

            //Crear Enemigos y el grupo de enemigos
            Thrall thrall1 = new Thrall("sech1", 100, 5, 0, 10);
            Thrall thrall2 = new Thrall("sech2", 300, 20, 0, 10);
            Thrall thrall3 = new Thrall("sech3", 100, 10, 0, 5);

            List<Enemy> GrupoDeEnemigos = new List<Enemy>{thrall1, thrall2, thrall3};

            Encounter Batalla = new Encounter(HeroTeam, GrupoDeEnemigos);

            Batalla.DoEncounter();
            foreach (Hero hero in HeroTeam)
            {
                Assert.That(hero.BaseVictoryPoints, Is.EqualTo(25));
                Assert.That(hero.Health, Is.EqualTo(hero.BaseHealth));
            }

            Thrall thrall4 = new Thrall("sech4", 100, 5, 0, 10);
            Thrall thrall5 = new Thrall("sech5", 300, 20, 0, 0);
            Thrall thrall6 = new Thrall("sech6", 100, 10, 0, 5);

            List<Enemy> Grupo = new List<Enemy>{thrall4, thrall5, thrall6};

            Encounter Batalla_2 = new Encounter(HeroTeam,Grupo);

            Batalla_2.DoEncounter();
            foreach (Hero hero in HeroTeam)
            {
                Assert.That(hero.AccumulatedVictoryPoints, Is.EqualTo(0));
                Assert.That(hero.BaseVictoryPoints, Is.EqualTo(40));
                Assert.That(hero.Health, Is.EqualTo(hero.BaseHealth));
            }
        }
        [Test]
        public void TestDoEncounter_OneEncounterWithAnEmptyTeam_EncounterWritesErrorMessageAndIsCancelled()
        {
            Dwarf enano_supremo = new Dwarf("amigazon",999999,9999,9999);

            List<Hero> HeroTeam = new List<Hero> {enano_supremo};

            List<Enemy> nada = new List<Enemy>{};

            Encounter cancelado = new Encounter(HeroTeam, nada);

            StringWriter writer = new StringWriter();
            Console.SetOut(writer);

            cancelado.DoEncounter();

            string output = writer.ToString();
            Assert.That(output, Does.Contain("No hay suficientes personajes en cada bando para iniciar el encuentro"));
        }
        [Test]
        public void TestDoEncounter_StrongerEnemyTeam_EnemyTeamWins
    }
}