using FleetManager.MAUIFront.MVVM.DTOs;
using FleetManager.MAUIFront.MVVM.Models;
using FleetManager.MAUIFront.Services;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FleetManager.MAUIFront.MVVM.ViewModels;
public class MyFuelCardViewModel {
    private FuelCardModel _fuelCard { get; set; }
    public FuelCardModel FuelCard { get; set; }

    public MyFuelCardViewModel() {
        Task.Run(() => SetFuelCardData()).Wait();
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    private async Task SetFuelCardData() {
        if (Int32.TryParse(await SecureStorage.GetAsync("driverID"), out int driverId)) {
            FuelCardDTO dto = await APIReadService.GetFuelCardByDriverIDAsync(driverId);
            
            if (dto != null) { 
                FuelCard = new FuelCardModel() {
                    Cardnumber = dto.Cardnumber,
                    ExtraServices = dto.ExtraServices,
                    ValidityEndDate = dto.ValidityEndDate,
                    FuelType = dto.FuelType
                };
            }
        }
    }
}
