using ChinarDialysisCenter.Business.Interfaces;
using ChinarDialysisCenter.DbAccess;
using ChinarDialysisCenter.DbAccess.Repositories;
using ChinarDialysisCenter.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinarDialysisCenter.Business.Implementation
{
    public class ManageDonations : IManageDonations
    {
        private readonly IManageDonationsRepo donationRepo;
        public ManageDonations(IManageDonationsRepo donationRepo)
        {
            this.donationRepo = donationRepo;
        }
        public async Task<List<MembersDonationView>> GetMembersDonations(MembersDonation donation)
        {
            return await donationRepo.GetMembersDonations(donation);
        }
        public async Task<bool> SaveMembersDonation(MembersDonation donation)
        {
            return await donationRepo.SaveMembersDonation(donation);
        }
        public async Task<bool> UpdateMembersDonation(MembersDonation donation)
        {
            return await donationRepo.UpdateMembersDonation(donation);
        }
        public async Task<bool> DeleteMembersDonation(MembersDonation donation)
        {
            return await donationRepo.DeleteMembersDonation(donation);
        }
        public async Task<List<BoxDonationView>> GetBoxDonations(BoxDonation donation)
        {
            return await donationRepo.GetBoxDonations(donation);
        }
        public async Task<bool> SaveBoxDonation(BoxDonation donation)
        {
            return await donationRepo.SaveBoxDonation(donation);
        }
        public async Task<bool> UpdateBoxDonation(BoxDonation donation)
        {
            return await donationRepo.UpdateBoxDonation(donation);
        }
        public async Task<bool> DeleteBoxDonation(BoxDonation donation)
        {
            return await donationRepo.DeleteBoxDonation(donation);
        }
    }
}
