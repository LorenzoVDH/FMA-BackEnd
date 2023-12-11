using FleetManager.MAUIFront.Enums;
using FleetManager.MAUIFront.MVVM.Models;
using FleetManager.MAUIFront.MVVM.ViewModels;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using FleetManager.MAUIFront.MVVM.DTOs;
using FleetManager.MAUIFront.Services;
using FleetManager.MAUIFront.HelperClasses;

namespace FleetManager.MAUIFront.MVVM.Views;

public partial class MyFuelCardView : ContentPage, INotifyPropertyChanged {
    public PageColours PageColours { get; set; }
    public MyFuelCardViewModel ViewModel { get; set; }
    private bool _showFuelCard;
    public bool ShowFuelCard {
        get {
            return _showFuelCard;
        }
        set {
            if (_showFuelCard != value) {
                _showFuelCard = value;
                OnPropertyChanged();
            }
        }
    }

    private bool _showTextFuelCardUnavailable; 
    public bool ShowTextFuelCardUnavailable {
        get {
            return _showTextFuelCardUnavailable;
        }
        set {
            if (_showTextFuelCardUnavailable != value) { 
                _showTextFuelCardUnavailable = value;
                OnPropertyChanged(); 
            }
        }
    }

    public MyFuelCardView() {
		InitializeComponent();

        ViewModel = new MyFuelCardViewModel();

        ShowFuelCard = ViewModel.FuelCard != null;
        ShowTextFuelCardUnavailable = !ShowFuelCard; 

        PageColours = ViewHelperClass.GetPageColours("MyFuelCardColourPrimary",
                                                     "MyFuelCardColourSecondary",
                                                     "MyFuelCardColourTertiary");
        ViewHelperClass.SetPageColours(PageColours.PrimaryColour, Color.FromArgb("FFFFFF"));

        BindingContext = this; 
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public async void OnClick_MakeAnInquiry(object sender, EventArgs e) {
        List<InquiryTypeDTO> selectableInquiryTypes = await APIReadService.GetInquiryTypesByCategoryName("FuelCard");

        NewInquiryViewData viewData = new() {
            SelectableInquiryTypes = selectableInquiryTypes.Select(it => new InquiryItemSelectionModel(
                it.ID,
                it.Name,
                it.AppointmentNeeded)).ToList(),
            SelectableVehicles = new List<ItemSelectionModel>(),
            Title = "New FuelCard Inquiry",
            ColourPrimary = PageColours.PrimaryColour,
            ColourSecondary = PageColours.SecondaryColour,
            ColourTertiary = PageColours.TertiaryColour
        };

        Navigation.PushAsync(new NewInquiryView(viewData));
    }

    protected override bool OnBackButtonPressed() {
        //Ugly but does the job... needs to be replaced by perhaps moving this code to the page in question 
        var navigationPage = Application.Current.MainPage as NavigationPage;
        navigationPage.BarBackgroundColor = Color.FromArgb("156B8A");
        navigationPage.BarTextColor = Color.FromArgb("FFFFFF");
        return base.OnBackButtonPressed();
    }
}
