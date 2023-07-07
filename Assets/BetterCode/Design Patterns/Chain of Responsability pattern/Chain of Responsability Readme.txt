Passes requests along a chain of handlers, where each handler decides either to process the request or to pass it on.

Use case: Event handling, where an event can be handled at different levels of the game (individual character, game level, global game state).