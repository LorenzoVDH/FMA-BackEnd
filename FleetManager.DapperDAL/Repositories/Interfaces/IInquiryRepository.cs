using FleetManager.DapperDAL.Models;

namespace FleetManager.DapperDAL.Repositories.Interfaces;
public interface IInquiryRepository {
    Task<List<InquiryModel>> GetInquiriesWithPaginationAsync(int pageIndex, int pageLength);
    Task<List<InquiryModel>> GetInquiriesByDriverIDAsync(int driverID);
    Task<List<InquiryTypeModel>> GetInquiryTypesByCategoryNameAsync(string categoryName);
    Task<int> GetInquiryCountAsync();
    Task CreateAsync(InquiryModel inquiry);

    Task UpdateAsync(InquiryModel inquiry); 

}
