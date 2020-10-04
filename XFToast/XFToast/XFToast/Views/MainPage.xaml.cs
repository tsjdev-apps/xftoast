using CommonServiceLocator;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFToast.ViewModels;

namespace XFToast.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = ServiceLocator.Current.GetInstance<MainPageViewModel>();
        }
    }
}