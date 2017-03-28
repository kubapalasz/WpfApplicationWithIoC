using System.Windows;

namespace WpfApplicationWithIoC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ICounter _counter;

        public MainWindow() : this(IoC.Get<ICounter>())
        {
        }

        public MainWindow(ICounter counter)
        {
            _counter = counter;

            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            _counter.Up();
            button.Content = _counter.Current();
        }
    }
}
