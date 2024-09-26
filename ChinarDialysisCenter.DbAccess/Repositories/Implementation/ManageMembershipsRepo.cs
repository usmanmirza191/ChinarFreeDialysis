using ChinarDialysisCenter.Domain;
using System.Data.SqlClient;
using Dapper;
using System.Data;

namespace ChinarDialysisCenter.DbAccess.Repositories.Implementation
{
    public class ManageMembershipsRepo : IManageMembershipsRepo
    {
        public async Task<List<Membership>> GetMemberships()
        {
            List<Membership> lstMembers;
            using (var connection = new SqlConnection(DBHelper.GetConnectionString()))
            {
                var result = await connection.QueryAsync<Membership>("usp_tbl_membersSelect", commandType: System.Data.CommandType.StoredProcedure);
                lstMembers = result.ToList();
            }
            return lstMembers;
        }
        public async Task<bool> AddMembership(Membership membership)
        {
            bool result = false;
            string insertQuery = "usp_tbl_membersInsert";
            using (var connection = new SqlConnection(DBHelper.GetConnectionString()))
            {
                result = await connection.ExecuteScalarAsync<int>(insertQuery, membership, commandType: CommandType.StoredProcedure) > 0 ? true : false;
            }
            return result;
        }
        public async Task<bool> UpdateMembership(Membership membership)
        {
            bool result = false;
            string updateQuery = $@"usp_tbl_membersUpdate";
            using (var connection = new SqlConnection(DBHelper.GetConnectionString()))
            {
                result = await connection.ExecuteScalarAsync<int>(updateQuery, membership, commandType: CommandType.StoredProcedure) > 0 ? true : false;
            }
            return result;
        }
        public async Task<bool> DeleteMembership(Membership membership)
        {
            bool result = false;
            string deleteQuery = $@"usp_tbl_membersDelete";
            using (var connection = new SqlConnection(DBHelper.GetConnectionString()))
            {
                result = await connection.ExecuteScalarAsync<int>(deleteQuery, new {Id = membership.Id }, commandType: CommandType.StoredProcedure) > 0 ? true : false;
            }
            return result;
        }
    }
}
