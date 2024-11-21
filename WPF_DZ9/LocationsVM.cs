using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace WPF_DZ9
{
    public class LocationsVM
    {
        public ObservableCollection<CityVM> CityVMs { get; }
            = new ObservableCollection<CityVM>();

        public LocationsVM(IEnumerable<CityVM> cityVMs) 
        {
            foreach (CityVM cityVM in cityVMs)
            {
                CityVMs.Add(cityVM);
            }
            AddingNewItemCommand = new RelayCommand(AddingNewItem);
        }

        public ICommand AddingNewItemCommand { get; }
        private void AddingNewItem(object? param)
        {
            AddingNewItemEventArgs e = (AddingNewItemEventArgs)param!;
            e.NewItem = new CityVM(new City(id: CityVMs[^1].City.ID+1));
        }
    }
}
