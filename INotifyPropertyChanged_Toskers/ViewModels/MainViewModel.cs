using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace INotifyPropertyChanged_Toskers.ViewModels
{
    public class MainViewModels
    {
        public PersonViewModel Person { get; private set; }

        public BackgroundViewModel Background { get; private set; }

        public MainViewModels()
        {
            //Instantiating the above properties to Empty declarations
            //This way we can check out null checking as well
            Person = new PersonViewModel();
            Background = new BackgroundViewModel();
            //this will set the Name to "Unknown" and Color to null
        }

        public void SetBackground(Brush brushColor)
        {
            Background.Color = brushColor;
        }
    }
}
