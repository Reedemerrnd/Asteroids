using System;

namespace Asteroids
{
    public class RewindModel
    {
        private float _recordTime = 5f;


        public float RecordTime => _recordTime;


        public RewindModel(float recordTime = 0)
        {
            _recordTime = recordTime;
        }
    }
}
