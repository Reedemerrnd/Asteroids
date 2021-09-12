using Inputs;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Test.Memento
{
    public sealed class TimeController : MonoBehaviour
    {
        private Dictionary<TimeBody, List<PointInTime>> _timeBodies;
        private RewindModel _rewindModel;
        private IInput _input;

        private bool _isRewinding;

        void Start()
        {
            var bodies = FindObjectsOfType<TimeBody>();
            _timeBodies = new Dictionary<TimeBody, List<PointInTime>>(bodies.Length);
            foreach (var body in bodies)
            {
                _timeBodies.Add(body, new List<PointInTime>());
            }
            Debug.Log(_timeBodies.Count);
            _rewindModel = new RewindModel(6f);
            _input = new PCInput();
        }

        private void Update()
        {
            if (_input.FireHold)
            {
                foreach (var kvp in _timeBodies)
                {
                    StartRewind(kvp.Key.Rigidbody);
                }
            }
            else
            {
                foreach (var kvp in _timeBodies)
                {
                    StopRewind(kvp.Key.Rigidbody, kvp.Value[0]);
                }
            }
        }



        private void FixedUpdate()
        {
            if (_isRewinding)
            {
                Rewind();
            }
            else
            {
                Record();
            }

        }

        private void Rewind()
        {
            foreach (var kvp in _timeBodies)
            {
                if (kvp.Value.Count > 1)
                {
                    PointInTime pointInTime = kvp.Value[0];
                    kvp.Key.Rigidbody.position = pointInTime.Position;
                    kvp.Key.Rigidbody.transform.rotation = pointInTime.Rotation;
                    kvp.Value.RemoveAt(0);
                }
                else
                {
                    PointInTime pointInTime = kvp.Value[0];
                    kvp.Key.Rigidbody.position = pointInTime.Position;
                    kvp.Key.Rigidbody.transform.rotation = pointInTime.Rotation;
                    StopRewind(kvp.Key.Rigidbody, kvp.Value[0]);
                }
            }
        }

        private void Record()
        {
            foreach (var kvp in _timeBodies)
            {
                if (kvp.Value.Count > Mathf.Round(_rewindModel.RecordTime / Time.fixedDeltaTime))
                {
                    kvp.Value.RemoveAt(kvp.Value.Count - 1);
                }

                kvp.Value.Insert(0, new PointInTime(kvp.Key.Rigidbody.position, kvp.Key.Rigidbody.transform.rotation, kvp.Key.Rigidbody.velocity, kvp.Key.Rigidbody.angularVelocity));
            }
        }

        private void StartRewind(Rigidbody2D rigidbody)
        {
            _isRewinding = true;
            rigidbody.isKinematic = true;
        }

        private void StopRewind(Rigidbody2D rigidbody, PointInTime state)
        {
            _isRewinding = false;
            rigidbody.isKinematic = false;
            rigidbody.velocity = state.Velocity;
            rigidbody.angularVelocity = state.AngularVelocity;
        }

    }
}
