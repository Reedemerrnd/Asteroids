using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class TestMono : MonoBehaviour
    {
        public SerializableDictionaryBase<int, string> Dic = new SerializableDictionaryBase<int, string>()
        {
            [1] = "one",
            [2] = "two"

        };
        public SerializableDictionaryBase<bool, string> Dic1 = new SerializableDictionaryBase<bool, string>()
        {
            [true] = "one",
        };
        public SerializableDictionaryBase<Color, string> Dic3 = new SerializableDictionaryBase<Color, string>();
    }
}
