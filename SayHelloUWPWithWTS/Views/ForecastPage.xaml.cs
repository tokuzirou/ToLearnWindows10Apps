using System;

using SayHelloUWPWithWTS.ViewModels;

using Windows.UI.Xaml.Controls;

namespace SayHelloUWPWithWTS.Views
{
    public sealed partial class ForecastPage : Page
    {
        public ForecastViewModel ViewModel { get; } = new ForecastViewModel();

        public ForecastPage()
        {
            InitializeComponent();
        }
    }
}
