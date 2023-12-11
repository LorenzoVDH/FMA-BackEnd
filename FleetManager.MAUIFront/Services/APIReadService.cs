using FleetManager.MAUIFront.MVVM.DTOs;
using FleetManager.MAUIFront.MVVM.Models;
using System.Diagnostics;
using System.Net.Http.Json;

namespace FleetManager.MAUIFront.Services {
    public static class APIReadService {
        private static readonly string _baseURL = "http://10.0.2.2:7150/Read";
        public static async Task<List<DriverDTO>> GetDriversOfVehicleAsync(int vehicleID) {
            try { 
                using (var client = new HttpClient()) {
                    string URL = $"{_baseURL}/Vehicles/{vehicleID}/Drivers";

                    var response = await client.GetAsync(URL);
                    response.EnsureSuccessStatusCode();
                    var driversOfVehicleDTOs = await response.Content.ReadFromJsonAsync<List<DriverDTO>>();

                    return driversOfVehicleDTOs; 
                }
            } catch (Exception e) {
                Debug.WriteLine($"Request exception: {e.Message}");
                return null;
            }
        }

        public static async Task<LoginDTO> GetDriverLoginByEmailAsync(string email) {
            try {
                using (var client = new HttpClient()) {
                    string URL = $"{_baseURL}/Drivers/Login?email={email}";

                    var response = await client.GetAsync(URL);
                    response.EnsureSuccessStatusCode();
                    var loginDTO = await response.Content.ReadFromJsonAsync<LoginDTO>();

                    return loginDTO;
                }
            } catch (Exception e) {
                Debug.WriteLine($"Request exception: {e.Message}");
                return null;
            }
        }

        public static async Task<List<VehicleDTO>> GetVehiclesOfDriverAsync(int driverID) {
            //Add single action to backend instead of getting the Driver Data manually first 
            DriverDTO driverDTO = await GetDriverDataAsync(driverID);

            if (driverDTO == null) {
                throw new Exception("Driver not found.");
            }

            try {
                using (var client = new HttpClient()) {
                    List<VehicleDTO> vehicleDTOs = new List<VehicleDTO>();
                        
                    foreach(VehicleDTO vehicle in driverDTO.Vehicles) {
                        string URL = $"{_baseURL}/Vehicles/{vehicle.ID}";

                        var response = await client.GetAsync(URL);
                        response.EnsureSuccessStatusCode();
                        var vehicleDTO = await response.Content.ReadFromJsonAsync<VehicleDTO>();

                        vehicleDTOs.Add(vehicleDTO);
                    }

                    return vehicleDTOs;
                }
            } catch (Exception e) {
                Debug.WriteLine($"Request exception: {e.Message}");
                return null;
            }
        }

        public static async Task<DriverDTO> GetDriverDataAsync(int driverID) {
            string URL = $"{_baseURL}/Drivers/{driverID}";

            try {
                using (var client = new HttpClient()) {
                    var response = await client.GetAsync(URL);

                    response.EnsureSuccessStatusCode();
                    
                    var driverString = await response.Content.ReadAsStringAsync();
                    var driver = await response.Content.ReadFromJsonAsync<DriverDTO>();
                    return driver;
                }
            } catch (Exception e) {
                Debug.WriteLine($"Request exception: {e.Message}");
                return null;
            }
        }

        public static async Task<FuelCardDTO> GetFuelCardByDriverIDAsync(int driverID) {
            string URL = $"{_baseURL}/FuelCard/Driver/{driverID}";

            try {
                using (var client = new HttpClient()) {
                    var response = await client.GetAsync(URL);

                    response.EnsureSuccessStatusCode();

                    var fuelcards = await response.Content.ReadFromJsonAsync<List<FuelCardDTO>>();

                    return fuelcards.FirstOrDefault();
                }
            } catch (Exception e) {
                Debug.WriteLine($"Request exception: {e.Message}");
                return null; 
            }
        }

        public static async Task<List<InquiryDTO>> GetInquiriesByDriverIDAsync(int driverID) {
            string URL = $"{_baseURL}/Inquiry/Driver/{driverID}";

            try {
                using (var client = new HttpClient()) {
                    var response = await client.GetAsync(URL);

                    response.EnsureSuccessStatusCode();

                    var inquiries = await response.Content.ReadFromJsonAsync<List<InquiryDTO>>();

                    return inquiries;
                }
            } catch (Exception e) {
                Debug.WriteLine($"Request exception: {e.Message}");
                return null;
            }
        }

        public static async Task<List<InquiryTypeDTO>> GetInquiryTypesByCategoryName(string categoryName) {
            string URL = $"{_baseURL}/Inquiry/Types/{categoryName}";

            try {
                using (var client = new HttpClient()) {
                    var response = await client.GetAsync(URL);

                    response.EnsureSuccessStatusCode();

                    var inquiries = await response.Content.ReadFromJsonAsync<List<InquiryTypeDTO>>();

                    return inquiries;
                }
            } catch (Exception e) {
                Debug.WriteLine($"Request exception: {e.Message}");
                return null;
            }
        }
    }
}
