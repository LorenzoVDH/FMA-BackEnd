using FleetManager.MAUIFront.Exceptions;
using FleetManager.MAUIFront.MVVM.Models;
using FleetManager.MAUIFront.MVVM.ViewModels;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace FleetManager.MAUIFront.MVVM.Views;

public partial class NewInquiryView : ContentPage, INotifyPropertyChanged {
    public NewInquiryViewData ViewData { get; set; }
    public NewInquiryViewModel ViewModel { get; set; }
    public bool ShowVehicleOptions { get; set; }

    private bool _selectedInquiryNeedsAppointment; 
    public bool SelectedInquiryNeedsAppointment { 
        get {
            return _selectedInquiryNeedsAppointment;
        } 
        set {
            if (_selectedInquiryNeedsAppointment != value) {
                _selectedInquiryNeedsAppointment = value;
                OnPropertyChanged(); 
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public NewInquiryView(NewInquiryViewData viewmodelData) {
		InitializeComponent();

		ViewModel = new NewInquiryViewModel();
        ViewData = viewmodelData;
        ShowVehicleOptions = ViewData.SelectableVehicles != null ? ViewData.SelectableVehicles.Count > 0 : false;
        BindingContext = this;

        this.EntryInquiryTypeSelector.SelectedIndex = 0;
    }

    public async void OnClick_SendInquiry(object sender, EventArgs e) {
        int driverID;

        if (!Int32.TryParse(await SecureStorage.GetAsync("driverID"), out driverID)) {
            throw new Exception("Driver is not logged in or Driver ID is not found");
        }

        InquiryModel inquiry = new() {
            DriverID = driverID,
            Comment = this.EntryComment.Text,
            InquiryDate = DateTime.Now,
            InquiryTypeID = ViewData.SelectableInquiryTypes[this.EntryInquiryTypeSelector.SelectedIndex].ID,
            InquiryTypeName = ViewData.SelectableInquiryTypes[this.EntryInquiryTypeSelector.SelectedIndex].Name,
            PreferredDate = SelectedInquiryNeedsAppointment ? this.preferredAppointmentDatePicker.Date : null,
            PreferredDateBackup = SelectedInquiryNeedsAppointment ? this.preferredAppointmentDatePickerBackup.Date : null,
            Status = "InProgress",
            VehicleID = ShowVehicleOptions ? ViewData.SelectableVehicles[this.EntryVehicleSelector.SelectedIndex].ID : null,
            VehicleName = ShowVehicleOptions ? ViewData.SelectableVehicles[this.EntryVehicleSelector.SelectedIndex].Name : null
        };

        try { 
            await ViewModel.TrySendInquiry(inquiry);
            await DisplayAlert("Message", "The inquiry has been sent.", "Ok");
            await Navigation.PopAsync();
        } catch (InquiryValidationException ive) {
            await DisplayAlert("Error", ive.Message, "Ok");
        } catch (Exception ex) {
            await DisplayAlert("Technical error", $"Contact technical support. \n\n {ex.Message}", "Ok");
        }
    }


    public void OnChange_UpdateSelectedInquiry(object sender, EventArgs e) {
        if (sender is Picker picker) {
            if (picker.SelectedItem is InquiryItemSelectionModel selectedInquiry) {
                SelectedInquiryNeedsAppointment = selectedInquiry.NeedsAppointment;
            }
        }
    }

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}