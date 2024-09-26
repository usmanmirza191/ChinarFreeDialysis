using ChinarDialysisCenter.Domain;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinarDialysisCenter.DbAccess.Repositories.Implementation
{
    public class ManageBoxesRepo : IManageBoxesRepo
    {
        public async Task<List<BoxesView>> GetBoxes(Boxes box)
        {
            List<BoxesView> lstMembers;
            using (var connection = new SqlConnection(DBHelper.GetConnectionString()))
            {
                var result = await connection.QueryAsync<BoxesView>("usp_tbl_boxesSelect", commandType: System.Data.CommandType.StoredProcedure);
                lstMembers = result.ToList();
            }
            return lstMembers;
        }
        public async Task<bool> SaveBox(Boxes box)
        {
            bool result = false;
            string insertQuery = "usp_tbl_boxesInsert";
            using (var connection = new SqlConnection(DBHelper.GetConnectionString()))
            {
                result = await connection.ExecuteScalarAsync<int>(insertQuery, box, commandType: CommandType.StoredProcedure) > 0 ? true : false;
            }
            return result;
        }
        public async Task<bool> UpdateBox(Boxes box)
        {
            bool result = false;
            string insertQuery = "usp_tbl_boxesUpdate";
            using (var connection = new SqlConnection(DBHelper.GetConnectionString()))
            {
                result = await connection.ExecuteScalarAsync<int>(insertQuery, box, commandType: CommandType.StoredProcedure) > 0 ? true : false;
            }
            return result;
        }
        public async Task<bool> DeleteBox(Boxes box)
        {
            bool result = false;
            string insertQuery = "usp_tbl_boxesDelete";
            using (var connection = new SqlConnection(DBHelper.GetConnectionString()))
            {
                result = await connection.ExecuteScalarAsync<int>(insertQuery, box, commandType: CommandType.StoredProcedure) > 0 ? true : false;
            }
            return result;
        }
    }
}
