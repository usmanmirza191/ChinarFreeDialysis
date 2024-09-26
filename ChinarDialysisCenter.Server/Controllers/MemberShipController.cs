using ChinarDialysisCenter.Business.Interfaces;
using ChinarDialysisCenter.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;

namespace ChinarDialysisCenter.Server.Controllers
{
    [ApiController]
    
    public class MemberShipController : ControllerBase
    {
        private readonly IManageMemberships manageMemberships;
        public MemberShipController(IManageMemberships manageMemberships)
        {
            this.manageMemberships = manageMemberships;
        }
        [Route("api/GetMembers")]
        [HttpGet]
        // GET: MemberShipController
        public async Task<IActionResult> GetMembers()
        {
            var result = await manageMemberships.GetMemberships();
            return Ok(result);
        }
        [Route("api/AddMember")]
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> AddMember(Membership member)
        {
            // Uncomment after implementing login mechanisim
            //member.CreatedBy = loggedinuser.Id;
            member.IsActive = true;
            bool result = await manageMemberships.AddMemberShip(member);
            if (!result)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Something Went Wrong");
            }
            return Ok(result);
        }
        [Route("api/UpdateMember")]
        [HttpPut]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateMember(Membership member)
        {
            // Uncomment after implementing login mechanisim
            //member.CreatedBy = loggedinuser.Id;
            member.IsActive = true;
            bool result = await manageMemberships.UpdateMemberShip(member);
            if (!result)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Something Went Wrong");
            }
            return Ok(result);
        }


    }
}
