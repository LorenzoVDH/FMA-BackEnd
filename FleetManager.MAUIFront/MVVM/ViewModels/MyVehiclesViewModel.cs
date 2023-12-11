using FleetManager.MAUIFront.MVVM.DTOs;
using FleetManager.MAUIFront.MVVM.Models;
using FleetManager.MAUIFront.MVVM.Views.Models;
using FleetManager.MAUIFront.Services;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FleetManager.MAUIFront.MVVM.ViewModels;
public class MyVehiclesViewModel : INotifyPropertyChanged {
    private List<ExpandableViewItem> _vehicles;
    public List<ExpandableViewItem> Vehicles {
        get => _vehicles;
        set {
            if (_vehicles != value) {
                _vehicles = value;
                OnPropertyChanged(); 
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public MyVehiclesViewModel() {
        Task.Run(() => SetVehicleData()).Wait();
    }

    public async Task SetVehicleData() {
        if (Int32.TryParse(await SecureStorage.GetAsync("driverID"), out int driverId)) {
            Vehicles = new List<ExpandableViewItem>();

            List<VehicleDTO> vehicleDTOs = await APIReadService.GetVehiclesOfDriverAsync(driverId);
            if (vehicleDTOs != null && vehicleDTOs.Count > 0) { 
                foreach (VehicleDTO vehicleDTO in vehicleDTOs) {
                    List<DriverDTO> driversOfVehicleDTOs = await APIReadService.GetDriversOfVehicleAsync(vehicleDTO.ID);

                    Vehicles.Add(
                        new ExpandableViewItem(
                            new VehicleModel() {
                                Name = vehicleDTO.Name,
                                ChassisNumber = vehicleDTO.ChassisNumber,
                                FuelType = vehicleDTO.FuelType,
                                RegistrationDate = vehicleDTO.RegistrationDate,
                                LeasingStartDate = vehicleDTO.LeasingStartDate,
                                LeasingEndDate = vehicleDTO.LeasingEndDate,
                                Drivers = driversOfVehicleDTOs.Select(d => d.FirstName + " " + d.LastName).ToList(),
                            }
                        )
                    );
                }
            }
        }
    }
}
