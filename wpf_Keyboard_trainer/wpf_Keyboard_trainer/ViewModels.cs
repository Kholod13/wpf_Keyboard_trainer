using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using static System.Net.Mime.MediaTypeNames;

namespace wpf_Keyboard_trainer
{
    internal class ViewModels : INotifyPropertyChanged
    {
        private string text = "The quick brown fox jumps over the lazy dog.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium.Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit. Et harum quidem rerum facilis est et expedita distinctio.Nam libero tempore, cum soluta nobis est eligendi optio cumque nihil impedit quo minus id quod maxime placeat.Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.";
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
        public ViewModels()
        {

        }
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



    }
}
