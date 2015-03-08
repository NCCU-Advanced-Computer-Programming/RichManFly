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
    /// Interaction logic for countWindow.xaml
    /// </summary>
    public partial class countWindow : Window
    {


        static int count1 =0;
        int i =0;
        static int count2 =0;
        static int count3 =0;
        static public int kk = 0;
       public countWindow()
        {
            InitializeComponent();
            //kk++;
            
           i = GameWindow.distance;
            if (count1 < i)
            {
                count3 = count2;
                count2 = count1;
                count1 = i;
                
            }

            else
            {
                if (count2 < i)
                {
                    count3 = count2;
                    count2 = i;
                }

                else
                    if (count3 < i)
                    {
                        count3 = i;
                    }
            }

        
            this.textBlock1.Text = "第1名                      " + count1 + "   秒\n\n" + "第2名                      " + count2 + "   秒\n\n" + "第3名                      " + count3 + "   秒\n\n";
            GameWindow.distance = 0;

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }


    }
}
