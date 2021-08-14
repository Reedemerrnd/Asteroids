using UnityEngine;

namespace ScriptableObjectData
{
    [CreateAssetMenu(menuName = "Data/PlayerData")]
    public class PlayerData : ScriptableObject
    {
        #region Fields

        [SerializeField] private float _maxSpeed = 15f;
        [SerializeField] private float _minSpeed = 1f;
        [SerializeField, Range(1, 10)] private float _speed = 3.0f;
        [SerializeField, ColorUsage(false)] private Color _defaultColor;

        #endregion


        #region Properties

        public float Speed => _speed;
        public float MinSpeed => _minSpeed;
        public float MaxSpeed => _maxSpeed;
        public Color DefaultColor => _defaultColor;

        #endregion

    }
}

