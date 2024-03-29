﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

        List<string> rgblist = new List<string>();

        public MainWindow() {
            InitializeComponent();
            DataContext = GetColorList();

        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            /*int red = (int)rSlider.Value;
            int green = (int)gSlider.Value;
            int blue = (int)bSlider.Value;*/
            /*string rgb = "#" + Convert.ToString((int)rSlider.Value, 16) +
                Convert.ToString((int)gSlider.Value, 16) +
                Convert.ToString((int)bSlider.Value, 16);*/


            /*colorArea.Background = new SolidColorBrush(Color.FromRgb(savergb.R, savergb.G, savergb.B));
*/
            byte r = (byte)(int)rSlider.Value;
            byte g = (byte)(int)gSlider.Value;
            byte b = (byte)(int)bSlider.Value;
            colorArea.Background = new SolidColorBrush(Color.FromRgb(r, g, b));

        }

        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        public class MyColor {
            public Color Color { get; set; }
            public string Name { get; set; }
        }

        private void colorConboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var mycolor = (MyColor)((ComboBox)sender).SelectedItem;
            var color = mycolor.Color;
            var name = mycolor.Name;
            rSlider.Value = color.R;
            gSlider.Value = color.G;
            bSlider.Value = color.B;
            /*redText.Text = byte.Parse(color.R);
            greenText.Text = color.G.ToString();
            blueText.Text = color.B.ToString();*/
        }

        private void stockButton_Click(object sender, RoutedEventArgs e) {
            /*string rInfo = rSlider.Value.ToString();
            string gInfo = gSlider.Value.ToString();
            string bInfo = bSlider.Value.ToString();*/
            /*string rgbInfo = "R:"+ rInfo + "G:" + gInfo + "B:" + bInfo;*/

            RGB savergb = new RGB();
            savergb.R = (byte)(int)rSlider.Value;
            savergb.G = (byte)(int)gSlider.Value;
            savergb.B = (byte)(int)bSlider.Value;

            /*List<byte> rgblist = new List<byte>();*/
            rgblist.Add(rValue.Text);    //0+2...
            rgblist.Add(gValue.Text);    //1+2...
            rgblist.Add(bValue.Text);    //2+2...

            stockList.Items.Add("R:" + savergb.R + "G:" + savergb.G + "B:" + savergb.B);
        }

        private void stockList_MouseDoubleClick(object sender, MouseButtonEventArgs e) {
            //RGB savergb = (RGB)stockList.SelectedItem;

            var number = stockList.SelectedIndex;
            var rnum = number * 3;
            var gnum = number * 3 + 1;
            var bnum = number * 3 + 2;

            rValue.Text = rgblist[rnum];
            gValue.Text = rgblist[gnum];
            bValue.Text = rgblist[bnum];

            //012 345 678

        }

    }
}
