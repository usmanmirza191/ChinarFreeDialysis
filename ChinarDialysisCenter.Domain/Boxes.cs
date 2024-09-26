using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinarDialysisCenter.Domain
{
    public class Boxes
    {
        public int Id { get; set; } 
        public string? BoxName { get; set; }
        public string? BoxNo { get; set; }
        public string? Location {  get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }

    }
    public class BoxesView : Boxes
    {
        public string CreatedByName { get; set; }
        public string UpdatedByName { get; set; }
    }
}
