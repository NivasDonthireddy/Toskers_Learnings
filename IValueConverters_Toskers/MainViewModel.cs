using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace IValueConverters_Toskers
{
    public class MainViewModel : ObservableObject
    {
        private bool isVisible;

        public bool IsVisible
        {
            get { return isVisible; }
            set { isVisible = value; UpdateVisibility(value); OnPropertyChanged("IsVisible"); }
        }

        private void UpdateVisibility(bool isVisible)
        {
            if (isVisible)
                Visibility = Visibility.Visible;
            else
                Visibility = Visibility.Hidden;
        }

        private Visibility visibility;

        public Visibility Visibility
        {
            get { return visibility; }
            set { visibility = value;OnPropertyChanged("Visibility"); }
        }



    }
}
