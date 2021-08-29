namespace Asteroids.Data
{
    internal abstract class AbstractFactory<TModel, TView> : IFactory<TModel, TView>
    {
        protected IDataLoader _dataLoader;

        public AbstractFactory(IDataLoader dataLoader) => _dataLoader = dataLoader;

        public abstract TModel GetModel();
        public abstract TView GetView();
    }
}
