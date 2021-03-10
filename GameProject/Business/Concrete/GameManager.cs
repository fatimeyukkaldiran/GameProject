using GameProject.Business.Abstract;
using GameProject.DataAccess.Abstract;
using GameProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business.Concrete
{
    public class GameManager : IGameService
    {
        IGameDal _gameDal;

        public GameManager(IGameDal gameDal)
        {
            _gameDal = gameDal;
        }

        public void Add(Game game)
        {
            _gameDal.Add(game);
        }

        public void Delete(Game game)
        {
            _gameDal.Delete(game);
        }

        public List<Game> GetAll()
        {
          return  _gameDal.GetAll();
        }

        public List<Game> GetAllByCampaignId(int campaignId)
        {
            return _gameDal.GetAllByCampaignId(campaignId);
        }

        public void Update(Game game)
        {
            _gameDal.Update(game);
        }
    }
}
