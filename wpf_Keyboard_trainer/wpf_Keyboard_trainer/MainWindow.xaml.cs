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
            textBlockTextOutput.Text = viewModel.GenerateTextPrinting();
            viewModel.StartTimer();
            ButtonStop.IsEnabled = true;
        }

        private void ButtonStop_Click(object sender, RoutedEventArgs e)
        {
            viewModel.StopTimer();
            //viewModel.CalcInputSymbolsInMinute();
            ButtonStop.IsEnabled = false;
        }
    }
}
