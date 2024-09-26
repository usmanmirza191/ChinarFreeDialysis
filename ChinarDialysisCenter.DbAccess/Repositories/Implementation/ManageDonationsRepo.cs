using ChinarDialysisCenter.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace ChinarDialysisCenter.DbAccess.Repositories.Implementation
{
    internal class ManageDonationsRepo : IManageDonationsRepo
    {
        #region MembersDonation
        public async Task<List<MembersDonationView>> GetMembersDonations(MembersDonation donation)
        {
            List<MembersDonationView> lstMembers;
            using (var connection = new SqlConnection(DBHelper.GetConnectionString()))
            {
                var result = await connection.QueryAsync<MembersDonationView>("usp_tbl_members_donationSelect", commandType: System.Data.CommandType.StoredProcedure);
                lstMembers = result.ToList();
            }
            return lstMembers;
        }
        public async Task<bool> SaveMembersDonation(MembersDonation donation)
        {
            bool result = false;
            string insertQuery = "usp_tbl_members_donationInsert";
            using (var connection = new SqlConnection(DBHelper.GetConnectionString()))
            {
                result = await connection.ExecuteScalarAsync<int>(insertQuery, donation, commandType: CommandType.StoredProcedure) > 0 ? true : false;
            }
            return result;
        }
        public async Task<bool> UpdateMembersDonation(MembersDonation donation)
        {
            bool result = false;
            string insertQuery = "usp_tbl_members_donationUpdate";
            using (var connection = new SqlConnection(DBHelper.GetConnectionString()))
            {
                result = await connection.ExecuteScalarAsync<int>(insertQuery, donation, commandType: CommandType.StoredProcedure) > 0 ? true : false;
            }
            return result;
        }
        public async Task<bool> DeleteMembersDonation(MembersDonation donation)
        {
            bool result = false;
            string insertQuery = "usp_tbl_members_donationDelete";
            using (var connection = new SqlConnection(DBHelper.GetConnectionString()))
            {
                result = await connection.ExecuteScalarAsync<int>(insertQuery, donation, commandType: CommandType.StoredProcedure) > 0 ? true : false;
            }
            return result;
        }
        #endregion
        #region BoxDonation
        public async Task<List<BoxDonationView>> GetBoxDonations(BoxDonation donation)
        {
            List<BoxDonationView> lstMembers;
            using (var connection = new SqlConnection(DBHelper.GetConnectionString()))
            {
                var result = await connection.QueryAsync<BoxDonationView>("usp_tbl_box_donationSelect", commandType: System.Data.CommandType.StoredProcedure);
                lstMembers = result.ToList();
            }
            return lstMembers;
        }
        public async Task<bool> SaveBoxDonation(BoxDonation donation)
        {
            bool result = false;
            string insertQuery = "usp_tbl_box_donationInsert";
            using (var connection = new SqlConnection(DBHelper.GetConnectionString()))
            {
                result = await connection.ExecuteScalarAsync<int>(insertQuery, donation, commandType: CommandType.StoredProcedure) > 0 ? true : false;
            }
            return result;
        }
        public async Task<bool> UpdateBoxDonation(BoxDonation donation)
        {
            bool result = false;
            string insertQuery = "usp_tbl_box_donationUpdate";
            using (var connection = new SqlConnection(DBHelper.GetConnectionString()))
            {
                result = await connection.ExecuteScalarAsync<int>(insertQuery, donation, commandType: CommandType.StoredProcedure) > 0 ? true : false;
            }
            return result;
        }
        public async Task<bool> DeleteBoxDonation(BoxDonation donation)
        {
            bool result = false;
            string insertQuery = "usp_tbl_box_donationDelete";
            using (var connection = new SqlConnection(DBHelper.GetConnectionString()))
            {
                result = await connection.ExecuteScalarAsync<int>(insertQuery, donation, commandType: CommandType.StoredProcedure) > 0 ? true : false;
            }
            return result;
        }
        #endregion
    }
}
