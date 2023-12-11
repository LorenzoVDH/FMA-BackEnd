using FleetManager.MAUIFront.MVVM.DTOs;
using FleetManager.MAUIFront.MVVM.Models;
using FleetManager.MAUIFront.Services;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace FleetManager.MAUIFront.MVVM.ViewModels;
public class MyInfoViewModel : INotifyPropertyChanged {
    private DriverModel _driver;
    public DriverModel Driver {
        get => _driver;
        set {
            if (value != _driver) {
                _driver = value;
                OnPropertyChanged();
            }
        }
    }

    public MyInfoViewModel() {
        Task.Run(() => SetUserData()).Wait(); 
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    private async Task SetUserData() {
        if (Int32.TryParse(await SecureStorage.GetAsync("driverID"), out int driverId)) {
            DriverDTO dto = await APIReadService.GetDriverDataAsync(driverId);

            if (dto != null) {
                DriverModel model = new() {
                    DateOfBirth = dto.DateOfBirth,
                    FullAddress = $"{dto.AddressPostalCode} {dto.AddressCity} {dto.AddressStreet} {dto.AddressHouseNumber}",
                    FullName = $"{dto.FirstName} {dto.LastName}",
                    License = $"{dto.LicenseType}",
                    NationalRegistrationNumber = dto.NationalRegistrationNumber
                };

                Driver = model;

            } else {
                throw new Exception("User data could not be found!");
            }
        } else {
            throw new Exception("User driver ID key could not be found!");
        }
    }


    public void Test() {
        Debug.WriteLine(this.Driver.License);
        Debug.WriteLine(this.Driver.DateOfBirth);
        Debug.WriteLine(this.Driver.FullAddress);
        Debug.WriteLine(this.Driver.FullName);
        Debug.WriteLine(this.Driver.NationalRegistrationNumber);
    }
}
