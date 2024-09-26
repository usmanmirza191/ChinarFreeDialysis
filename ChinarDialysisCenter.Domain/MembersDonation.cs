using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinarDialysisCenter.Domain
{
    public class MembersDonation
    {
        public int Id { get; set; }
        public int DonatedBy { get; set; }
        public int ReceivedBy { get; set; }
        public DateTime DonationDate { get; set; }
        public decimal Amount {  get; set; }
        public int DonationSource {  get; set; }
        public string? DonationReceipt{ get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }

    }
    public class MembersDonationView : MembersDonation
    {
        public string DonatedByName { get; set; }
        public string ReceivedByName { get; set; }
        public string DonationSourceName { get; set; }
        public string CreatedByName { get; set; }
        public string UpdatedByName { get; set; }
    }
}
