using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Media;

namespace ComboBox_Toskers
{
    public class ComboBoxViewModel
    {
        public List<String> NameCollection { get; set; }
        public List<Brush> BrushCollection { get; set; }
        public ComboBoxViewModel()
        {
            NameCollection = new List<String>()
            {
                "Nivas",
                "Naveen",
                "Suran",
                "Levin",
                "Thomas"
            };

            BrushCollection = new List<Brush>()
            {
                Brushes.Red,
                Brushes.Orange,
                Brushes.LightGreen,
                Brushes.DarkOrange
            };
        }
    }
}
