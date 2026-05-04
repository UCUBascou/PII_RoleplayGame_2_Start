# Diagrama de clases

Completa a continuación tu diagrama de clases usando
[Mermaid](https://mermaid.live/edit). Debes completar el diagrama agregando las
clases y sus atributos, operaciones y relaciones faltantes. La ventaja de usar
**Mermaid** es que el diagrama es simplemente texto en un archivo
[Markdown](https://www.markdownguide.org) como este, y no gráficos ni imágenes.

```mermaid
classDiagram
    %% Relaciones de Character
    Character <|-- Wizard
    Character <|-- Dwarf
    Character <|-- Elf

    %% Relaciones IItem
    IAttackItem --|> IItem
    IDefenseItem --|> IItem
    IMagicItem --|> IItem

    %% Relaciones de SpellsBook con Spell
    SpellsBook --> "*" Spell : has

    %% Interfaz MagicItem
    IMagicItem <|.. Staff
    IMagicItem <|.. SpellsBook

    %% Interfaz AttackItem
    IAttackItem <|.. Axe
    IAttackItem <|.. Sword
    IAttackItem <|.. Bow
    IAttackItem <|.. Staff
    IAttackItem <|.. SpellsBook

    %% Interfaz DefenseItem
    IDefenseItem <|.. Shield
    IDefenseItem <|.. Armor
    IDefenseItem <|.. Helmet
    IDefenseItem <|.. SpellsBook

    %% clase Character
    class Character{
        -string Name
        -int BaseHealth
        -int Health
        -int AttackValue
        -int DefenseValue
        -List <IItem> Items
        +Character(string name, int basehp, int AV, int DV)
        +ReceiveAttack(int incomingDamage)
        +Cure()
        +GetTotalAttack()
        +GetTotalDefense()
        +AddItem(Item item)
        +RemoveItem(Item item)
    }
    %% Clase Wizard
    class Wizard{
      +Wizard(string WizardName, int basehp, int AV, int DV)
    }

    %% Clase Dwarf
    class Dwarf{
      +Dwarf(string DwarfName, int basehp, int AV, int DV)
    }

    %% Clase Elf
    class Elf{
      +Elf(string ElfName, int basehp, int AV, int DV)
    }
    %% Interfaces
    class IItem{<<interface>>}
    class IAttackItem{
        <<interface>>
        +AttackValue
    }
    class IDefenseItem{
        <<interface>>
        +DefenseValue
    }
    class IMagicItem{<<interface>>}

    %% Clase SpellsBook
    class SpellsBook{
      -ICollection<Spell> Spells
    }

    %% Clase Spell
    class Spell{
      -int AttackValue
      -int DefenseValue
    }

    %% Armas
    class Axe{}
    class Sword{}
    class Bow{}
    class Staff{}
    %% Defensas
    class Shield{}
    class Armor{}
    class Helmet{}
```