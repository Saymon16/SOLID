A client should not be forced to depend on interfaces they do not use. This principle promotes the use of multiple, smaller interfaces rather than one large one.

Use case: Instead of having a large ICharacter interface with methods like Move, Attack, Heal, separate these into smaller interfaces like IMovable, IAttackable, IHealable to be implemented by classes as needed.