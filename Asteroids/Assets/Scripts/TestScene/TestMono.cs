using UnityEngine;

namespace Asteroids
{
    public class TestMono : MonoBehaviour
    {
        //public SerializableDictionaryBase<int, string> Dic = new SerializableDictionaryBase<int, string>()
        //{
        //    [1] = "one",
        //    [2] = "two"

        //};
        //public SerializableDictionaryBase<bool, string> Dic1 = new SerializableDictionaryBase<bool, string>()
        //{
        //    [true] = "one",
        //};
        //public SerializableDictionaryBase<Color, string> Dic3 = new SerializableDictionaryBase<Color, string>();
        private void Start()
        {
            var interpreter = new NumberCut();
            //Debug.Log($"2 223 000 000 000  : {interpreter.Interpret(2223000000000)}");
            //Debug.Log($"223 000 000 000  : {interpreter.Interpret(223000000000)}");
            //Debug.Log($"22 000 000  : {interpreter.Interpret(22000000)}");
            //Debug.Log($"1 000  : {interpreter.Interpret(1000)}");
        }
    }
}
