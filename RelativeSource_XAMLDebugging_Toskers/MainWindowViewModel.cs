using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RelativeSource_XAMLDebugging_Toskers
{
    public class MainWindowViewModel : ObservableObject
    {
        public ListViewViewModel ListView { get; set; }
        public ICommand RemoveNameCommand { get; set; }

        public MainWindowViewModel()
        {
            ListView = new ListViewViewModel();
            RemoveNameCommand = new RelayCommand(RemoveName);
        }

        private void RemoveName(object obj)
        {
            ListView.Names.Remove((string)obj);            
        }
    }
}
