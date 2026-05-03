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
    Character "1" --> "*" Item : has

    %% Relaciones de Item
    Item <|-- Axe
    Item <|-- Sword
    Item <|-- Bow
    Item <|-- Shield
    Item <|-- Armor
    Item <|-- Helmet
    Item <|-- Staff
    Item <|-- SpellsBook

    %% Relaciones de SpellsBook con Spell
    SpellsBook "1" --> "*" Spell : has

    %% Interfaz MagicItem
    IMagicItem <|.. Staff
    IMagicItem <|.. SpellsBook

    %% Interfaz AttackItem
    IAttackItem <|.. Axe
    IAttackItem <|.. Sword
    IAttackItem <|.. Bow

    %% Interfaz DefenseItem
    IDefenseItem <|.. Shield
    IDefenseItem <|.. Armor
    IDefenseItem <|.. Helmet

    %% clase Character
    class Character{
        -string Name
        -int BaseHealth
        -int Health
        -int AttackValue
        -int DefenseValue
        -List <Item> Items
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
    %% Clase Item
    class Item{}
    %% Interfaces
    class IAttackItem{
        +GetAttackValue()
    }
    class IDefenseItem{
        +GetDefenseValue()
    }
    class IMagicItem{}

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