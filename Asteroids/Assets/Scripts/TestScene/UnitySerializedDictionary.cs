using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Asteroids
{
	[Serializable]
    public class UnitySerializedDictionary<TKey, TValue> : Dictionary<TKey, TValue>, ISerializationCallbackReceiver
	{
		[SerializeField, HideInInspector]
		protected List<TKey> keyData = new List<TKey>();

		[SerializeField, HideInInspector]
		protected List<TValue> valueData = new List<TValue>();

		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
			this.Clear();
			for (int i = 0; i < this.keyData.Count && i < this.valueData.Count; i++)
			{
				this[this.keyData[i]] = this.valueData[i];
			}
		}

		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
			this.keyData.Clear();
			this.valueData.Clear();

			foreach (var item in this)
			{
				this.keyData.Add(item.Key);
				this.valueData.Add(item.Value);
			}
		}
	}
}
