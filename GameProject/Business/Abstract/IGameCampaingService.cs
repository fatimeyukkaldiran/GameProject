using GameProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business.Abstract
{
   public interface IGameCampaingService
    {
        void Add(Campaign campaign);
        void Delete(Campaign campaign);
        void Update(Campaign campaign);
    }
}
