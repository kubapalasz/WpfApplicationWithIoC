using StructureMap;

namespace WpfApplicationWithIoC
{
    public static class IoC
    {
        private static Container _container;

        public static T Get<T>()
        {
            return _container.GetInstance<T>();
        }

        public static void Initialize()
        {
            if (_container != null)
            {
                return;
            }
            _container = new Container();
            _container.Configure(c =>
                                 {
                                     c.IncludeRegistry<MainRegistry>();
                                 });
        }
    }
}
