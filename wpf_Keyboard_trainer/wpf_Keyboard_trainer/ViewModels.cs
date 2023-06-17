using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.TextFormatting;
using System.Windows.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace wpf_Keyboard_trainer
{
    internal class ViewModels : INotifyPropertyChanged
    {
        string text = "The quick brown fox jumps over the lazy dog.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium.Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit. Et harum quidem rerum facilis est et expedita distinctio.Nam libero tempore, cum soluta nobis est eligendi optio cumque nihil impedit quo minus id quod maxime placeat.Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.";
        string[] words;
        List<string> wordList = new List<string>();

        private int _sliderValue;
        public int SliderValue
        {
            get { return _sliderValue; }
            set
            {
                _sliderValue = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private string _textOutput;
        public string TextOutput
        {
            get { return _textOutput; }
            set
            {
                _textOutput = value;
                OnPropertyChanged(nameof(TextOutput));
            }
        }

        private DispatcherTimer timer;

        private int _time;
        public int Time
        {
            get { return _time; }
            set
            {
                _time = value;
                OnPropertyChanged(nameof(Time));
            }
        }
        private string _textInput;
        public string TextInput
        {
            get { return _textInput; }
            set
            {
                _textInput = value;
                OnPropertyChanged(nameof(TextInput));
            }
        }

        //private int Seconds = 0;

        private int _numFails;
        public int NumFails
        {
            get { return _numFails; }
            set
            {
                _numFails = value;
                OnPropertyChanged(nameof(NumFails));
            }
        }

        private Brush _textInputColor;
        public Brush TextInputColor
        {
            get { return _textInputColor; }
            set
            {
                _textInputColor = value;
                OnPropertyChanged(nameof(TextInputColor));
            }
        }

        public ViewModels()
        {
            words = text.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> wordList = new List<string>(words);

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Виклик функції кожну секунду
            Time++;
            //NumErrors();
            /*
            if (ErrorChecking() == true)
            {
                TextInputColor = Brushes.Red;
            }
            */
        }
        //FIX ERRORS
        /*
        public void CalcInputSymbolsInMinute()
        {
            int numSyms = TextInput.Length / Seconds / 60;

            Time = numSyms;
        }
        */

        //FIX ERROR
        /*
        public void NumErrors()
        {
            if (ErrorChecking() == true)
            {
                _numFails++;
            }
        }
        */
        public bool ErrorChecking()
        {
            string tmp = "";
            tmp = tmp.Substring(0, _textInput.Length);
            if (_textInput != tmp)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void StartTimer()
        {
            // Запуск таймера
            timer.Start();
        }

        public void StopTimer()
        {
            // Зупинка таймера
            timer.Stop();
            //CalcInputSymbolsInMinute();
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string GenerateTextPrinting()
        {
            Random rand= new Random();
            string tmp = "";

            for (int i = 0; i < _sliderValue; i++)
            {
                tmp += $"{words[rand.Next(words.Length)]} ";
            }

            return tmp;
        }

    }
}
