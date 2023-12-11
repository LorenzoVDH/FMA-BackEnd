using MediatR;

namespace FleetManager.BLL.Mediator.Queries;
public class GetByIDGeneralQuery<T> : IRequest<T> {
    public int ID { get; set; } 
    public GetByIDGeneralQuery(int id) {
        ID = id;
    }
}
