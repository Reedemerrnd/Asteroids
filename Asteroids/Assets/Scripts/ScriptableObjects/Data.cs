using System.Linq;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjectData
{

    [CreateAssetMenu(menuName = "Data/Data")]
    public class Data : ScriptableObject, IDataProvider
    {
        #region Fields

        [SerializeField] private ScriptableObject[] DataSet;
        

        #endregion



        #region Interfaces

        public T GetData<T>() where T : ScriptableObject => DataSet.First(o => o is T) as T;

        #endregion
    }
}

