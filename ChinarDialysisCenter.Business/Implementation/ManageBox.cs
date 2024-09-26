using ChinarDialysisCenter.Business.Interfaces;
using ChinarDialysisCenter.DbAccess.Repositories;
using ChinarDialysisCenter.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinarDialysisCenter.Business.Implementation
{
    public class ManageBox : IManageBox
    {
        private readonly IManageBoxesRepo boxRepo;
        public ManageBox(IManageBoxesRepo boxRepo)
        {
            this.boxRepo = boxRepo;
        }
        public async Task<List<BoxesView>> GetBoxes(Boxes box)
        {
            return await boxRepo.GetBoxes(box);
        }
        public async Task<bool> SaveBox(Boxes box)
        {
            return await boxRepo.SaveBox(box);
        }
        public async Task<bool> UpdateBox(Boxes box)
        {
            return await boxRepo.UpdateBox(box);
        }
        public async Task<bool> DeleteBox(Boxes box)
        {
            return await boxRepo.DeleteBox(box);
        }
    }
}
