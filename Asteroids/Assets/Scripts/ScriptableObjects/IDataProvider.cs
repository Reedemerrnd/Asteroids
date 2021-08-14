using UnityEngine;


namespace ScriptableObjectData
{
    public interface IDataProvider
    {
        public T GetData<T>() where T : ScriptableObject;
    }
}

