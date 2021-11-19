using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace INotifyPropertyChanged_Toskers.ViewModels
{
    public class BackgroundViewModel : ObservableObject
    {
        private Brush _color;

        public Brush Color
        {
            get
            {
                //to prevent breaking any binding
                if (_color == null)
                    return Brushes.Orange;
                return _color;
            }

            set
            {
                _color = value;
                OnPropertyChanged(nameof(Color));
            }
        }
    }
}
