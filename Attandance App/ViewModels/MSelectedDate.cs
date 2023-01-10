using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attandance_App.ViewModels
{
    public class MSelectedDate
    {
        private DateTime? _selectedDate;
        public DateTime? SelectedDate
        {
            get { return _selectedDate; }
            set { _selectedDate = value; }
        }
    }
}
