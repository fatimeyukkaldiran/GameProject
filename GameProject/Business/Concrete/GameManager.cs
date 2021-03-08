using GameProject.Business.Abstract;
using GameProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business.Concrete
{
    public class GameManager : IGameService
    {
        List<Game> games;

        public GameManager()
        {
            games = new List<Game>();
        }

        public void Add(Game game)
        {
            games.Add(game);
            Console.WriteLine("Game is added");
        }

        public void Delete(Game game)
        {
            games.Remove(game);
            Console.WriteLine("Game is deleted");
        }

        public void Update(Gamer game)
        {
            Console.WriteLine("Game is updated");
        }
    }
}
