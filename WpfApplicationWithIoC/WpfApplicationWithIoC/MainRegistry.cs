using StructureMap;

namespace WpfApplicationWithIoC
{
    public class MainRegistry : Registry
    {
        public MainRegistry()
        {
            Scan(scan =>
            {
                scan.TheCallingAssembly();
                scan.WithDefaultConventions();
            });

            // requires explicit registration; doesn't follow convention
            // For<ICounter>().Use<Counter>();
        }
    }
}
