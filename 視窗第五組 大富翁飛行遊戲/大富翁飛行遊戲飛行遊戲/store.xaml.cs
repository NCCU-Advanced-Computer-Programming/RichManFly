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
    /// Interaction logic for store.xaml
    /// </summary>
    public partial class store : Window
    {
        static public int n = 1;
        static int a1 = 0;
        static int a2 = 0;
        static int a3 = 0;
        static int a4 = 0;
        static int a5 = 0;
        static int a6 = 0;
        static int a7 = 0;
        static int a8 = 0;
        static int a9 = 0;
        public store()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(a1 == 0)
            {
                if(MessageBox.Show("你目前擁有" + (GameWindow.moneytotal) + "元\n" + "孫小美的價格為$200元\n" + "請問你是否要繼續購買?", "孫小美", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    if (GameWindow.moneytotal >= 200 || a1 > 0)
                    {
                        n = 1;
                        if (a1 == 0)
                        {
                            GameWindow.moneytotal -= 200;
                            a1 = 1;
                        }
                        picture1 pi = new picture1();
                        this.DialogResult = true;
                        pi.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("錢幣不足, 還需要 " + (200 - GameWindow.moneytotal) + "元","警告");
                    }
                }
            }
            else
            {
                n = 1;
                picture1 pi = new picture1();
                this.DialogResult = true;
                pi.ShowDialog();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (a2 == 0)
            {
                if (MessageBox.Show("你目前擁有" + (GameWindow.moneytotal) + "元\n" + "沙隆巴斯的價格為$800元\n" + "請問你是否要繼續購買?", "沙隆巴斯", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    if (GameWindow.moneytotal >= 800 || a2 > 0)
                    {
                        n = 2;
                        if (a2 == 0)
                        {
                            GameWindow.moneytotal -= 800;
                            a2 = 1;
                        }
                        picture2 pi2 = new picture2();
                        this.DialogResult = true;
                        pi2.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("錢幣不足, 還需要 " + (800 - GameWindow.moneytotal) + "元", "警告");
                    }
                }
            }
            else
            {
                n = 2;
                picture2 pi2 = new picture2();
                this.DialogResult = true;
                pi2.ShowDialog();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (a3 == 0)
            {
                if (MessageBox.Show("你目前擁有" + (GameWindow.moneytotal) + "元\n" + "忍太郎的價格為$1500元\n" + "請問你是否要繼續購買?", "忍太郎", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    if (GameWindow.moneytotal >= 1500 || a3 > 0)
                    {
                        n = 3;
                        if (a3 == 0)
                        {
                            GameWindow.moneytotal -= 1500;
                            a3 = 1;
                        }
                        picture3 pi3 = new picture3();
                        this.DialogResult = true;
                        pi3.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("錢幣不足, 還需要 " + (1500 - GameWindow.moneytotal) + "元", "警告");
                    }
                }
            }
            else
            {
                n = 3; 
                picture3 pi3 = new picture3();
                this.DialogResult = true;
                pi3.ShowDialog();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (a4 == 0)
            {
                if (MessageBox.Show("你目前擁有" + (GameWindow.moneytotal) + "元\n" + "大老千的價格為$3000元\n" + "請問你是否要繼續購買?", "大老千", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    if (GameWindow.moneytotal >= 3000 || a4 > 0)
                    {
                        n = 4;
                        if (a4 == 0)
                        {
                            GameWindow.moneytotal -= 3000;
                            a4 = 1;
                        }
                        picture4 pi4 = new picture4();
                        this.DialogResult = true;
                        pi4.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("錢幣不足, 還需要 " + (3000 - GameWindow.moneytotal) + "元", "警告");
                    }
                }
            }
            else
            {
                n = 4;
                picture4 pi4 = new picture4();
                this.DialogResult = true;
                pi4.ShowDialog();
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (a5 == 0)
            {
                if (MessageBox.Show("你目前擁有" + (GameWindow.moneytotal) + "元\n" + "烏咪的價格為$5000元\n" + "請問你是否要繼續購買?", "烏咪", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    if (GameWindow.moneytotal >= 5000 || a5 > 0)
                    {
                        n = 5;
                        if (a5 == 0)
                        {
                            GameWindow.moneytotal -= 5000;
                            a5 = 1;
                        }
                        picture5 pi5 = new picture5();
                        this.DialogResult = true;
                        pi5.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("錢幣不足, 還需要 " + (5000 - GameWindow.moneytotal) + "元", "警告");
                    }
                }
            }
            else
            {
                n = 5;
                picture5 pi5 = new picture5();
                this.DialogResult = true;
                pi5.ShowDialog();
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (a6 == 0)
            {
                if (MessageBox.Show("你目前擁有" + (GameWindow.moneytotal) + "元\n" + "錢夫人的價格為$10000元\n" + "請問你是否要繼續購買?", "錢夫人", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    if (GameWindow.moneytotal >= 10000 || a6 > 0)
                    {
                        n = 6;
                        if (a6 == 0)
                        {
                            GameWindow.moneytotal -= 10000;
                            a6 = 1;
                        }
                        picture6 pi6 = new picture6();
                        this.DialogResult = true;
                        pi6.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("錢幣不足, 還需要 " + (10000 - GameWindow.moneytotal) + "元", "警告");
                    }
                }
            }
            else
            {
                n = 6;
                picture6 pi6 = new picture6();
                this.DialogResult = true;
                pi6.ShowDialog();
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (a7 == 0)
            {
                if (MessageBox.Show("你目前擁有" + (GameWindow.moneytotal) + "元\n" + "金貝貝的價格為$30000元\n" + "請問你是否要繼續購買?", "金貝貝", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    if (GameWindow.moneytotal >= 30000 || a7 > 0)
                    {
                        n = 7;
                        if (a7 == 0)
                        {
                            GameWindow.moneytotal -= 30000;
                            a7 = 1;
                        }
                        picture7 pi7 = new picture7();
                        this.DialogResult = true;
                        pi7.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("錢幣不足, 還需要 " + (30000 - GameWindow.moneytotal) + "元", "警告");
                    }
                }
            }
            else
            {
                n = 7;
                picture7 pi7 = new picture7();
                this.DialogResult = true;
                pi7.ShowDialog();
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (a8 == 0)
            {
                if (MessageBox.Show("你目前擁有" + (GameWindow.moneytotal) + "元\n" + "舞美拉的價格為$100000元\n" + "請問你是否要繼續購買?", "舞美拉", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    if (GameWindow.moneytotal >= 100000 || a8 > 0)
                    {
                        n = 8;
                        if (a8 == 0)
                        {
                            GameWindow.moneytotal -= 100000;
                            a8 = 1;
                        }
                        picture8 pi8 = new picture8();
                        this.DialogResult = true;
                        pi8.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("錢幣不足, 還需要 " + (100000 - GameWindow.moneytotal) + "元", "警告");
                    }
                }
            }
            else
            {
                n = 8;
                picture8 pi8 = new picture8();
                this.DialogResult = true;
                pi8.ShowDialog();
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (a9 == 0)
            {
                if (MessageBox.Show("你目前擁有" + (GameWindow.moneytotal) + "元\n" + "阿土仔的價格為$500000元\n" + "請問你是否要繼續購買?", "阿土伯-年輕", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    if (GameWindow.moneytotal >= 500000 || a9 > 0)
                    {
                        n = 9;
                        if (a9 == 0)
                        {
                            GameWindow.moneytotal -= 500000;
                            a9 = 1;
                        }
                        picture9 pi9 = new picture9();
                        this.DialogResult = true;
                        pi9.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("錢幣不足, 還需要 " + (500000 - GameWindow.moneytotal) + "元", "警告");
                    }
                }
            }
            else
            {
                n = 9;
                picture9 pi9 = new picture9();
                this.DialogResult = true;
                pi9.ShowDialog();
            }
        }
    }
}
