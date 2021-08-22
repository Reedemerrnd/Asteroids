using System;
using UnityEngine;

namespace Asteroids.Data
{
    public interface IFactory<TModel, TView>
    {
        public TModel GetModel();
        public TView GetView();

    }
}
