using Entitas;
using UnityEngine;

namespace Code
{
    public class PositionListener : MonoBehaviour , IEventListener, IPositionListener 
    {
        GameEntity _entity;
        private float positionZ;
        
        public void RegisterEventListeners(IEntity entity)
        {
            _entity = (GameEntity) entity;
            _entity.AddPositionListener(this);
            positionZ = transform.position.z;
        }

        public void UnregisterListeners(IEntity with)
        {
            throw new System.NotImplementedException();
        }

        public void OnPosition(GameEntity e, Vector2 newPosition)
        {
            Vector3 position = newPosition;
            position.z = positionZ;
            transform.position = position;
        }
    }
}