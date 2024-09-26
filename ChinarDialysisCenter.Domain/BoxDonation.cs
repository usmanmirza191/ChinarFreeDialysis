using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinarDialysisCenter.Domain
{
    public class BoxDonation
    {
        public int Id { get; set; }
        public int BoxId { get; set; }
        public decimal Amount {  get; set; }    
        public DateTime CollectionDate { get; set; }
        public int CollectedBy { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
    public class BoxDonationView : BoxDonation
    {
        public int BoxName { get; set; }
        public int CollectedByName { get; set; }
        public int CreatedByName { get; set; }
        public int UpdatedByName { get; set; }
    }
}
