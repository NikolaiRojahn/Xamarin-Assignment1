using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Assignment1.Data;

namespace Assignment1
{
    public partial class App : Application
    {
        public static INoteEntryStore Entries { get; set; }
        public App()
        {
            InitializeComponent();

            Entries = new MemoryEntryStore();
            Entries.LoadMockData();

            MainPage = new NavigationPage(new Assignment1.MainPage())
            {
                BarBackgroundColor = Color.FromHex("#3498db"),
                BarTextColor = Color.White
            };
        }
    }
}
