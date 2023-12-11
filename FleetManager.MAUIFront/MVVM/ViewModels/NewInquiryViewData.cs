using FleetManager.MAUIFront.MVVM.DTOs;
using FleetManager.MAUIFront.MVVM.Models;
using FleetManager.MAUIFront.Services;

namespace FleetManager.MAUIFront.MVVM.ViewModels;
public class NewInquiryViewData
{
    public List<InquiryItemSelectionModel> SelectableInquiryTypes { get; set; }
    public List<ItemSelectionModel> SelectableVehicles { get; set; }
    public string Title { get; set; }
    public Color ColourPrimary { get; set; }
    public Color ColourSecondary { get; set; }
    public Color ColourTertiary { get; set; }

    //public NewInquiryViewData() {
    //    Task.Run(() => SetInquiryFormDataAsync()).Wait();
    //}

    //private async Task SetInquiryFormDataAsync() {
    //    if (Int32.TryParse(await SecureStorage.GetAsync("driverID"), out int driverId)) {
    //        List<VehicleDTO> vehicleDTOs = await APIReadService.GetVehiclesOfDriverAsync(driverId);
    //        if (vehicleDTOs != null) { 
    //            SelectableVehicles = vehicleDTOs.Select(v => new ItemSelectionModel(v.ID, v.Name)).ToList();
    //        }
    //    }
    //}
}
