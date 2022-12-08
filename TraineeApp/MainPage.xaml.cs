using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using TraineeApp.Models;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TraineeApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        TraineeRepo repo;
        public MainPage()
        {
            this.InitializeComponent();
            this.repo = new TraineeRepo();
            this.listTrainees.ItemsSource = this.repo.Get();
        }

        private void listTrainees_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = this.listTrainees.SelectedItem as Trainee;
            this.Frame.Navigate(typeof(TraineeDetails), new PageNavParam { Id = selected.Id });
        }
    }
}
