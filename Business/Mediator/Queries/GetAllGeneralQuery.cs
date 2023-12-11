using MediatR;

namespace FleetManager.BLL.Mediator.Queries;
public class GetAllGeneralQuery<T> : IRequest<List<T>> {
    public int PageIndex { get; set; }
    public int PageLength { get; set; }
}
