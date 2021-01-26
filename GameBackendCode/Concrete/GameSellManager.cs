using GameBackendCode.Entities;
using OyunKayitSistemi.Abstract;
using OyunKayitSistemi.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunKayitSistemi.Concrete
{
    public class GameSellManager : IGameSellManager
    {
        private Game _game;
        public GameSellManager(Game game)
        {
            _game = game;
        }
        public void Sell(Customer customer)
        {
            Console.WriteLine("{0} adlı kullanıcı {1} oyununu {2}TL'ye satın aldı",customer.FirstName,_game.Name,_game.UnitPrice);
        }
    }
}
