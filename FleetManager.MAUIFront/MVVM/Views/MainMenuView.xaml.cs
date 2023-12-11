using FleetManager.MAUIFront.MVVM.ViewModels; 

namespace FleetManager.MAUIFront.MVVM.Views;

public partial class MainMenuView : ContentPage
{
	public MainMenuView()
	{
		InitializeComponent();

        var navigationPage = Application.Current.MainPage as NavigationPage;
        navigationPage.BarBackgroundColor = Color.FromArgb("156B8A");
        navigationPage.BarTextColor = Color.FromArgb("FFFFFF");
        //Replace this by StaticResource somehow... 

        BindingContext = new MainMenuViewModel();
        NavigationPage.SetHasBackButton(this, false);
    }

    public async void OnClick_Logout(object sender, EventArgs e) {
        bool result = await DisplayAlert("Message", "Would you like to log out?", "Yes", "No");
        
        if (result) {
            Navigation.PopToRootAsync();
        }
	}

    protected override bool OnBackButtonPressed() {
        return false;
    }

    public void OnClick_GoToMyInfo(object sender, EventArgs e) {
		Navigation.PushAsync(new MyInfoView());
    }

    public void OnClick_GoToMyVehicles(object sender, EventArgs e) {
        Navigation.PushAsync(new MyVehiclesView());
    }

    public void OnClick_GoToMyFuelCard(object sender, EventArgs e) {
        Navigation.PushAsync(new MyFuelCardView());
    }

    public void OnClick_GoToMyInquiries(object sender, EventArgs e) {
        Navigation.PushAsync(new MyInquiriesView());
    }
}
