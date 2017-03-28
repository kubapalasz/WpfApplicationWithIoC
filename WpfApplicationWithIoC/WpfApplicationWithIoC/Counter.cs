namespace WpfApplicationWithIoC
{
    public class Counter : ICounter
    {
        private int _count;

        public Counter()
        {
            _count = 0;
        }

        public void Up()
        {
            _count++;
        }

        public int Current()
        {
            return _count;
        }
    }
}
