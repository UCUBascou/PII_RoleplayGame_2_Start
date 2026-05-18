# Diagrama de clases

Completa a continuación tu diagrama de clases usando
[Mermaid](https://mermaid.live/edit). Debes completar el diagrama agregando las
clases y sus atributos, operaciones y relaciones faltantes. La ventaja de usar
**Mermaid** es que el diagrama es simplemente texto en un archivo
[Markdown](https://www.markdownguide.org) como este, y no gráficos ni imágenes.

```mermaid
classDiagram
    %% Relaciones de personajes

    ICharacter <|.. Character
    ICharacter <|-- IMagicCharacter
    IMagicCharacter <|.. Wizard

    Character <|-- Hero
    Character <|-- Enemy

    Hero <|-- Wizard
    Hero <|-- Dwarf
    Hero <|-- Elf

    Enemy <|-- Undead
    Enemy <|-- Thrall

    %% Relaciones de Items

    Character --> "*" IItem : has

    IAttackItem --|> IItem
    IDefenseItem --|> IItem
    IMagicItem --|> IItem

    SpellsBook --> "*" Spell : has

    IMagicItem <|.. MagicStaff
    IMagicItem <|.. SpellsBook

    IAttackItem <|.. Axe
    IAttackItem <|.. Sword
    IAttackItem <|.. Bow
    IAttackItem <|.. MagicStaff
    IAttackItem <|.. SpellsBook

    IDefenseItem <|.. Shield
    IDefenseItem <|.. Armor
    IDefenseItem <|.. Helmet
    IDefenseItem <|.. SpellsBook
    IDefenseItem <|.. MagicStaff
    
    %% Interfaz ICharacter e items
    class ICharacter{
        <<interface>>
        +string Name
        +int BaseHealth
        +int Health
        +int AttackValue
        +int DefenseValue
        +List<IItem> Items

        +ReceiveAttack(int incomingDamage)
        +Cure()
        +int GetTotalAttack()
        +int GetTotalDefense()
        +AddItem(IItem item)
        +RemoveItem(IItem item)
    }

    class IMagicCharacter{<<Interface>>}
    class IItem{<<interface>>}

    class IAttackItem{
        <<interface>>
        +int AttackValue
    }
    class IDefenseItem{
        <<interface>>
        +int DefenseValue
    }
    class IMagicItem{
        <<interface>>
    }

    %% Character
    class Character{
        -string Name
        -int BaseHealth
        -int Health
        -int AttackValue
        -int DefenseValue
        -List<IITem> Items

        +ReceiveAttack(int incomingDamage)
        +Cure()
        +int GetTotalAttack()
        +int GetTotalDefense()
        +AddItem(IItem item)
        +RemoveItem(IItem item)
    }

    %% Héroes y enemigos
    class Hero{
        -int BaseVictoryPoints
        -int AccumulatedVictoryPoints
    }
    class Enemy{
        -int VictoryPoints
    }

    %% Héroes
    class Wizard{}
    class Dwarf{}
    class Elf{}

    %% Enemigos
    class Undead{}
    class Thrall{}

    %% Items mágicos
    class SpellsBook{
        -List<Spell> spells
        -int AttackValue
        -int DefenseValue
    }
    class Spell{
        -int AttackValue
        -int DefenseValue
    }
    class MagicStaff{
        +int AttackValue
        +int DefenseValue
    }

    %% Items de ataque
    class Axe{
        +int AttackValue
    }
    class Sword{
        +int AttackValue
    }
    class Bow{
        +int AttackValue
    }

    %% Items de defensa
    class Shield{
        +int DefenseValue
    }
    class Armor{
        +int DefenseValue
    }
    class Helmet{
        +int DefenseValue
    }
```