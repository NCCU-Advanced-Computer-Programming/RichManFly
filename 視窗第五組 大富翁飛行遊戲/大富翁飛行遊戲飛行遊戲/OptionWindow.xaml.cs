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
using System.Windows.Shapes;

namespace 飛行遊戲
{
    /// <summary>
    /// OptionWindow.xaml 的互動邏輯
    /// </summary>
    public partial class OptionWindow : Window
    {
        static public int m = 1;
        public string place;
        public string people;
        public OptionWindow()
        {
            InitializeComponent();
        }

        private void Confirm(object sender, RoutedEventArgs e)
        {

            if (sky.IsChecked == true)
            {
                m = 1;
                place = "背景/馬路.png";
            }


            else if (universe.IsChecked == true)
            {
                    place = "背景/沙漠.png";
                    m = 2;
            }
            else if (grass.IsChecked == true){
                    place = "背景/海洋.png";
                    m = 3;
            }
            else if (dessert.IsChecked == true)
            {
                    place = "背景/環遊世界.png";
                    m = 4;
            }

            this.Close();
        }
    }
}
