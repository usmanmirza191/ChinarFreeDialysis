using ChinarDialysisCenter.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinarDialysisCenter.Business.Interfaces
{
    public interface IManageDonations
    {
        Task<List<MembersDonationView>> GetMembersDonations(MembersDonation donation);
        Task<bool> SaveMembersDonation(MembersDonation donation);
        Task<bool> UpdateMembersDonation(MembersDonation donation);
        Task<bool> DeleteMembersDonation(MembersDonation donation);
        Task<List<BoxDonationView>> GetBoxDonations(BoxDonation donation);
        Task<bool> SaveBoxDonation(BoxDonation donation);
        Task<bool> UpdateBoxDonation(BoxDonation donation);
        Task<bool> DeleteBoxDonation(BoxDonation donation);
    }
}
