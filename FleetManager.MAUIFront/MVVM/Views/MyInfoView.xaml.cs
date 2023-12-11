using FleetManager.MAUIFront.HelperClasses;
using FleetManager.MAUIFront.MVVM.DTOs;
using FleetManager.MAUIFront.MVVM.Models;
using FleetManager.MAUIFront.MVVM.ViewModels;
using FleetManager.MAUIFront.Services;
using System.Linq;

namespace FleetManager.MAUIFront.MVVM.Views;

public partial class MyInfoView : ContentPage {
    public PageColours PageColours { get; set; }
    public DriverModel PageDriverModel { get; set; }
	public MyInfoView() {
        InitializeComponent();
        BindingContext = new MyInfoViewModel();

        PageColours = ViewHelperClass.GetPageColours("MyInfoColourPrimary",
                                                     "MyInfoColourSecondary",
                                                     "MyInfoColourTertiary");
        ViewHelperClass.SetPageColours(PageColours.PrimaryColour, Color.FromArgb("FFFFFF"));
    }

    private async void OnClick_RequestChange(object sender, EventArgs e) {
        List<InquiryTypeDTO> selectableInquiryTypes = await APIReadService.GetInquiryTypesByCategoryName("User");

        NewInquiryViewData viewData = new() {
            SelectableInquiryTypes = selectableInquiryTypes.Select(it => new InquiryItemSelectionModel(
                it.ID,
                it.Name,
                it.AppointmentNeeded
            )).ToList(),
            Title = "Request A Change",
            ColourPrimary = PageColours.PrimaryColour,
            ColourSecondary = PageColours.SecondaryColour,
            ColourTertiary = PageColours.TertiaryColour
        };

        await Navigation.PushAsync(new NewInquiryView(viewData));
    }

    protected override bool OnBackButtonPressed() {
        //Replace this by StaticResource somehow... 
        var navigationPage = Application.Current.MainPage as NavigationPage;
        navigationPage.BarBackgroundColor = Color.FromArgb("156B8A");
        navigationPage.BarTextColor = Color.FromArgb("FFFFFF");

        return base.OnBackButtonPressed();
    }
}
