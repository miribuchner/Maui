using MauiAppZufall.ViewModels;

namespace MauiAppZufall
{
    public partial class MainPage : ContentPage
    {
      
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new MainViewModel();

        }

        
    }

}
