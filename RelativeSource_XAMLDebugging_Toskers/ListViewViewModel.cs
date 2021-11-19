using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace RelativeSource_XAMLDebugging_Toskers
{
    public class ListViewViewModel
    {
        public ObservableCollection<string> Names { get; set; }

        public ListViewViewModel()
        {
            Names = new ObservableCollection<string>()
            {
                "Joe",
                "Nivas",
                "Shivani",
                "Jessica",
                "Matt"
            };
        }

    }
}
