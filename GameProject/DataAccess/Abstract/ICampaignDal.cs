using GameProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.DataAccess.Abstract
{
   public interface ICampaignDal
    {
        void Add(Campaign campaign);
        void Delete(Campaign campaign);
        void Update(Campaign campaign);
        List<Campaign> GetAll();
       
    }
}
