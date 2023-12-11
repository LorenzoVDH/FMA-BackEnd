using FleetManager.MAUIFront.MVVM.Models;
using FleetManager.MAUIFront.MVVM.ViewModels;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using FleetManager.MAUIFront.Services;
using FleetManager.MAUIFront.MVVM.DTOs;
using FleetManager.MAUIFront.HelperClasses;
using Microsoft.Maui.Controls;
using FleetManager.MAUIFront.MVVM.Views.Models;

namespace FleetManager.MAUIFront.MVVM.Views;

public partial class MyVehiclesView : ContentPage, INotifyPropertyChanged {
    public MyVehiclesViewModel ViewModel { get; set; } 
    public PageColours PageColours { get; set; }

    private bool _showTextVehiclesUnavailable; 
    public bool ShowTextVehiclesUnavailable {
        get {
            return _showTextVehiclesUnavailable;
        }
        set {
            if (_showTextVehiclesUnavailable != value) {
                _showTextVehiclesUnavailable = value;
                OnPropertyChanged();
            }
        } 
    }

    private bool _showCollectionView;
    public bool ShowVehicles {
        get {
            return _showCollectionView;
        }
        set {
            if (_showCollectionView != value) {
                _showCollectionView = value;
                OnPropertyChanged();
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public MyVehiclesView() {
        InitializeComponent();

        ViewModel = new MyVehiclesViewModel();

        ShowVehicles = ViewModel.Vehicles != null && ViewModel.Vehicles.Count > 0;
        ShowTextVehiclesUnavailable = !ShowVehicles;

        PageColours = ViewHelperClass.GetPageColours("MyVehiclesColourPrimary",
                                                     "MyVehiclesColourSecondary",
                                                     "MyVehiclesColourTertiary");

        ViewHelperClass.SetPageColours(PageColours.PrimaryColour, Color.FromArgb("FFFFFF"));
        
        BindingContext = this;

        Debug.WriteLine("");
    }

    public async void OnClick_MakeAnInquiry(object sender, EventArgs e) {
        List<InquiryTypeDTO> selectableInquiryTypes = await APIReadService.GetInquiryTypesByCategoryName("Vehicle");

        List<ItemSelectionModel> selectableVehicles = new();

        if (Int32.TryParse(await SecureStorage.GetAsync("driverID"), out int driverId)) {
            List<VehicleDTO> vehicleDTOs = await APIReadService.GetVehiclesOfDriverAsync(driverId);
            if (vehicleDTOs != null) {
                selectableVehicles = vehicleDTOs.Select(v => new ItemSelectionModel(v.ID, v.Name)).ToList();
            }
        }

        NewInquiryViewData viewData = new() {
            SelectableInquiryTypes = selectableInquiryTypes.Select(it => new InquiryItemSelectionModel(
                it.ID,
                it.Name,
                it.AppointmentNeeded
            )).ToList(),
            SelectableVehicles = selectableVehicles,
            Title = "New Vehicle Inquiry",
            ColourPrimary = PageColours.PrimaryColour,
            ColourSecondary = PageColours.SecondaryColour,
            ColourTertiary = PageColours.TertiaryColour
        };

        Navigation.PushAsync(new NewInquiryView(viewData));
    }

    protected override bool OnBackButtonPressed() {
        //Replace this by StaticResource somehow... 
        var navigationPage = Application.Current.MainPage as NavigationPage;
        navigationPage.BarBackgroundColor = Color.FromArgb("156B8A");
        navigationPage.BarTextColor = Color.FromArgb("FFFFFF");

        return base.OnBackButtonPressed();
    }

    public void OnClick_ToggleDetails(object sender, EventArgs e) {
        if (sender is Button button && button.BindingContext is ExpandableViewItem item) {
            item.IsExpanded = !item.IsExpanded;
        }
    }
}
