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

namespace ColorChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            /*int red = (int)rSlider.Value;
            int green = (int)gSlider.Value;
            int blue = (int)bSlider.Value;*/
            string rgb = "#" + Convert.ToString((int)rSlider.Value, 16) +
                Convert.ToString((int)gSlider.Value, 16) +
                Convert.ToString((int)bSlider.Value, 16);

        }
    }
}
