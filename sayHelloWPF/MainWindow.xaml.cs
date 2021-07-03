using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System;

namespace sayHelloWPF
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random rand;

        public MainWindow()
        {
            InitializeComponent();
            rand = new Random();
        }

        private byte[] GetRondomBytes(int n)
        {
            byte[] bytes = new byte[n];
            rand.NextBytes(bytes);
            return bytes;
        }

        private void OnClick_SayHello(object sender, RoutedEventArgs e)
        {
            byte[] bytes = GetRondomBytes(3);
            SolidColorBrush solidColorBrush = new SolidColorBrush(Color.FromArgb(255, bytes[0], bytes[1], bytes[2]));
            TextBox1.BorderBrush = solidColorBrush;
            TextBox1.Foreground = solidColorBrush;
        }
    }
}
