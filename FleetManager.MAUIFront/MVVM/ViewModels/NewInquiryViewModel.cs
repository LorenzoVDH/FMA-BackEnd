using FleetManager.MAUIFront.Enums;
using FleetManager.MAUIFront.Exceptions;
using FleetManager.MAUIFront.MVVM.Models;
using FleetManager.MAUIFront.Services;

using FleetManager.MAUIFront.MVVM.DTOs; 

namespace FleetManager.MAUIFront.MVVM.ViewModels;
public class NewInquiryViewModel {

    public InquiryModel Inquiry { get; set; } 

    public NewInquiryViewModel() {
        Inquiry = new InquiryModel() {
            PreferredDate = DateTime.Now,
            PreferredDateBackup = DateTime.Now.AddDays(4),
        };
    }

    public async Task TrySendInquiry(InquiryModel inquiry) {
        ValidateInquiry(inquiry);
        await APIWriteService.CreateInquiryAsync(new InquiryCreateDTO() {
            Comment = inquiry.Comment,
            DriverID = inquiry.DriverID,
            InquiryTypeID = inquiry.InquiryTypeID,
            PreferredDate = inquiry.PreferredDate,
            PreferredDateBackup = inquiry.PreferredDateBackup,
            VehicleID = inquiry.VehicleID
        }); 
    }

    public void ValidateInquiry(InquiryModel inquiry) {
        List<string> validationErrors = new();

        if (inquiry == null) {
            validationErrors.Add("No inquiry was provided.");
        }

        if (inquiry.PreferredDate != null && inquiry.PreferredDateBackup != null) {
            if (inquiry.PreferredDate <= DateTime.Today ||
            inquiry.PreferredDateBackup <= DateTime.Today) {
                validationErrors.Add("The preferred dates cannot be in the past or the same day."); 
            }
            if (inquiry.PreferredDateBackup < inquiry.PreferredDate) {
                validationErrors.Add("The second preferred date must be later than the first preferred date.");
            }
            if (inquiry.PreferredDate.Value.Date == inquiry.PreferredDateBackup.Value.Date) {
                validationErrors.Add("The preferred dates cannot be the same.");
            }
        }

        if (inquiry.InquiryDate < DateTime.Today) {
            validationErrors.Add("The inquiry cannot have been made before today.");
        }

        if (validationErrors.Count > 0) {
            throw new InquiryValidationException(validationErrors); 
        }
    }
}
