using UnityEngine;
using Asteroids.Core;

namespace Asteroids.Models
{
    public class EnemySpawnModel : IEnemySpawnModel
    {
        private float _maxDelay = 2f;
        private float _minDelay = 4f;
        private float _offset = 2f;
        private float _minY;
        private float _maxY;
        private float _maxX;
        private float _minX;


        public float MinDelay => _minDelay;
        public float MaxDelay => _maxDelay;
        public float Offset => _offset;

        public EnemySpawnModel()
        {
            _minY = ScreenBounds.BottomLeft.y;
            _maxY = ScreenBounds.TopLeft.y;
            _minX = ScreenBounds.BottomLeft.x;
            _maxX = ScreenBounds.BottomRight.x;
        }

        public Vector3 GetSpawnPoint()
        {
            //implemet random spawn
            return RandomTopPoint();
        }

        private Vector3 RandomRightPoint() => new Vector3(_maxX + _offset, Randomize(_minY, _maxY), 0);
        private Vector3 RandomLeftPoint() => new Vector3(_minX - _offset, Randomize(_minY, _maxY), 0);
        private Vector3 RandomTopPoint() => new Vector3(Randomize(_minX, _maxX), _maxX + _offset, 0);
        private Vector3 RandomleftPoint() => new Vector3(Randomize(_minX, _maxX), _minX - _offset, 0);
        private float Randomize(float min, float max) => UnityEngine.Random.Range(min, max);
    }
}
