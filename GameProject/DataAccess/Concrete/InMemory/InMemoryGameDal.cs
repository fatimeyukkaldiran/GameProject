using GameProject.DataAccess.Abstract;
using GameProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameProject.DataAccess.Concrete.InMemory
{
    class InMemoryGameDal : IGameDal
    {
        List<Game> _games;
        public InMemoryGameDal()
        {
            _games = new List<Game> { 
            
                new Game{Id = 1,CampaignId = 2, Name= "MineCraft", Price = 141.25},
                new Game{Id = 2,CampaignId = 1, Name= "Minecraft Dungeons", Price = 56.25},
                new Game{Id = 3,CampaignId = 2, Name= "Undertale", Price = 28.75},
                new Game{Id = 4,CampaignId = 3, Name= "Among Us", Price = 35.00},

            };
        }
        public void Add(Game game)
        {
            _games.Add(game);
        }

        public void Delete(Game game)
        {
            Game deleteToGame = _games.SingleOrDefault(game => game.Id == game.Id);
            _games.Remove(deleteToGame);
        }

        public List<Game> GetAll()
        {
            return _games;
        }

        public List<Game> GetAllByCampaignId(int campaignId)
        {
            return _games.Where(g => g.CampaignId == campaignId).ToList();
        }

        public void Update(Game game)
        {
            Game updateToGame = _games.SingleOrDefault(game => game.Id == game.Id);
            updateToGame.Id = game.Id;
            updateToGame.CampaignId = game.CampaignId;
            updateToGame.Name = game.Name;
            updateToGame.Price = game.Price;
            
        }
    }
}