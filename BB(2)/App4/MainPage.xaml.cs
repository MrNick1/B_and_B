﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;


// Шаблон элемента пустой страницы задокументирован по адресу http://go.microsoft.com/fwlink/?LinkId=234238

namespace App4
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        int[,] p2col = new int[6, 6];
        int color = 0;
        int[,] var1 = new int[6, 6];
        int[,] var2 = new int[6, 6];
        int[,] var3 = new int[6, 6];
        int[,] var4 = new int[6, 6];
      
        public MainPage()
        {
            this.InitializeComponent();
            //Обнуление массива p2col
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    p2col[i, j] = 0;
                }
            }
            //

        }

        private void orange1_Click(object sender, RoutedEventArgs e)
        {
            color = 1;
        }

        private void red1_Click(object sender, RoutedEventArgs e)
        {
            color = 2;
        }

        private void green1_Click(object sender, RoutedEventArgs e)
        {
            color = 3;

        }

        private void yellow1_Click(object sender, RoutedEventArgs e)
        {
            color = 4;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            color = 0;
        }

        private void b00_Click(object sender, RoutedEventArgs e)
        {
            switch (color)
            {
                case 1:
                    b00.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0));
                    p2col[0, 0] = color;
                    break;
                case 2:
                    b00.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                    p2col[0, 0] = color;
                    break;
                case 3:
                    b00.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0));
                    p2col[0, 0] = color;
                    break;
                case 4:
                    b00.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22));
                    p2col[0, 0] = color;
                    break;
                case 0:
                    b00.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                    p2col[0, 0] = color;
                    break;
            }
        }

        private void b01_Click(object sender, RoutedEventArgs e)
        {
            switch (color)
            {
                case 1:
                    b01.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0));
                    p2col[0, 1] = color;
                    break;
                case 2:
                    b01.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                    p2col[0, 1] = color;
                    break;
                case 3:
                    b01.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0));
                    p2col[0, 1] = color;
                    break;
                case 4:
                    b01.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22));
                    p2col[0, 1] = color;
                    break;
                case 0:
                    b01.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                    p2col[0, 1] = color;
                    break;
            }
        }

        private void b02_Click(object sender, RoutedEventArgs e)
        {
            switch (color)
            {
                case 1:
                    b02.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0));
                    p2col[0, 2] = color;
                    break;
                case 2:
                    b02.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                    p2col[0, 2] = color;
                    break;
                case 3:
                    b02.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0));
                    p2col[0, 2] = color;
                    break;
                case 4:
                    b02.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22));
                    p2col[0, 2] = color;
                    break;
                case 0:
                    b02.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                    p2col[0, 2] = color;
                    break;
            }
        }

        private void b03_Click(object sender, RoutedEventArgs e)
        {
            switch (color)
            {
                case 1:
                    b03.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0));
                    p2col[0, 3] = color;
                    break;
                case 2:
                    b03.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                    p2col[0, 3] = color;
                    break;
                case 3:
                    b03.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0));
                    p2col[0, 3] = color;
                    break;
                case 4:
                    b03.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22));
                    p2col[0, 3] = color;
                    break;
                case 0:
                    b03.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                    p2col[0, 3] = color;
                    break;
            }
        }

        private void b04_Click(object sender, RoutedEventArgs e)
        {
            switch (color)
            {
                case 1:
                    b04.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0));
                    p2col[0, 4] = color;
                    break;
                case 2:
                    b04.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                    p2col[0, 4] = color;
                    break;
                case 3:
                    b04.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0));
                    p2col[0, 4] = color;
                    break;
                case 4:
                    b04.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22));
                    p2col[0, 4] = color;
                    break;
                case 0:
                    b04.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                    p2col[0, 4] = color;
                    break;
            }
        }

        private void b05_Click(object sender, RoutedEventArgs e)
        {
            switch (color)
            {
                case 1:
                    b05.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0));
                    p2col[0, 5] = color;
                    break;
                case 2:
                    b05.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                    p2col[0, 5] = color;
                    break;
                case 3:
                    b05.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0));
                    p2col[0, 5] = color;
                    break;
                case 4:
                    b05.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22));
                    p2col[0, 5] = color;
                    break;
                case 0:
                    b05.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                    p2col[0, 5] = color;
                    break;
            }
        }

        private void b10_Click(object sender, RoutedEventArgs e)
        {
            switch (color)
            {
                case 1:
                    b10.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0));
                    p2col[1, 0] = color;
                    break;
                case 2:
                    b10.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                    p2col[1, 0] = color;
                    break;
                case 3:
                    b10.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0));
                    p2col[1, 0] = color;
                    break;
                case 4:
                    b10.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22));
                    p2col[1, 0] = color;
                    break;
                case 0:
                    b10.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                    p2col[1, 0] = color;
                    break;
            }
        }

        private void b11_Click(object sender, RoutedEventArgs e)
        {
            switch (color)
            {
                case 1:
                    b11.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0));
                    p2col[1, 1] = color;
                    break;
                case 2:
                    b11.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                    p2col[1, 1] = color;
                    break;
                case 3:
                    b11.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0));
                    p2col[1, 1] = color;
                    break;
                case 4:
                    b11.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22));
                    p2col[1, 1] = color;
                    break;
                case 0:
                    b11.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                    p2col[1, 1] = color;
                    break;
            }
        }

        private void b12_Click(object sender, RoutedEventArgs e)
        {
            switch (color)
            {
                case 1:
                    b12.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0));
                    p2col[1, 2] = color;
                    break;
                case 2:
                    b12.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                    p2col[1, 2] = color;
                    break;
                case 3:
                    b12.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0));
                    p2col[1, 2] = color;
                    break;
                case 4:
                    b12.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22));
                    p2col[1, 2] = color;
                    break;
                case 0:
                    b12.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                    p2col[1, 2] = color;
                    break;
            }
        }

        private void b13_Click(object sender, RoutedEventArgs e)
        {
            switch (color)
            {
                case 1:
                    b13.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0));
                    p2col[1, 3] = color;
                    break;
                case 2:
                    b13.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                    p2col[1, 3] = color;
                    break;
                case 3:
                    b13.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0));
                    p2col[1, 3] = color;
                    break;
                case 4:
                    b13.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22));
                    p2col[1, 3] = color;
                    break;
                case 0:
                    b13.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                    p2col[1, 3] = color;
                    break;
            }
        }

        private void b14_Click(object sender, RoutedEventArgs e)
        {
            switch (color)
            {
                case 1:
                    b14.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0));
                    p2col[1, 4] = color;
                    break;
                case 2:
                    b14.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                    p2col[1, 4] = color;
                    break;
                case 3:
                    b14.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0));
                    p2col[1, 4] = color;
                    break;
                case 4:
                    b14.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22));
                    p2col[1, 4] = color;
                    break;
                case 0:
                    b14.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                    p2col[1, 4] = color;
                    break;
            }
        }

        private void b15_Click(object sender, RoutedEventArgs e)
        {
            switch (color)
            {
                case 1:
                    b15.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0));
                    p2col[1, 5] = color;
                    break;
                case 2:
                    b15.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                    p2col[1, 5] = color;
                    break;
                case 3:
                    b15.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0));
                    p2col[1, 5] = color;
                    break;
                case 4:
                    b15.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22));
                    p2col[1, 5] = color;
                    break;
                case 0:
                    b15.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                    p2col[1, 5] = color;
                    break;
            }
        }

        private void b20_Click(object sender, RoutedEventArgs e)
        {
            switch (color)
            {
                case 1:
                    b20.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0));
                    p2col[2, 0] = color;
                    break;
                case 2:
                    b20.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                    p2col[2, 0] = color;
                    break;
                case 3:
                    b20.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0));
                    p2col[2, 0] = color;
                    break;
                case 4:
                    b20.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22));
                    p2col[2, 0] = color;
                    break;
                case 0:
                    b20.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                    p2col[2, 0] = color;
                    break;
            }
        }

        private void b21_Click(object sender, RoutedEventArgs e)
        {
            switch (color)
            {
                case 1:
                    b21.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0));
                    p2col[2, 1] = color;
                    break;
                case 2:
                    b21.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                    p2col[2, 1] = color;
                    break;
                case 3:
                    b21.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0));
                    p2col[2, 1] = color;
                    break;
                case 4:
                    b21.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22));
                    p2col[2, 1] = color;
                    break;
                case 0:
                    b21.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                    p2col[2, 1] = color;
                    break;
            }
        }

        private void b22_Click(object sender, RoutedEventArgs e)
        {
            switch (color)
            {
                case 1:
                    b22.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0));
                    p2col[2, 2] = color;
                    break;
                case 2:
                    b22.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                    p2col[2, 2] = color;
                    break;
                case 3:
                    b22.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0));
                    p2col[2, 2] = color;
                    break;
                case 4:
                    b22.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22));
                    p2col[2, 2] = color;
                    break;
                case 0:
                    b22.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                    p2col[2, 2] = color;
                    break;
            }
        }

        private void b23_Click(object sender, RoutedEventArgs e)
        {
            switch (color)
            {
                case 1:
                    b23.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0));
                    p2col[2, 3] = color;
                    break;
                case 2:
                    b23.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                    p2col[2, 3] = color;
                    break;
                case 3:
                    b23.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0));
                    p2col[2, 3] = color;
                    break;
                case 4:
                    b23.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22));
                    p2col[2, 3] = color;
                    break;
                case 0:
                    b23.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                    p2col[2, 3] = color;
                    break;
            }
        }

        private void b24_Click(object sender, RoutedEventArgs e)
        {
            switch (color)
            {
                case 1:
                    b24.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0));
                    p2col[2, 4] = color;
                    break;
                case 2:
                    b24.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                    p2col[2, 4] = color;
                    break;
                case 3:
                    b24.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0));
                    p2col[2, 4] = color;
                    break;
                case 4:
                    b24.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22));
                    p2col[2, 4] = color;
                    break;
                case 0:
                    b24.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                    p2col[2, 4] = color;
                    break;
            }
        }

        private void b25_Click(object sender, RoutedEventArgs e)
        {
            switch (color)
            {
                case 1:
                    b25.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0));
                    p2col[2, 5] = color;
                    break;
                case 2:
                    b25.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                    p2col[2, 5] = color;
                    break;
                case 3:
                    b25.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0));
                    p2col[2, 5] = color;
                    break;
                case 4:
                    b25.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22));
                    p2col[2, 5] = color;
                    break;
                case 0:
                    b25.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                    p2col[2, 5] = color;
                    break;
            }
        }

        private void b30_Click(object sender, RoutedEventArgs e)
        {
            switch (color)
            {
                case 1:
                    b30.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0));
                    p2col[3, 0] = color;
                    break;
                case 2:
                    b30.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                    p2col[3, 0] = color;
                    break;
                case 3:
                    b30.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0));
                    p2col[3, 0] = color;
                    break;
                case 4:
                    b30.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22));
                    p2col[3, 0] = color;
                    break;
                case 0:
                    b30.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                    p2col[3, 0] = color;
                    break;
            }
        }

        private void b31_Click(object sender, RoutedEventArgs e)
        {
            switch (color)
            {
                case 1:
                    b31.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0));
                    p2col[3, 1] = color;
                    break;
                case 2:
                    b31.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                    p2col[3, 1] = color;
                    break;
                case 3:
                    b31.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0));
                    p2col[3, 1] = color;
                    break;
                case 4:
                    b31.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22));
                    p2col[3, 1] = color;
                    break;
                case 0:
                    b31.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                    p2col[3, 1] = color;
                    break;
            }
        }

        private void b32_Click(object sender, RoutedEventArgs e)
        {
            switch (color)
            {
                case 1:
                    b32.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0));
                    p2col[3, 2] = color;
                    break;
                case 2:
                    b32.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                    p2col[3, 2] = color;
                    break;
                case 3:
                    b32.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0));
                    p2col[3, 2] = color;
                    break;
                case 4:
                    b32.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22));
                    p2col[3, 2] = color;
                    break;
                case 0:
                    b32.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                    p2col[3, 2] = color;
                    break;
            }
        }

        private void b33_Click(object sender, RoutedEventArgs e)
        {
            switch (color)
            {
                case 1:
                    b33.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0));
                    p2col[3, 3] = color;
                    break;
                case 2:
                    b33.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                    p2col[3, 3] = color;
                    break;
                case 3:
                    b33.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0));
                    p2col[3, 3] = color;
                    break;
                case 4:
                    b33.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22));
                    p2col[3, 3] = color;
                    break;
                case 0:
                    b33.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                    p2col[3, 3] = color;
                    break;
            }
        }

        private void b34_Click(object sender, RoutedEventArgs e)
        {
            switch (color)
            {
                case 1:
                    b34.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0));
                    p2col[3, 4] = color;
                    break;
                case 2:
                    b34.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                    p2col[3, 4] = color;
                    break;
                case 3:
                    b34.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0));
                    p2col[3, 4] = color;
                    break;
                case 4:
                    b34.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22));
                    p2col[3, 4] = color;
                    break;
                case 0:
                    b34.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                    p2col[3, 4] = color;
                    break;
            }
        }

        private void b35_Click(object sender, RoutedEventArgs e)
        {
            switch (color)
            {
                case 1:
                    b35.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0));
                    p2col[3, 5] = color;
                    break;
                case 2:
                    b35.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                    p2col[3, 5] = color;
                    break;
                case 3:
                    b35.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0));
                    p2col[3, 5] = color;
                    break;
                case 4:
                    b35.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22));
                    p2col[3, 5] = color;
                    break;
                case 0:
                    b35.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                    p2col[3, 5] = color;
                    break;
            }
        }

        private void b40_Click(object sender, RoutedEventArgs e)
        {
            switch (color)
            {
                case 1:
                    b40.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0));
                    p2col[4, 0] = color;
                    break;
                case 2:
                    b40.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                    p2col[4, 0] = color;
                    break;
                case 3:
                    b40.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0));
                    p2col[4, 0] = color;
                    break;
                case 4:
                    b40.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22));
                    p2col[4, 0] = color;
                    break;
                case 0:
                    b40.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                    p2col[4, 0] = color;
                    break;
            }
        }

        private void b41_Click(object sender, RoutedEventArgs e)
        {
            switch (color)
            {
                case 1:
                    b41.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0));
                    p2col[4, 1] = color;
                    break;
                case 2:
                    b41.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                    p2col[4, 1] = color;
                    break;
                case 3:
                    b41.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0));
                    p2col[4, 1] = color;
                    break;
                case 4:
                    b41.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22));
                    p2col[4, 1] = color;
                    break;
                case 0:
                    b41.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                    p2col[4, 1] = color;
                    break;
            }
        }

        private void b42_Click(object sender, RoutedEventArgs e)
        {
            switch (color)
            {
                case 1:
                    b42.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0));
                    p2col[4, 2] = color;
                    break;
                case 2:
                    b42.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                    p2col[4, 2] = color;
                    break;
                case 3:
                    b42.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0));
                    p2col[4, 2] = color;
                    break;
                case 4:
                    b42.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22));
                    p2col[4, 2] = color;
                    break;
                case 0:
                    b42.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                    p2col[4, 2] = color;
                    break;
            }
        }

        private void b43_Click(object sender, RoutedEventArgs e)
        {
            switch (color)
            {
                case 1:
                    b43.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0));
                    p2col[4, 3] = color;
                    break;
                case 2:
                    b43.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                    p2col[4, 3] = color;
                    break;
                case 3:
                    b43.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0));
                    p2col[4, 3] = color;
                    break;
                case 4:
                    b43.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22));
                    p2col[4, 3] = color;
                    break;
                case 0:
                    b43.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                    p2col[4, 3] = color;
                    break;
            }
        }

        private void b44_Click(object sender, RoutedEventArgs e)
        {
            switch (color)
            {
                case 1:
                    b44.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0));
                    p2col[4, 4] = color;
                    break;
                case 2:
                    b44.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                    p2col[4, 4] = color;
                    break;
                case 3:
                    b44.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0));
                    p2col[4, 4] = color;
                    break;
                case 4:
                    b44.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22));
                    p2col[4, 4] = color;
                    break;
                case 0:
                    b44.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                    p2col[4, 4] = color;
                    break;
            }
        }

        private void b45_Click(object sender, RoutedEventArgs e)
        {
            switch (color)
            {
                case 1:
                    b45.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0));
                    p2col[4, 5] = color;
                    break;
                case 2:
                    b45.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                    p2col[4, 5] = color;
                    break;
                case 3:
                    b45.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0));
                    p2col[4, 5] = color;
                    break;
                case 4:
                    b45.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22));
                    p2col[4, 5] = color;
                    break;
                case 0:
                    b45.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                    p2col[4, 5] = color;
                    break;
            }
        }

        private void b50_Click(object sender, RoutedEventArgs e)
        {
            switch (color)
            {
                case 1:
                    b50.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0));
                    p2col[5, 0] = color;
                    break;
                case 2:
                    b50.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                    p2col[5, 0] = color;
                    break;
                case 3:
                    b50.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0));
                    p2col[5, 0] = color;
                    break;
                case 4:
                    b50.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22));
                    p2col[5, 0] = color;
                    break;
                case 0:
                    b50.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                    p2col[5, 0] = color;
                    break;
            }
        }

        private void b51_Click(object sender, RoutedEventArgs e)
        {
            switch (color)
            {
                case 1:
                    b51.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0));
                    p2col[5, 1] = color;
                    break;
                case 2:
                    b51.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                    p2col[5, 1] = color;
                    break;
                case 3:
                    b51.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0));
                    p2col[5, 1] = color;
                    break;
                case 4:
                    b51.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22));
                    p2col[5, 1] = color;
                    break;
                case 0:
                    b51.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                    p2col[5, 1] = color;
                    break;
            }
        }

        private void b52_Click(object sender, RoutedEventArgs e)
        {
            switch (color)
            {
                case 1:
                    b52.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0));
                    p2col[5, 2] = color;
                    break;
                case 2:
                    b52.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                    p2col[5, 2] = color;
                    break;
                case 3:
                    b52.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0));
                    p2col[5, 2] = color;
                    break;
                case 4:
                    b52.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22));
                    p2col[5, 2] = color;
                    break;
                case 0:
                    b52.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                    p2col[5, 2] = color;
                    break;
            }
        }

        private void b53_Click(object sender, RoutedEventArgs e)
        {
            switch (color)
            {
                case 1:
                    b53.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0));
                    p2col[5, 3] = color;
                    break;
                case 2:
                    b53.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                    p2col[5, 3] = color;
                    break;
                case 3:
                    b53.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0));
                    p2col[5, 3] = color;
                    break;
                case 4:
                    b53.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22));
                    p2col[5, 3] = color;
                    break;
                case 0:
                    b53.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                    p2col[5, 3] = color;
                    break;
            }
        }

        private void b54_Click(object sender, RoutedEventArgs e)
        {
            switch (color)
            {
                case 1:
                    b54.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0));
                    p2col[5, 4] = color;
                    break;
                case 2:
                    b54.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                    p2col[5, 4] = color;
                    break;
                case 3:
                    b54.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0));
                    p2col[5, 4] = color;
                    break;
                case 4:
                    b54.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22));
                    p2col[5, 4] = color;
                    break;
                case 0:
                    b54.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                    p2col[5, 4] = color;
                    break;
            }
        }

        private void b55_Click(object sender, RoutedEventArgs e)
        {
            switch (color)
            {
                case 1:
                    b55.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0));
                    p2col[5, 5] = color;
                    break;
                case 2:
                    b55.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                    p2col[5, 5] = color;
                    break;
                case 3:
                    b55.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0));
                    p2col[5, 5] = color;
                    break;
                case 4:
                    b55.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22));
                    p2col[5, 5] = color;
                    break;
                case 0:
                    b55.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                    p2col[5, 5] = color;
                    break;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            bool can = true;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (p2col[i, j] == 0)
                    {
                        can = false;
                    }
                }
            }
            if (can)
            {
                //Создание передоваемых массивов

                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (p2col[i, j] == 1)
                        {
                            var1[i, j] = 1;
                            var2[i, j] = 0;
                            var3[i, j] = 0;
                            var4[i, j] = 0;
                        }
                        if (p2col[i, j] == 2)
                        {
                            var1[i, j] = 0;
                            var2[i, j] = 2;
                            var3[i, j] = 0;
                            var4[i, j] = 0;
                        }
                        if (p2col[i, j] == 3)
                        {
                            var1[i, j] = 0;
                            var2[i, j] = 0;
                            var3[i, j] = 3;
                            var4[i, j] = 0;
                        }
                        if (p2col[i, j] == 4)
                        {
                            var1[i, j] = 0;
                            var2[i, j] = 0;
                            var3[i, j] = 0;
                            var4[i, j] = 4;
                        }
                    }
                }
            }
            else {
                var dlg = new MessageDialog("Заполните квадрат!");
                dlg.ShowAsync();
                this.Frame.Navigate(typeof(BlankPage1));
            }
        }
       
        

    }
}
