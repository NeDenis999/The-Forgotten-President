using Entitas;
using Unity.Mathematics;
using UnityEngine;

namespace Code.ViewListeners
{
    public class HeroRotationListener : MonoBehaviour, IEventListener, IDirectionListener
    {
        [SerializeField] 
        private HingeJoint2D[] _hingeJoints;

        private float[] _directionsDefaultMax;
        private float[] _directionsDefaultMin;

        GameEntity _entity;

        public void RegisterEventListeners(IEntity entity)
        {
            _entity = (GameEntity) entity;
            _entity.AddDirectionListener(this);

            _directionsDefaultMax = new float[_hingeJoints.Length];
            _directionsDefaultMin = new float[_hingeJoints.Length];
            
            for (int i = 0; i < _directionsDefaultMax.Length; i++)
            {
                _directionsDefaultMax[i] = _hingeJoints[i].limits.max;
                _directionsDefaultMin[i] = _hingeJoints[i].limits.min;
            }
        }

        public void UnregisterListeners(IEntity with)
        {
            throw new System.NotImplementedException();
        }

        public void OnDirection(GameEntity entity, Vector2 value)
        {
            if (value.x > 0)
            {
                for (int i = 0; i < _directionsDefaultMax.Length; i++)
                {
                    var limits = new JointAngleLimits2D();
                    limits.max = _directionsDefaultMax[i];
                    limits.min = _directionsDefaultMin[i];
                    _hingeJoints[i].limits = limits;
                }
                
                transform.rotation = new quaternion(0, 0, 0, 1);
            }
            else if (value.x < 0)
            {
                for (int i = 0; i < _directionsDefaultMax.Length; i++)
                {
                    var limits = new JointAngleLimits2D();
                    limits.max = -_directionsDefaultMax[i];
                    limits.min = -_directionsDefaultMin[i];
                    _hingeJoints[i].limits = limits;
                    
                    //var rotation = _hingeJoints[i].transform.rotation.eulerAngles;
                    //print(rotation);
                    //rotation.x = -rotation.x;
                    //rotation.y = -rotation.y;
                    //rotation.z = -rotation.z;
                    //_hingeJoints[i].transform.Rotate(transform.rotation .eulerAngles - rotation);
                    //print(rotation);
                }
                
                transform.rotation = new quaternion(0, -180, 0, 1);
            }
        }
    }
}