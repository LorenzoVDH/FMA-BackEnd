using FleetManager.MAUIFront.Enums;
using FleetManager.MAUIFront.HelperClasses;
using FleetManager.MAUIFront.MVVM.DTOs;
using FleetManager.MAUIFront.MVVM.Models;
using FleetManager.MAUIFront.MVVM.ViewModels;
using FleetManager.MAUIFront.MVVM.Views.Models;
using FleetManager.MAUIFront.Services;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FleetManager.MAUIFront.MVVM.Views;

public partial class MyInquiriesView : ContentPage, INotifyPropertyChanged {
    public MyInquiriesViewModel ViewModel { get; set; } 
    public PageColours PageColours { get; set; }
    private bool _showInquiries;
    public bool ShowInquiries {
        get {
            return _showInquiries;
        }
        set {
            if (value != _showInquiries) {
                _showInquiries = value;
                OnPropertyChanged();
            }
        }
    }
    private bool _showTextInquiriesUnavailable;
    public bool ShowTextInquiriesUnavailable {
        get {
            return _showTextInquiriesUnavailable;
        }
        set {
            if (value != _showTextInquiriesUnavailable) {
                _showTextInquiriesUnavailable = value;
                OnPropertyChanged();
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }


    public MyInquiriesView() {
        InitializeComponent();

        ViewModel = new MyInquiriesViewModel();

        ShowInquiries = ViewModel.Inquiries != null && ViewModel.Inquiries.Count > 0;
        ShowTextInquiriesUnavailable = !ShowInquiries; 

        PageColours = ViewHelperClass.GetPageColours("MyInquiriesColourPrimary",
                                                     "MyInquiriesColourSecondary",
                                                     "MyInquiriesColourTertiary");

        ViewHelperClass.SetPageColours(PageColours.PrimaryColour, Color.FromArgb("FFFFFF"));

        BindingContext = this;
    }

    public async void OnClick_MakeAnInquiry(object sender, EventArgs e) {
        List<InquiryTypeDTO> selectableInquiryTypes = await APIReadService.GetInquiryTypesByCategoryName("General");

        NewInquiryViewData viewData = new() {
            SelectableInquiryTypes = selectableInquiryTypes.Select(it => new InquiryItemSelectionModel(
                it.ID,
                it.Name,
                it.AppointmentNeeded)).ToList(),
            Title = "Make A General Inquiry",
            ColourPrimary = PageColours.PrimaryColour,
            ColourSecondary = PageColours.SecondaryColour,
            ColourTertiary = PageColours.TertiaryColour
        };

        Navigation.PushAsync(new NewInquiryView(viewData)); 
    }

    protected override bool OnBackButtonPressed() {
        //TODO: Replace this by StaticResource somehow... 
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