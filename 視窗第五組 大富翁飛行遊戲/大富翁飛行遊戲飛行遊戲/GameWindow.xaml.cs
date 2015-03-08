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
using System.Windows.Threading;
using WMPLib;

namespace 飛行遊戲
{
    /// <summary>
    /// GameWindow.xaml 的互動邏輯
    /// </summary>
    public partial class GameWindow : Window
    {
        //static public int count2 = 0;
        //static public int count3 = 0;
        //static public int count1 = 0;
        internal DispatcherTimer timer = new DispatcherTimer();
        internal DispatcherTimer money = new DispatcherTimer();
        int time = 0,  difficulty = 0, bossPosition,haha=0;
        static public int moneytotal;
        static public int distance = 0;
        MediaPlayer player = new MediaPlayer();
        string place;
        string people;



        public GameWindow(string s , string p)
        {
            InitializeComponent();
            BitmapImage bi3 = new BitmapImage();
            bi3.BeginInit();
            bi3.UriSource = new Uri(s, UriKind.Relative);
            bi3.EndInit();
            background.Stretch = Stretch.Fill;
            background.Source = bi3;
            if (s == "背景/沙漠.png")
            {
                distanceLabel.Foreground = Brushes.White;
                moneyLabel.Foreground = Brushes.White;
            }
            place = s;
            countWindow.kk++;
            
            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri(p, UriKind.Relative);
            bi.EndInit();
            image.Stretch = Stretch.Fill;
            image.Source = bi;
            
            people = p;


            timer.Tick += new EventHandler(timer1_Tick);
            timer.Interval = new TimeSpan(100000);

            money.Tick += new EventHandler(money_Tick);
            money.Interval = new TimeSpan(10000000);


            distance = 0;

        }
        int total = 0;
        private void money_Tick(object sender, EventArgs e)
        {

            distance ++;

            if (distance >= 0 && distance < 20)
            {
                moneytotal += 10;
            }

            else if(distance <37 && distance >=20)
            {
                moneytotal += 15;
            }

            else if (distance >= 40 && distance < 70)
            {
                moneytotal += 30;
            }

            else if(distance >= 70 && distance < 85)
            {
                moneytotal += 60;
            }
            else if (distance > 85)
            {
                moneytotal += 90;
            }
            
            distanceLabel.Content = "Time: " + distance.ToString();
            moneyLabel.Content = "Money:" + moneytotal.ToString().ToString();
            Image myImage3 = new Image();
            Random r = new Random(Guid.NewGuid().GetHashCode());

            if (distance < 40 || distance >= 70)
                difficulty++;

            if (distance == 40  )
            {
                BitmapImage bi3 = new BitmapImage();
                bi3.BeginInit();

                if (place == "背景/沙漠.png")
                    bi3.UriSource = new Uri("敵人/迷糊神.png", UriKind.Relative);
                else if (place == "背景/海洋.png")
                    bi3.UriSource = new Uri("敵人/惡魔.png", UriKind.Relative);
                else if (place == "背景/環遊世界.png")
                    bi3.UriSource = new Uri("敵人/窮神.png", UriKind.Relative);                
                else
                    bi3.UriSource = new Uri("敵人/阿土伯怪物.png", UriKind.Relative);

                myImage3.Width = 200;
                myImage3.Height = 200;
                bi3.EndInit();
                myImage3.Stretch = Stretch.Fill;
                myImage3.Source = bi3;

                Canvas.SetLeft(myImage3, 700);
                Canvas.SetTop(myImage3, 250);
                player.Pause();
                canvas.Children.Add(myImage3);



                player.Play();
                total++;
                haha = total;
                bossPosition = total + 1;
           
            }

            if (distance == 90)
            {
                BitmapImage bi3 = new BitmapImage();
                bi3.BeginInit();

                if (place == "背景/沙漠.png")
                    bi3.UriSource = new Uri("敵人/迷糊神.png", UriKind.Relative);
                else if (place == "背景/海洋.png")
                    bi3.UriSource = new Uri("敵人/惡魔.png", UriKind.Relative);
                else if (place == "背景/環遊世界.png")
                    bi3.UriSource = new Uri("敵人/窮神.png", UriKind.Relative);
                else
                    bi3.UriSource = new Uri("敵人/阿土伯怪物.png", UriKind.Relative);

                myImage3.Width = 200;
                myImage3.Height = 200;
                bi3.EndInit();
                myImage3.Stretch = Stretch.Fill;
                myImage3.Source = bi3;

                Canvas.SetLeft(myImage3, 700);
                Canvas.SetTop(myImage3, 250);
                player.Pause();
                canvas.Children.Add(myImage3);



                player.Play();
                total++;
                //haha = total;
                bossPosition = total + 1;

            }
            else if (distance == 70 || distance == 110  )
            {
                Canvas.SetTop(canvas.Children[bossPosition], 3000000);
               // bossPosition = 0;
                
            }
                
            else if ((r.Next() % 1000 > 800 - difficulty * 30 && ((distance < 35 || (distance >= 70 && distance<=85 )))))
            {

                BitmapImage bi3 = new BitmapImage();
                bi3.BeginInit();

                if (place == "背景/沙漠.png")
                    switch (r.Next() % 5)
                    {
                        case 0:
                            bi3.UriSource = new Uri("敵人/怪物.png", UriKind.Relative);
                            myImage3.Width = 155;
                            myImage3.Height = 155;
                            break;
                        case 1:
                            bi3.UriSource = new Uri("敵人/飛彈.png", UriKind.Relative);
                            myImage3.Width = 156;
                            myImage3.Height = 155;
                            break;
                        case 2:
                            bi3.UriSource = new Uri("敵人/推土機.png", UriKind.Relative);
                            myImage3.Width = 156;
                            myImage3.Height = 155;
                            break;
                        case 3:
                            bi3.UriSource = new Uri("敵人/機器人.png", UriKind.Relative);
                            myImage3.Width = 151;
                            myImage3.Height = 155;
                            break;
                        case 4:
                            bi3.UriSource = new Uri("敵人/猩猩.png", UriKind.Relative);
                            myImage3.Width = 155;
                            myImage3.Height = 155;
                            break;
                        default:
                            MessageBox.Show("ERROR");
                            break;
                    }

                else if (place == "背景/海洋.png")
                    switch (r.Next() % 5)
                    {
                        case 0:
                            bi3.UriSource = new Uri("敵人/幽靈.png", UriKind.Relative);
                            myImage3.Width = 155;
                            myImage3.Height = 155;
                            break;
                        case 1:
                            bi3.UriSource = new Uri("敵人/飛彈.png", UriKind.Relative);
                            myImage3.Width = 156;
                            myImage3.Height = 155;
                            break;
                        case 2:
                            bi3.UriSource = new Uri("敵人/衰神.png", UriKind.Relative);
                            myImage3.Width = 156;
                            myImage3.Height = 155;
                            break;
                        case 3:
                            bi3.UriSource = new Uri("敵人/機器人.png", UriKind.Relative);
                            myImage3.Width = 151;
                            myImage3.Height = 155;
                            break;
                        case 4:
                            bi3.UriSource = new Uri("敵人/阿土伯怪物.png", UriKind.Relative);
                            myImage3.Width = 155;
                            myImage3.Height = 155;
                            break;
                        default:
                            MessageBox.Show("ERROR");
                            break;
                    }

                else if (place == "背景/環遊世界.png")
                    switch (r.Next() % 5)
                    {
                        case 0:
                            bi3.UriSource = new Uri("敵人/怪物.png", UriKind.Relative);
                            myImage3.Width = 155;
                            myImage3.Height = 155;
                            break;
                        case 1:
                            bi3.UriSource = new Uri("敵人/阿土伯怪物.png", UriKind.Relative);
                            myImage3.Width = 156;
                            myImage3.Height = 155;
                            break;
                        case 2:
                            bi3.UriSource = new Uri("敵人/惡魔.png", UriKind.Relative);
                            myImage3.Width = 156;
                            myImage3.Height = 155;
                            break;
                        case 3:
                            bi3.UriSource = new Uri("敵人/迷糊神.png", UriKind.Relative);
                            myImage3.Width = 151;
                            myImage3.Height = 155;
                            break;
                        case 4:
                            bi3.UriSource = new Uri("敵人/衰神.png", UriKind.Relative);
                            myImage3.Width = 155;
                            myImage3.Height = 155;
                            break;
                        default:
                            MessageBox.Show("ERROR");
                            break;
                    }

                else
                switch (r.Next() % 5)
                {
                    case 0:
                        bi3.UriSource = new Uri("敵人/推土機.png", UriKind.Relative);
                        myImage3.Width = 155;
                        myImage3.Height = 155;
                        break;
                    case 1:
                        bi3.UriSource = new Uri("敵人/怪物.png", UriKind.Relative);
                        myImage3.Width = 156;
                        myImage3.Height = 155;
                        break;
                    case 2:
                        bi3.UriSource = new Uri("敵人/飛彈.png", UriKind.Relative);
                        myImage3.Width = 156;
                        myImage3.Height = 155;
                        break;
                    case 3:
                        bi3.UriSource = new Uri("敵人/機器人.png", UriKind.Relative);
                        myImage3.Width = 151;
                        myImage3.Height = 155;
                        break;
                    case 4:
                        bi3.UriSource = new Uri("敵人/猩猩.png", UriKind.Relative);
                        myImage3.Width = 155;
                        myImage3.Height = 155;
                        break;
                    default:
                        MessageBox.Show("ERROR");
                        break;
                }

                bi3.EndInit();
                myImage3.Stretch = Stretch.Fill;
                myImage3.Source = bi3;

                Canvas.SetLeft(myImage3, 900);
                Canvas.SetTop(myImage3, r.Next() % 600);




                player.Pause();
                canvas.Children.Add(myImage3);
                 
                player.Play();

                total++;
            }
            else if (r.Next() % 1000 > 800 - difficulty * 30 && ((distance < 87 && distance >= 70) || distance >= 110) )
            {

                BitmapImage bi3 = new BitmapImage();
                bi3.BeginInit();

                if (place == "背景/沙漠.png")
                    switch (r.Next() % 5)
                    {
                        case 0:
                            bi3.UriSource = new Uri("敵人/怪物.png", UriKind.Relative);
                            myImage3.Width = 155;
                            myImage3.Height = 155;
                            break;
                        case 1:
                            bi3.UriSource = new Uri("敵人/飛彈.png", UriKind.Relative);
                            myImage3.Width = 156;
                            myImage3.Height = 155;
                            break;
                        case 2:
                            bi3.UriSource = new Uri("敵人/推土機.png", UriKind.Relative);
                            myImage3.Width = 156;
                            myImage3.Height = 155;
                            break;
                        case 3:
                            bi3.UriSource = new Uri("敵人/機器人.png", UriKind.Relative);
                            myImage3.Width = 151;
                            myImage3.Height = 155;
                            break;
                        case 4:
                            bi3.UriSource = new Uri("敵人/猩猩.png", UriKind.Relative);
                            myImage3.Width = 155;
                            myImage3.Height = 155;
                            break;
                        default:
                            MessageBox.Show("ERROR");
                            break;
                    }

                else if (place == "背景/海洋.png")
                    switch (r.Next() % 5)
                    {
                        case 0:
                            bi3.UriSource = new Uri("敵人/幽靈.png", UriKind.Relative);
                            myImage3.Width = 155;
                            myImage3.Height = 155;
                            break;
                        case 1:
                            bi3.UriSource = new Uri("敵人/飛彈.png", UriKind.Relative);
                            myImage3.Width = 156;
                            myImage3.Height = 155;
                            break;
                        case 2:
                            bi3.UriSource = new Uri("敵人/衰神.png", UriKind.Relative);
                            myImage3.Width = 156;
                            myImage3.Height = 155;
                            break;
                        case 3:
                            bi3.UriSource = new Uri("敵人/機器人.png", UriKind.Relative);
                            myImage3.Width = 151;
                            myImage3.Height = 155;
                            break;
                        case 4:
                            bi3.UriSource = new Uri("敵人/阿土伯怪物.png", UriKind.Relative);
                            myImage3.Width = 155;
                            myImage3.Height = 155;
                            break;
                        default:
                            MessageBox.Show("ERROR");
                            break;
                    }

                else if (place == "背景/環遊世界.png")
                    switch (r.Next() % 5)
                    {
                        case 0:
                            bi3.UriSource = new Uri("敵人/怪物.png", UriKind.Relative);
                            myImage3.Width = 155;
                            myImage3.Height = 155;
                            break;
                        case 1:
                            bi3.UriSource = new Uri("敵人/阿土伯怪物.png", UriKind.Relative);
                            myImage3.Width = 156;
                            myImage3.Height = 155;
                            break;
                        case 2:
                            bi3.UriSource = new Uri("敵人/惡魔.png", UriKind.Relative);
                            myImage3.Width = 156;
                            myImage3.Height = 155;
                            break;
                        case 3:
                            bi3.UriSource = new Uri("敵人/迷糊神.png", UriKind.Relative);
                            myImage3.Width = 151;
                            myImage3.Height = 155;
                            break;
                        case 4:
                            bi3.UriSource = new Uri("敵人/衰神.png", UriKind.Relative);
                            myImage3.Width = 155;
                            myImage3.Height = 155;
                            break;
                        default:
                            MessageBox.Show("ERROR");
                            break;
                    }

                else
                switch (r.Next() % 5)
                {
                    case 0:
                        bi3.UriSource = new Uri("敵人/推土機.png", UriKind.Relative);
                        myImage3.Width = 155;
                        myImage3.Height = 155;
                        break;
                    case 1:
                        bi3.UriSource = new Uri("敵人/怪物.png", UriKind.Relative);
                        myImage3.Width = 156;
                        myImage3.Height = 155;
                        break;
                    case 2:
                        bi3.UriSource = new Uri("敵人/飛彈.png", UriKind.Relative);
                        myImage3.Width = 156;
                        myImage3.Height = 155;
                        break;
                    case 3:
                        bi3.UriSource = new Uri("敵人/機器人.png", UriKind.Relative);
                        myImage3.Width = 151;
                        myImage3.Height = 155;
                        break;
                    case 4:
                        bi3.UriSource = new Uri("敵人/猩猩.png", UriKind.Relative);
                        myImage3.Width = 155;
                        myImage3.Height = 155;
                        break;
                    default:
                        MessageBox.Show("ERROR");
                        break;
                }

                bi3.EndInit();
                myImage3.Stretch = Stretch.Fill;
                myImage3.Source = bi3;

                Canvas.SetLeft(myImage3, 900);
                Canvas.SetTop(myImage3, r.Next() % 600);




                player.Pause();
                canvas.Children.Add(myImage3);
                 
                player.Play();

                total++;
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {


            time++;
            background.Margin = new Thickness(background.Margin.Left - 1.5, background.Margin.Top, 0, 0);

          
            if ((distance <= 43 && distance > 40) || (distance <= 55 && distance > 49) || (distance <= 67 && distance > 61) ||(distance <= 95 && distance > 90) || (distance <= 105 && distance > 102) )
                Canvas.SetTop(canvas.Children[bossPosition], Canvas.GetTop(canvas.Children[bossPosition]) - 1.5);
            else if ((distance <= 49 && distance > 43) || (distance <= 61 && distance > 55) || (distance <= 70 && distance > 67)|| (distance <= 102 && distance > 95) ||(distance <= 110 && distance > 105))
                Canvas.SetTop(canvas.Children[bossPosition], Canvas.GetTop(canvas.Children[bossPosition]) + 1.5);


            if (distance < 67 && distance > 40)
            {
                Random r = new Random(Guid.NewGuid().GetHashCode());
                if (r.Next() % 1000 > 950)
                {
                    Image myImage3 = new Image();
                    BitmapImage bi3 = new BitmapImage();
                    bi3.BeginInit();
                    bi3.UriSource = new Uri("角色/金幣.png", UriKind.Relative);
                    myImage3.Width = 30;
                    myImage3.Height = 30;
                    bi3.EndInit();
                    myImage3.Stretch = Stretch.Fill;
                    myImage3.Source = bi3;

                    Canvas.SetLeft(myImage3, 700);

                    Canvas.SetTop(myImage3, Canvas.GetTop(canvas.Children[bossPosition]) + 100);
                    player.Pause();
                    canvas.Children.Add(myImage3);



                    player.Play();
                    total++;
                }


            }
            if (distance < 107 && distance > 90)
            {
                Random r = new Random(Guid.NewGuid().GetHashCode());
                if (r.Next() % 1000 > 950)
                {
                    Image myImage3 = new Image();
                    BitmapImage bi3 = new BitmapImage();
                    bi3.BeginInit();
                    bi3.UriSource = new Uri("角色/金幣.png", UriKind.Relative);
                    myImage3.Width = 30;
                    myImage3.Height = 30;
                    bi3.EndInit();
                    myImage3.Stretch = Stretch.Fill;
                    myImage3.Source = bi3;

                    Canvas.SetLeft(myImage3, 700);

                    Canvas.SetTop(myImage3, r.Next() % 600);
                    player.Pause();
                    canvas.Children.Add(myImage3);



                    player.Play();
                    total++;
                }


            }


            if (distance <= 70 && distance > 40)
            {
                for (int i = bossPosition + 1; i < total + 2; i++)
                {
                    Canvas.SetLeft(canvas.Children[i], Canvas.GetLeft(canvas.Children[i]) - 10);
                }
            }
            else if (distance <= 110 && distance > 93) { 
                for (int i = bossPosition + 1; i < total + 2; i++)
                {
                    Canvas.SetLeft(canvas.Children[i], Canvas.GetLeft(canvas.Children[i]) - 50);
                }
        }

            for (int i = 2; i < total + 2; i++)
            {

                if (distance < 40 )
                {
                    Canvas.SetLeft(canvas.Children[i], Canvas.GetLeft(canvas.Children[i]) - 6 - difficulty / 7);

                    if (Canvas.GetLeft(image) + 70 > Canvas.GetLeft(canvas.Children[i]) && Canvas.GetLeft(image) < Canvas.GetLeft(canvas.Children[i]))
                        if ((Canvas.GetTop(image) + image.Height >= Canvas.GetTop(canvas.Children[i]) && Canvas.GetTop(image) + image.Height <= Canvas.GetTop(canvas.Children[i]) + 155) || (Canvas.GetTop(image) >= Canvas.GetTop(canvas.Children[i]) && Canvas.GetTop(image) <= Canvas.GetTop(canvas.Children[i]) + 155))
                        {
                            player.Stop();
                            money.Stop();
                            timer.Stop();
                            MessageBox.Show("飛行時間：" + distance + "秒");

                            MainWindow mw = new MainWindow();
                            mw.Show();
                            countWindow cw = new countWindow();
                            this.Close();
                            cw.ShowDialog();
                            //mw.Show();


                        }
                }
                else
                {
                    if (Canvas.GetLeft(image) + 70 > Canvas.GetLeft(canvas.Children[i]) && Canvas.GetLeft(image) < Canvas.GetLeft(canvas.Children[i]))
                        if ((Canvas.GetTop(image) + image.Height >= Canvas.GetTop(canvas.Children[i]) && Canvas.GetTop(image) + image.Height <= Canvas.GetTop(canvas.Children[i]) + 25.5) || (Canvas.GetTop(image) >= Canvas.GetTop(canvas.Children[i]) && Canvas.GetTop(image) <= Canvas.GetTop(canvas.Children[i]) + 25.5))
                        {
                            player.Stop();
                            money.Stop();
                            timer.Stop();
                            MessageBox.Show("飛行時間：" + distance + "秒", "遊戲結束");

                            MainWindow mw = new MainWindow();
                            mw.Show();
                            countWindow cw = new countWindow();
                            this.Close();

                            cw.ShowDialog();
                            //mw.Show();

                        }
                }
            }
            //}
                 for (int i = 2; i < total + 2; i++)
                 {

                if ((distance < 90 && distance >70) || distance >= 110)
                {
                    Canvas.SetLeft(canvas.Children[i], Canvas.GetLeft(canvas.Children[i]) -6 - difficulty /5.5);

                    if (Canvas.GetLeft(image) + 70 > Canvas.GetLeft(canvas.Children[i]) && Canvas.GetLeft(image) < Canvas.GetLeft(canvas.Children[i]))
                        if ((Canvas.GetTop(image) + image.Height >= Canvas.GetTop(canvas.Children[i]) && Canvas.GetTop(image) + image.Height <= Canvas.GetTop(canvas.Children[i]) + 155) || (Canvas.GetTop(image) >= Canvas.GetTop(canvas.Children[i]) && Canvas.GetTop(image) <= Canvas.GetTop(canvas.Children[i]) + 155))
                        {
                            player.Stop();
                            money.Stop();
                            timer.Stop();
                            MessageBox.Show("飛行時間：" + distance + "秒");

                            MainWindow mw = new MainWindow();
                            mw.Show();
                            countWindow cw = new countWindow();
                            this.Close();
                            cw.ShowDialog();
                            //mw.Show();
                         

                        }
                }
                else
                {
                    if (Canvas.GetLeft(image) + 70 > Canvas.GetLeft(canvas.Children[i]) && Canvas.GetLeft(image) < Canvas.GetLeft(canvas.Children[i]))
                        if ((Canvas.GetTop(image) + image.Height >= Canvas.GetTop(canvas.Children[i]) && Canvas.GetTop(image) + image.Height <= Canvas.GetTop(canvas.Children[i]) + 25.5) || (Canvas.GetTop(image) >= Canvas.GetTop(canvas.Children[i]) && Canvas.GetTop(image) <= Canvas.GetTop(canvas.Children[i]) + 25.5))
                        {
                            player.Stop();
                            money.Stop();
                            timer.Stop();
                            MessageBox.Show("飛行時間：" + distance + "秒", "遊戲結束");

                            MainWindow mw = new MainWindow();
                            mw.Show();
                            countWindow cw = new countWindow();
                            this.Close();
                            
                            cw.ShowDialog();
                            //mw.Show();
                            
                        }
                }
            }




        }



        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {


            if (e.Key.Equals(Key.Up))
            {
                if (Canvas.GetTop(image) >= 30)
                    Canvas.SetTop(image, Canvas.GetTop(image) - 30);

            }
            else if (e.Key.Equals(Key.Down))
            {
                if (Canvas.GetTop(image) < 573)
                    Canvas.SetTop(image, Canvas.GetTop(image) + 30);

            }
            else if (e.Key.Equals(Key.Right))
            {
                if (Canvas.GetLeft(image) < 800)
                    Canvas.SetLeft(image, Canvas.GetLeft(image) + 30);

            }
            else if (e.Key.Equals(Key.Left))
            {
                if (Canvas.GetLeft(image) >= 0)
                    Canvas.SetLeft(image, Canvas.GetLeft(image) - 30);
            }
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            if (place == "背景/沙漠.png")
                 player.Open(new Uri("遊戲音樂2.mp3", UriKind.Relative));
            else if (place == "背景/海洋.png")
                 player.Open(new Uri("遊戲音樂3.mp3", UriKind.Relative));
            else if (place == "背景/環遊世界.png")
                 player.Open(new Uri("遊戲音樂4.mp3", UriKind.Relative));
            else
                 player.Open(new Uri("遊戲音樂.mp3", UriKind.Relative));
            player.Play();

            timer.Start();
            money.Start();
        }
    }
}
