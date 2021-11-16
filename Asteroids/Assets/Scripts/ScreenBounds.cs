using UnityEngine;

namespace Asteroids.Core
{
    public static class ScreenBounds
    {
        private static Camera _camera;
        private static readonly Vector3 _bottomLeft;
        private static readonly Vector3 _bottomRight;
        private static readonly Vector3 _topLeft;
        private static readonly Vector3 _topRight;

        public static Vector3 TopRight => _topRight;
        public static Vector3 TopLeft => _topLeft;
        public static Vector3 BottomRight => _bottomRight;
        public static Vector3 BottomLeft => _bottomLeft;
        public static float MinX = BottomLeft.x;
        public static float MaxX = BottomRight.x;
        public static float MinY = BottomLeft.y;
        public static float MaxY = TopRight.y;

        static ScreenBounds()
        {
            _camera = Camera.main;
            _topRight = _camera.ScreenToWorldPoint(new Vector3(_camera.pixelWidth, _camera.pixelHeight, _camera.depth));
            _topLeft = _camera.ScreenToWorldPoint(new Vector3(0, _camera.pixelHeight, _camera.depth));
            _bottomRight = _camera.ScreenToWorldPoint(new Vector3(_camera.pixelWidth, 0, _camera.depth));
            _bottomLeft = _camera.ScreenToWorldPoint(new Vector3(0, 0, _camera.depth));

        }

        public static Vector3 GetRandomPointInBounds()
        {

            return new Vector3(Random.Range(MinX, MaxX), Random.Range(MinY, MaxY),0.0f);
        }
    }
}
