using ChinarDialysisCenter.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinarDialysisCenter.DbAccess.Repositories
{
    public interface IManageMembershipsRepo
    {
        Task<List<Membership>> GetMemberships();
        Task<bool> AddMembership(Membership membership);
        Task<bool> UpdateMembership(Membership membership);
        Task<bool> DeleteMembership(Membership membership);
    }
}
