using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_DZ9
{
    public class City
    {
        public int ID { get;}
        public string Name { get; set; }
        public string Country {  get; set; }

        public City(int id, string name, string country)
        {
            ID = id;
            Name = name;
            Country = country;
        }

        public City(int id) 
        {
            ID=id;
        }

        public City() { }

        public override string ToString() 
        {
            return Name;
        }
    }
}
