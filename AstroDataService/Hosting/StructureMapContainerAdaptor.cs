using ServiceStack.Configuration;
using StructureMap;

namespace AstroDataService.Hosting
{
    public class StructureMapContainerAdaptor : IContainerAdapter
    {
        private readonly Container _container;

        public StructureMapContainerAdaptor(Container container)
        {
            _container = container;
        }

        public T TryResolve<T>()
        {
            return _container.TryGetInstance<T>();
        }

        public T Resolve<T>()
        {
            return _container.GetInstance<T>();
        }
    }
}