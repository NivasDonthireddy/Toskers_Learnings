using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Practise
{
    public class ViewModel
    {
        public List<NotificationCategory> Categories { get; set; }

        public List<string> Names { get; set; }
        public ViewModel()
        {
            Categories = new List<NotificationCategory>() {

                new NotificationCategory(2,"Closure"),
                new NotificationCategory(1,"Scheduled"),
                new NotificationCategory(2,"Parceled"),
                new NotificationCategory(4,"Shipped")
            };

            Names = new List<string>()
            {
                "Nivas",
                "Suresh",
                "Mario"
            };

        }
    }
}
