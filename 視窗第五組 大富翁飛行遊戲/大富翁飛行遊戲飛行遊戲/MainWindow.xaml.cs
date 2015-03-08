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
using WMPLib;
using System.Threading;



namespace 飛行遊戲
{
    /// <summary>
    /// </summary>
    public partial class MainWindow : Window
    {
        string s, p;
        
       // static int kk = 0;
        public MainWindow()
        {
            p = "角色/孫小美.png";
            InitializeComponent();
            if (OptionWindow.m == 1)
            {
                s = "背景/馬路.png";
                
            }

            else if(OptionWindow.m == 2)
            {
                s = "背景/沙漠.png";
            }
            else if (OptionWindow.m == 3)
            {
                s = "背景/海洋.png";
            }
            else if (OptionWindow.m == 4)
            {
                s = "背景/環遊世界.png";
            }
            if(store.n == 1)
            {
                p = "角色/孫小美.png";
            }
            else if(store.n == 2)
            {
                p = "角色/沙隆巴斯.png";
            }
            else if (store.n == 3)
            {
                p = "角色/忍太郎.png";
            }
            else if (store.n == 4)
            {
                p = "角色/大老千.png";
            }
            else if (store.n == 5)
            {
                p = "角色/烏咪.png";
            }
            else if (store.n == 6)
            {
                p = "角色/錢夫人.png";
            }
            else if (store.n == 7)
            {
                p = "角色/金貝貝.png";
            }
            else if (store.n == 8)
            {
                p = "角色/舞美拉.png";
            }
            else if (store.n == 9)
            {
                p = "角色/阿土仔.png";
            }

        }
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        private void GameStart(object sender, RoutedEventArgs e)
        {
            //player.Stop(); 
            GameWindow gw = new GameWindow(s,p);
            
            this.Close();
            gw.Show();
        }


         
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.Stream = Properties.Resources.主畫面_final;
            try
            {
                //player.Load(); 
                player.PlayLooping();
            }
            catch (System.IO.FileNotFoundException err)
            {
                MessageBox.Show("找不到音效檔" + err.FileName);
            }
            catch (InvalidOperationException err)
            {
                MessageBox.Show("播放發生錯誤：" + err.Message);
            }

        
        }

        private void Option(object sender, RoutedEventArgs e)
        {
            OptionWindow ow = new OptionWindow();
            ow.Owner = this;

           
            ow.ShowDialog();

            if (OptionWindow.m == 1)
            {
                s = "背景/馬路.png";

            }

            else if (OptionWindow.m == 2)
            {
                s = "背景/沙漠.png";
            }
            else if (OptionWindow.m == 3)
            {
                s = "背景/海洋.png";
            }
            else if (OptionWindow.m == 4)
            {
                s = "背景/環遊世界.png";
            }

            
        }

        private void count(object sender, RoutedEventArgs e)
        {
              
            countWindow cw = new countWindow();
                cw.Owner = this;
                cw.ShowDialog();

        }

        private void Store(object sender, RoutedEventArgs e)
        {
            store st = new store();
            st.ShowDialog();
            if (store.n == 1)
            {
                p = "角色/孫小美.png";
            }
            else if (store.n == 2)
            {
                p = "角色/沙隆巴斯.png";
            }
            else if (store.n == 3)
            {
                p = "角色/忍太郎.png";
            }
            else if (store.n == 4)
            {
                p = "角色/大老千.png";
            }
            else if (store.n == 5)
            {
                p = "角色/烏咪.png";
            }
            else if (store.n == 6)
            {
                p = "角色/錢夫人.png";
            }
            else if (store.n == 7)
            {
                p = "角色/金貝貝.png";
            }
            else if (store.n == 8)
            {
                p = "角色/舞美拉.png";
            }
            else if (store.n == 9)
            {
                p = "角色/阿土伯-年輕.png";
            }
        }
    }
}
