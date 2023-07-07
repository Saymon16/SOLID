using System.Collections.Generic;

namespace CompositionPattern_After
{
    public interface IGameEntity
    {
        void Move();
    }

    public class GameEntityObject : IGameEntity
    {
        public string Name;

        public void Move()
        {
        }
    }

    public class GameEntityObjectGroup : IGameEntity
    {
        public string Name;
        private List<IGameEntity> _gameEntityObjects = new List<IGameEntity>();

        public void AddEntity( IGameEntity  gameEntity)
        {
            _gameEntityObjects.Add(gameEntity);
        }

        public void Move()
        {
            foreach (var entity in _gameEntityObjects)
            {
                entity.Move();
            }
        }
    }
}