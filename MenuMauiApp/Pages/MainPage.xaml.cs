using MenuMauiApp.Models;
using MenuMauiApp.PageModels;

namespace MenuMauiApp.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}