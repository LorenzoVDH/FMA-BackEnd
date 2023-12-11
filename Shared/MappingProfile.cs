using AutoMapper;
using FleetManager.EntityFrameworkDAL.Models.Entities;
using FleetManager.Shared.DTOs.DriverDTOs;
using FleetManager.Shared.DTOs.VehicleDTOs;
using FleetManager.DapperDAL.Models;
using FleetManager.Shared.DTOs.LicensePlateDTOs;
using FleetManager.Shared.DTOs.MaintenanceDTOs;
using FleetManager.Shared.DTOs.FuelCardDTOs;
using FleetManager.Shared.DTOs.InquiryDTOs;

namespace Shared;

public class Profiles : Profile {
    public Profiles() {
        CreateMap<DriverSimplifiedModel, DriverSimplifiedDTO>().ReverseMap();
        CreateMap<LicensePlate, LicensePlateDTO>().ReverseMap();
        CreateMap<LicensePlateModel, LicensePlateDTO>().ReverseMap();
        CreateMap<Driver, DriverCreateDTO>().ReverseMap();
        CreateMap<Vehicle, VehicleSimplifiedDTO>()
            .ForMember(dto => dto.CurrentLicensePlateNumber,
                              opt => opt.MapFrom(entity => entity.LicensePlates.FirstOrDefault(
                              lp => DateTime.Today >= lp.ValidityStartDate && (DateTime.Today <= lp.ValidityEndDate || lp.ValidityEndDate == null)).LicensePlateNumber))
            .ReverseMap();
        CreateMap<VehicleSimplifiedModel, VehicleSimplifiedDTO>().ReverseMap();
        CreateMap<Driver, DriverReadDTO>()
            //Mapping from the Entity's DriverVehicles to the DTO's Vehicles 
            .ForMember(dto => dto.Vehicles, opt => opt.MapFrom(entity => entity.DriverVehicles.Select(dv => dv.Vehicle)))
            .ReverseMap();
        CreateMap<VehicleOverviewModel, VehicleOverviewReadDTO>().ReverseMap();
        CreateMap<VehicleQuarterlyReportModel, VehicleQuarterlyReportDTO>().ReverseMap();
        CreateMap<VehicleModel, VehicleDTO>().ReverseMap();
        CreateMap<VehicleTypeModel, VehicleTypeDTO>().ReverseMap();
        CreateMap<MaintenanceModel, MaintenanceReadDTO>().ReverseMap();
        CreateMap<MaintenanceTaskModel, MaintenanceTaskDTO>().ReverseMap();
        CreateMap<FuelCardModel, FuelCardDTO>().ReverseMap();
        CreateMap<InquiryModel, InquiryDTO>().ReverseMap(); 
        CreateMap<InquiryTypeModel, InquiryTypeDTO>().ReverseMap(); 
        CreateMap<InquiryModel, InquiryCreateDTO>().ReverseMap();
        CreateMap<InquiryModel, InquiryOverviewReadDTO>()
            .ForMember(dto => dto.DriverFullName, opt => opt.MapFrom(model => model.DriverFirstName + " " + model.DriverLastName))
            .ReverseMap(); 
        CreateMap<Login, DriverLoginDTO>().ReverseMap(); 
    }
}
