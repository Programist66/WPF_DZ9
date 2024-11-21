using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace WPF_DZ9
{
    public class CityVM
    {
        public City City { get;}
        public CityVM(City city)
        {
            City = city;
        }

        public CityVM() { throw new NotSupportedException(); }

        public IReadOnlyList<string> AllCountrys { get; } = new List<string>() 
        {
            "Россия", "США", "Англия", "Франция",
        };

        
    }
}
