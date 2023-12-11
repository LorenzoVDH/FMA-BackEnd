    using FleetManager.MAUIFront.MVVM.Views;

namespace FleetManager.MAUIFront;
public partial class App : Application {
    public App() {
        InitializeComponent();

        MainPage = new NavigationPage(new LoginView());
    }
}