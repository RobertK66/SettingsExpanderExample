using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WinUi3Test {
    public class ListData :INotifyPropertyChanged {


        private ObservableCollection<String> _mylist = new() { "first", "second" };
        public ObservableCollection<String> MyList { get => _mylist; set => SetProperty(ref _mylist, value); }



        public event PropertyChangedEventHandler PropertyChanged;
        private bool SetProperty<T>([NotNullIfNotNull(nameof(newValue))] ref T field, T newValue, [CallerMemberName] string propertyName = null) {
            if (EqualityComparer<T>.Default.Equals(field, newValue)) {
                return false;
            }
            field = newValue;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            return true;
        }
    }
}
