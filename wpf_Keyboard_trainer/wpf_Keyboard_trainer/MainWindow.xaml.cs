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

namespace wpf_Keyboard_trainer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ViewModels viewModel;
        public MainWindow()
        {
            InitializeComponent();
            viewModel = new ViewModels();
            DataContext = viewModel;
            ButtonStop.IsEnabled = false;
        }

        private void sliderDifficulty_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            textBlockDifficulty.DataContext = viewModel;
        }

        private void ButtonStart_Click(object sender, RoutedEventArgs e)
        {
            viewModel.StartTimer();
            ButtonStop.IsEnabled = true;
        }

        private void ButtonStop_Click(object sender, RoutedEventArgs e)
        {
            viewModel.StopTimer();
            //viewModel.CalcInputSymbolsInMinute();
            ButtonStop.IsEnabled = false;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            viewModel.ErrorsWork();
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            //first row
            if (e.Key == Key.Oem3)
            {
                Button1.Background = Brushes.Red;
            }
            if (e.Key == Key.D1)
            {
                Button2.Background = Brushes.Red;
            }
            if (e.Key == Key.D2)
            {
                Button3.Background = Brushes.Red;
            }
            if (e.Key == Key.D3)
            {
                Button4.Background = Brushes.Red;
            }
            if (e.Key == Key.D4)
            {
                Button5.Background = Brushes.Red;
            }
            if (e.Key == Key.D5)
            {
                Button6.Background = Brushes.Red;
            }
            if (e.Key == Key.D6)
            {
                Button7.Background = Brushes.Red;
            }
            if (e.Key == Key.D7)
            {
                Button8.Background = Brushes.Red;
            }
            if (e.Key == Key.D8)
            {
                Button9.Background = Brushes.Red;
            }
            if (e.Key == Key.D9)
            {
                Button10.Background = Brushes.Red;
            }
            if (e.Key == Key.D0)
            {
                Button11.Background = Brushes.Red;
            }
            if (e.Key == Key.OemMinus || e.Key == Key.Subtract)
            {
                Button12.Background = Brushes.Red;
            }
            if (e.Key == Key.OemPlus)
            {
                Button13.Background = Brushes.Red;
            }
            if (e.Key == Key.Back)
            {
                Button14.Background = Brushes.Red;
            }
            // second row
            if (e.Key == Key.Tab)
            {
                Button15.Background = Brushes.Red;
            }
            if (e.Key == Key.Q)
            {
                Button16.Background = Brushes.Red;
            }
            if (e.Key == Key.W)
            {
                Button17.Background = Brushes.Red;
            }
            if (e.Key == Key.E)
            {
                Button18.Background = Brushes.Red;
            }
            if (e.Key == Key.R)
            {
                Button19.Background = Brushes.Red;
            }
            if (e.Key == Key.T)
            {
                Button20.Background = Brushes.Red;
            }
            if (e.Key == Key.Y)
            {
                Button21.Background = Brushes.Red;
            }
            if (e.Key == Key.U)
            {
                Button22.Background = Brushes.Red;
            }
            if (e.Key == Key.I)
            {
                Button23.Background = Brushes.Red;
            }
            if (e.Key == Key.O)
            {
                Button24.Background = Brushes.Red;
            }
            if (e.Key == Key.P)
            {
                Button25.Background = Brushes.Red;
            }
            if (e.Key == Key.Oem4)
            {
                Button26.Background = Brushes.Red;
            }
            if (e.Key == Key.Oem6)
            {
                Button27.Background = Brushes.Red;
            }
            if (e.Key == Key.Oem5)
            {
                Button28.Background = Brushes.Red;
            }
            //third row
            if (e.Key == Key.CapsLock)
            {
                Button29.Background = Brushes.Red;
            }
            if (e.Key == Key.A)
            {
                Button30.Background = Brushes.Red;
            }
            if (e.Key == Key.S)
            {
                Button31.Background = Brushes.Red;
            }
            if (e.Key == Key.D)
            {
                Button32.Background = Brushes.Red;
            }
            if (e.Key == Key.F)
            {
                Button33.Background = Brushes.Red;
            }
            if (e.Key == Key.G)
            {
                Button34.Background = Brushes.Red;
            }
            if (e.Key == Key.H)
            {
                Button35.Background = Brushes.Red;
            }
            if (e.Key == Key.J)
            {
                Button36.Background = Brushes.Red;
            }
            if (e.Key == Key.K)
            {
                Button37.Background = Brushes.Red;
            }
            if (e.Key == Key.L)
            {
                Button38.Background = Brushes.Red;
            }
            if (e.Key == Key.OemSemicolon)
            {
                Button39.Background = Brushes.Red;
            }
            if (e.Key == Key.OemQuotes)
            {
                Button40.Background = Brushes.Red;
            }
            if (e.Key == Key.Enter)
            {
                Button41.Background = Brushes.Red;
            }
            //fourth row
            if (e.Key == Key.LeftShift)
            {
                Button42.Background = Brushes.Red;
            }
            if (e.Key == Key.Z)
            {
                Button43.Background = Brushes.Red;
            }
            if (e.Key == Key.X)
            {
                Button44.Background = Brushes.Red;
            }
            if (e.Key == Key.C)
            {
                Button45.Background = Brushes.Red;
            }
            if (e.Key == Key.V)
            {
                Button46.Background = Brushes.Red;
            }
            if (e.Key == Key.B)
            {
                Button47.Background = Brushes.Red;
            }
            if (e.Key == Key.N)
            {
                Button48.Background = Brushes.Red;
            }
            if (e.Key == Key.M)
            {
                Button49.Background = Brushes.Red;
            }
            if (e.Key == Key.OemComma)
            {
                Button50.Background = Brushes.Red;
            }
            if (e.Key == Key.OemPeriod)
            {
                Button51.Background = Brushes.Red;
            }
            if (e.Key == Key.OemQuestion)
            {
                Button52.Background = Brushes.Red;
            }
            if (e.Key == Key.RightShift)
            {
                Button53.Background = Brushes.Red;
            }
            //fifth row
            if (e.Key == Key.LeftCtrl)
            {
                Button54.Background = Brushes.Red;
            }
            if (e.Key == Key.LWin)
            {
                Button55.Background = Brushes.Red;
            }
            if (e.Key == Key.LeftAlt)
            {
                Button56.Background = Brushes.Red;
            }
            if (e.Key == Key.Space)
            {
                Button57.Background = Brushes.Red;
            }
            if (e.Key == Key.RightAlt)
            {
                Button58.Background = Brushes.Red;
            }
            if (e.Key == Key.RWin)
            {
                Button59.Background = Brushes.Red;
            }
            if (e.Key == Key.RightCtrl)
            {
                Button60.Background = Brushes.Red;
            }
        }

        private void Window_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            //first row
            if (e.Key == Key.Oem3)
            {
                Button1.Background = Brushes.HotPink;
            }
            if (e.Key == Key.D1)
            {
                Button2.Background = Brushes.HotPink;
            }
            if (e.Key == Key.D2)
            {
                Button3.Background = Brushes.HotPink;
            }
            if (e.Key == Key.D3)
            {
                Button4.Background = Brushes.Yellow;
            }
            if (e.Key == Key.D4)
            {
                Button5.Background = Brushes.LightGreen;
            }
            if (e.Key == Key.D5)
            {
                Button6.Background = Brushes.Aqua;
            }
            if (e.Key == Key.D6)
            {
                Button7.Background = Brushes.Aqua;
            }
            if (e.Key == Key.D7)
            {
                Button8.Background = Brushes.BlueViolet;
            }
            if (e.Key == Key.D8)
            {
                Button9.Background = Brushes.BlueViolet;
            }
            if (e.Key == Key.D9)
            {
                Button10.Background = Brushes.HotPink;
            }
            if (e.Key == Key.D0)
            {
                Button11.Background = Brushes.Yellow;
            }
            if (e.Key == Key.OemMinus || e.Key == Key.Subtract)
            {
                Button12.Background = Brushes.LightGreen;
            }
            if (e.Key == Key.OemPlus)
            {
                Button13.Background = Brushes.LightGreen;
            }
            if (e.Key == Key.Back)
            {
                Button14.Background = Brushes.Gray;
            }
            // second row
            if (e.Key == Key.Tab)
            {
                Button15.Background = Brushes.Gray;
            }
            if (e.Key == Key.Q)
            {
                Button16.Background = Brushes.HotPink;
            }
            if (e.Key == Key.W)
            {
                Button17.Background = Brushes.Yellow;
            }
            if (e.Key == Key.E)
            {
                Button18.Background = Brushes.LightGreen;
            }
            if (e.Key == Key.R)
            {
                Button19.Background = Brushes.Aqua;
            }
            if (e.Key == Key.T)
            {
                Button20.Background = Brushes.Aqua;
            }
            if (e.Key == Key.Y)
            {
                Button21.Background = Brushes.BlueViolet;
            }
            if (e.Key == Key.U)
            {
                Button22.Background = Brushes.BlueViolet;
            }
            if (e.Key == Key.I)
            {
                Button23.Background = Brushes.HotPink;
            }
            if (e.Key == Key.O)
            {
                Button24.Background = Brushes.Yellow;
            }
            if (e.Key == Key.P)
            {
                Button25.Background = Brushes.LightGreen;
            }
            if (e.Key == Key.Oem4)
            {
                Button26.Background = Brushes.LightGreen;
            }
            if (e.Key == Key.Oem6)
            {
                Button27.Background = Brushes.LightGreen;
            }
            if (e.Key == Key.Oem5)
            {
                Button28.Background = Brushes.LightGreen;
            }
            //third row
            if (e.Key == Key.CapsLock)
            {
                Button29.Background = Brushes.Gray;
            }
            if (e.Key == Key.A)
            {
                Button30.Background = Brushes.HotPink;
            }
            if (e.Key == Key.S)
            {
                Button31.Background = Brushes.Yellow;
            }
            if (e.Key == Key.D)
            {
                Button32.Background = Brushes.LightGreen;
            }
            if (e.Key == Key.F)
            {
                Button33.Background = Brushes.Aqua;
            }
            if (e.Key == Key.G)
            {
                Button34.Background = Brushes.Aqua;
            }
            if (e.Key == Key.H)
            {
                Button35.Background = Brushes.BlueViolet;
            }
            if (e.Key == Key.J)
            {
                Button36.Background = Brushes.BlueViolet;
            }
            if (e.Key == Key.K)
            {
                Button37.Background = Brushes.HotPink;
            }
            if (e.Key == Key.L)
            {
                Button38.Background = Brushes.Yellow;
            }
            if (e.Key == Key.OemSemicolon)
            {
                Button39.Background = Brushes.LightGreen;
            }
            if (e.Key == Key.OemQuotes)
            {
                Button40.Background = Brushes.LightGreen;
            }
            if (e.Key == Key.Enter)
            {
                Button41.Background = Brushes.Gray;
            }
            //fourth row
            if (e.Key == Key.LeftShift)
            {
                Button42.Background = Brushes.Gray;
            }
            if (e.Key == Key.Z)
            {
                Button43.Background = Brushes.HotPink;
            }
            if (e.Key == Key.X)
            {
                Button44.Background = Brushes.Yellow;
            }
            if (e.Key == Key.C)
            {
                Button45.Background = Brushes.LightGreen;
            }
            if (e.Key == Key.V)
            {
                Button46.Background = Brushes.Aqua;
            }
            if (e.Key == Key.B)
            {
                Button47.Background = Brushes.Aqua;
            }
            if (e.Key == Key.N)
            {
                Button48.Background = Brushes.BlueViolet;
            }
            if (e.Key == Key.M)
            {
                Button49.Background = Brushes.BlueViolet;
            }
            if (e.Key == Key.OemComma)
            {
                Button50.Background = Brushes.HotPink;
            }
            if (e.Key == Key.OemPeriod)
            {
                Button51.Background = Brushes.Yellow;
            }
            if (e.Key == Key.OemQuestion)
            {
                Button52.Background = Brushes.LightGreen;
            }
            if (e.Key == Key.RightShift)
            {
                Button53.Background = Brushes.Gray;
            }
            //fifth row
            if (e.Key == Key.LeftCtrl)
            {
                Button54.Background = Brushes.Gray;
            }
            if (e.Key == Key.LWin)
            {
                Button55.Background = Brushes.Gray;
            }
            if (e.Key == Key.LeftAlt)
            {
                Button56.Background = Brushes.Gray;
            }
            if (e.Key == Key.Space)
            {
                Button57.Background = Brushes.Coral;
            }
            if (e.Key == Key.RightAlt)
            {
                Button58.Background = Brushes.Gray;
            }
            if (e.Key == Key.RWin)
            {
                Button59.Background = Brushes.Gray;
            }
            if (e.Key == Key.RightCtrl)
            {
                Button60.Background = Brushes.Gray;
            }
        }
    }
}
