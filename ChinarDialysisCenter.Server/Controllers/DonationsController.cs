using ChinarDialysisCenter.Business.Interfaces;
using ChinarDialysisCenter.Domain;
using Microsoft.AspNetCore.Mvc;

namespace ChinarDialysisCenter.Server.Controllers
{
    [ApiController]
    public class DonationsController : ControllerBase
    {
        private readonly IManageDonations manageDonation;
        public DonationsController(IManageDonations manageDonation)
        {
            this.manageDonation = manageDonation;
        }
        [HttpGet]
        [Route("api/MembersDonations")]
        public IActionResult MembersDonations(MembersDonation donation)
        {
            return Ok(manageDonation.GetMembersDonations(donation));
        }
        [HttpPost]
        [Route("api/SaveMembersDonation")]
        public IActionResult SaveMembersDonation(MembersDonation donation)
        {
            return Ok(manageDonation.SaveMembersDonation(donation));
        }
        [HttpPost]
        [Route("api/UpdateMembersDonation")]
        public IActionResult UpdateMembersDonation(MembersDonation donation)
        {
            return Ok(manageDonation.UpdateMembersDonation(donation));
        }
        [HttpPost]
        [Route("api/DeleteMembersDonation")]
        public IActionResult DeleteMembersDonation(MembersDonation donation)
        {
            return Ok(manageDonation.DeleteMembersDonation(donation));
        }
    }
}
