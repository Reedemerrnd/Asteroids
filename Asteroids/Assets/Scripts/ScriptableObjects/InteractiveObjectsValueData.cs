using UnityEngine;

namespace ScriptableObjectData
{
    [CreateAssetMenu(menuName = "Data/Values")]
    public class InteractiveObjectsValueData : ScriptableObject
    {
        #region Fields

        [SerializeField] private int _scoreValue = 10;
        [SerializeField] private int _scoreToPassValue = 100;
        [SerializeField] private float _speedValue = 3f;
        [SerializeField] private float _cyanDoorPushForce = 700f;

        #endregion


        #region Properties

        public int ScoreToPassValue => _scoreToPassValue;
        public int ScoreValue => _scoreValue;
        public float SpeedValue => _speedValue;
        public float PushForce => _cyanDoorPushForce;

        #endregion
    }
}

