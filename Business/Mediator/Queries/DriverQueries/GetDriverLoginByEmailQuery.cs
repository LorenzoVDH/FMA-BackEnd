using FleetManager.EntityFrameworkDAL.Models.Entities;
using FleetManager.EntityFrameworkDAL.Repositories.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManager.BLL.Mediator.Queries.DriverQueries {
    public class GetDriverLoginByEmailQuery : IRequest<Login> {
        public string Email { get; set; }
        public GetDriverLoginByEmailQuery(string email) {
            Email = email;
        }
    }

    public class GetDriverLoginByEmailHandler : IRequestHandler<GetDriverLoginByEmailQuery, Login> {
        private readonly IDriverRepository _driverRepository;
        public GetDriverLoginByEmailHandler(IDriverRepository driverRepository) {
            _driverRepository = driverRepository;
        }
        public async Task<Login> Handle(GetDriverLoginByEmailQuery query, CancellationToken cancellationToken) {
            return await _driverRepository.GetDriverLoginByEmailAsync(query.Email);
        }
    }
}
