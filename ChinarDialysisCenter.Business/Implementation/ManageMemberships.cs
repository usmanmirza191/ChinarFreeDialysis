using ChinarDialysisCenter.Business.Interfaces;
using ChinarDialysisCenter.DbAccess;
using ChinarDialysisCenter.DbAccess.Repositories;
using ChinarDialysisCenter.Domain;
using System.Data.SqlClient;

namespace ChinarDialysisCenter.Business.Implementation
{
    public class ManageMemberships : IManageMemberships
    {
        private readonly IManageMembershipsRepo memberShipRepo;
        public ManageMemberships(IManageMembershipsRepo memberShipRepo)
        {
            this.memberShipRepo = memberShipRepo;   
        }
        public async Task<List<Membership>> GetMemberships()
        {
            return await memberShipRepo.GetMemberships();
        }
        public async Task<bool> AddMemberShip(Membership membership)
        {
            return await memberShipRepo.AddMembership(membership);
        }
        public async Task<bool> UpdateMemberShip(Membership membership)
        {
            return await memberShipRepo.UpdateMembership(membership);
        }
        public async Task<bool> DeleteMembership(Membership membership)
        {
            return await memberShipRepo.DeleteMembership(membership);
        }
    }
}
