using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUi3Test {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SettingsPage : Page {

        //private ObservableCollection<String> _mylist = new() { "first", "second" };
        //public ObservableCollection<String> MyList { get => _mylist; set => SetProperty(ref _mylist, value); }
        public ListData MyContext { get; set; } = new ListData();


        public SettingsPage() {
            this.InitializeComponent();
            //this.DataContext = new ListData();
        }



        //public event PropertyChangedEventHandler PropertyChanged;
        //private bool SetProperty<T>([NotNullIfNotNull(nameof(newValue))] ref T field, T newValue, [CallerMemberName] string propertyName = null) {
        //    if (EqualityComparer<T>.Default.Equals(field, newValue)) {
        //        return false;
        //    }
        //    field = newValue;
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //    return true;
        //}

        private static int i = 0;
        private void Button_Click(object sender, RoutedEventArgs e) {
            //(DataContext as ListData)?.MyList.Add(new MyLine() { TheValue = "next" + i++ });
            MyContext.MyList.Add(new MyLine() { TheValue = "next" + i++ }); ;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {
            //(DataContext as ListData)?.MyList.Clear();
            MyContext.MyList.Clear();
        }
    }
}
