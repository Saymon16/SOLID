using System.Collections.Generic;

namespace CompositionPattern_Before
{
    public class GameEntityObject
    {
        public string Name;

        public void Move()
        {
        }
    }

    public class GameEntityObjectGroup
    {
        public string Name;
        public List<GameEntityObject> GameEntityObjects;

        public void MoveGroup()
        {
            foreach (var gameEntityObject in GameEntityObjects)
            {
                gameEntityObject.Move();
            }
        }
    }
}