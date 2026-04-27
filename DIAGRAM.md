# Diagrama de clases

Completa a continuación tu diagrama de clases usando
[Mermaid](https://mermaid.live/edit). Debes completar el diagrama agregando las
clases y sus atributos, operaciones y relaciones faltantes. La ventaja de usar
**Mermaid** es que el diagrama es simplemente texto en un archivo
[Markdown](https://www.markdownguide.org) como este, y no gráficos ni imágenes.

```mermaid
classDiagram
    %% Relaciones de Wizard
    Wizard "1" --> "1" SpellsBook : has
    Wizard "1" --> "1" Staff : has

    %% Relaciones de Dwarf
    Dwarf "1" --> "1" Axe : has
    Dwarf "1" --> "1" Shield : has
    Dwarf "1" --> "1" Helmet : has

    %% Relaciones de Elf
    Elf "1" --> "1" Bow : has
    Elf "1" --> "1" Armor : has
    Elf "1" --> "1" Sword : has

    %% Relaciones de SpellsBook con Spell
    SpellsBook "1" --> "*" Spell : contiene

    %% Clase Wizard
    class Wizard{
      -string Name
      -SpellsBook SpellsBook
      -MagicStaff Staff
      -int BaseHealth
      -int Health
      -int AttackValue
      -int DefenseValue
      +Wizard(string WizardName, int basehp, int AV, int DV)
      +ReceiveAttack(int incomingDamage)
      +Cure()
      +GetTotalAttack()
      +GetTotalDefense()
      +RemoveStaff()
      +RemoveSpellsBook()
    }

    %% Clase Dwarf
    class Dwarf{
      -string Name
      -Axe Axe
      -Shield Shield
      -Helmet Helmet
      -int BaseHealth
      -int Health
      -int AttackValue
      -int DefenseValue
      +Dwarf(string DwarfName, int basehp, int AV, int DV)
      +ReceiveAttack(int incomingDMG)
      +Cure()
      +GetTotalAttack()
      +GetTotalDefense()
      +RemoveAxe()
      +RemoveShield()
      +RemoveHelmet()
    }

    %% Clase Elf
    class Elf{
      -string Name
      -Bow Bow
      -Sword Sword
      -Armor Armor
      -int BaseHealth
      -int Health
      -int AttackValue
      -int DefenseValue
      +Elf(string ElfName, int basehp, int Av, int DV)
      +ReceiveAttack(int incomingDamage)
      +Cure()
      +GetTotalAttack()
      +GetTotalDefense()
      +RemoveBow()
      +RemoveSword()
      +RemoveArmor()
    }

    %% Clase SpellsBook
    class SpellsBook{
      ICollection<Spell> Spells
      -int AttackValue
      -int DefenseValue
    }

    %% Clase Spell
    class Spell{
      -int AttackValue
      -int DefenseValue
    }

    %% Armas
    class Axe{
      -int AttackValue
      -int DefenseValue
    }

    class Sword{
      -int AttackValue
      -int DefenseValue
    }

    class Bow{
      -int AttackValue
      -int DefenseValue
    }

    class Staff{
      -int AttackValue
      -int DefenseValue
    }

    %% Defensas
    class Shield{
      -int AttackValue
      -int DefenseValue
    }

    class Armor{
      -int AttackValue
      -int DefenseValue
    }

    class Helmet{
      -int AttackValue
      -int DefenseValue
    }
```
