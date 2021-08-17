using UnityEngine;

namespace View
{ 
    public interface IBullet
    {
        public void Fire(Vector3 direction, float power);
    }
}
