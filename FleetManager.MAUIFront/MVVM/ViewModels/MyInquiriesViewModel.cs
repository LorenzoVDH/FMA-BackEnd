using FleetManager.MAUIFront.MVVM.DTOs;
using FleetManager.MAUIFront.MVVM.Models;
using FleetManager.MAUIFront.MVVM.Views.Models;
using FleetManager.MAUIFront.Services;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FleetManager.MAUIFront.MVVM.ViewModels;
public class MyInquiriesViewModel : INotifyPropertyChanged {
    private List<ExpandableViewItem> _inquiries;
    public List<ExpandableViewItem> Inquiries {
        get => _inquiries;
        set {
            if (value !=  _inquiries) {
                _inquiries = value;
                OnPropertyChanged(); 
            }
        } 
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public MyInquiriesViewModel() {
        Task.Run(() => SetInquiryData()).Wait();
    }

    private async Task SetInquiryData() {
        if (Int32.TryParse(await SecureStorage.GetAsync("driverID"), out int driverId)) {
            Inquiries = new List<ExpandableViewItem>();

            List<InquiryDTO> inquiryDTOs = await APIReadService.GetInquiriesByDriverIDAsync(driverId);
            if (inquiryDTOs != null) { 
                foreach (InquiryDTO inquiryDTO in inquiryDTOs) {
                    Inquiries.Add(new ExpandableViewItem(new InquiryModel() {
                        VehicleName = inquiryDTO.VehicleName,
                        VehicleID = inquiryDTO.VehicleID,
                        Status = inquiryDTO.Status,
                        PreferredDateBackup = inquiryDTO.PreferredDateBackup,
                        PreferredDate = inquiryDTO.PreferredDate,
                        InquiryTypeName = inquiryDTO.InquiryTypeName,
                        InquiryTypeID = inquiryDTO.InquiryTypeID,
                        InquiryDate = inquiryDTO.InquiryDate,
                        Comment = inquiryDTO.Comment
                    }));
                }
            }
        }
    }
}
