using FleetManager.MAUIFront.MVVM.DTOs;
using FleetManager.MAUIFront.MVVM.ViewModels;
using FleetManager.MAUIFront.Services;

namespace FleetManager.MAUIFront.MVVM.Views;

public partial class LoginView : ContentPage {
    public LoginView() {
        InitializeComponent();

        BindingContext = new LoginViewModel();
    }

    private async void OnClick_Login(object sender, EventArgs e) {
        string email = emailInput.Text;
        string password = passwordInput.Text;

        if (String.IsNullOrEmpty(email) || String.IsNullOrEmpty(password)) {
            await DisplayAlert("Error", "The email or password field cannot be empty", "Ok");
            return;
        }

        LoginDTO login = await APIReadService.GetDriverLoginByEmailAsync(email);

        if (login == null) {
            await DisplayAlert("Error", $"Login unsuccessful, no user with this email was found", "Ok");
            return;
        }

        bool loginResult = BCrypt.Net.BCrypt.Verify(password, login.Password);

        if (loginResult) {
            await HandleSuccessfulLogin(login);
        } else {
            await DisplayAlert("Error", $"Login unsuccessful, password is incorrect", "Ok");
        }
    }

    private async Task HandleSuccessfulLogin(LoginDTO login) {
        await SecureStorage.SetAsync("driverID", login.DriverID.ToString());
        await SecureStorage.SetAsync("driverRole", login.Role);
        await Navigation.PushAsync(new MainMenuView());
    }
}
