using ChinarDialysisCenter.Business.Interfaces;
using ChinarDialysisCenter.Domain;
using Microsoft.AspNetCore.Mvc;

namespace ChinarDialysisCenter.Server.Controllers
{
    [ApiController]
    public class BoxController : ControllerBase
    {
        private readonly IManageBox manageBoxes;
        public BoxController(IManageBox manageBoxes)
        {
            this.manageBoxes = manageBoxes;
        }
        [HttpGet]
        [Route("api/GetBoxes")]
        public IActionResult GetBoxes(Boxes box)
        {
            return Ok(manageBoxes.GetBoxes(box));
        }
        [HttpPost]
        [Route("api/SaveBox")]
        public IActionResult SaveBox(Boxes box)
        {
            return Ok(manageBoxes.SaveBox(box));
        }
        [HttpPost]
        [Route("api/UpdateBox")]
        public IActionResult UpdateMembersDonation(Boxes box)
        {
            return Ok(manageBoxes.UpdateBox(box));
        }
        [HttpPost]
        [Route("api/DeleteBox")]
        public IActionResult DeleteMembersDonation(Boxes box)
        {
            return Ok(manageBoxes.DeleteBox(box));
        }
    }
}
