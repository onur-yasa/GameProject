using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GamerManager : IGamerService
    {
        private IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu silindi : " + gamer.FirstName);
        }

        public void SignUp(Gamer gamer)
        {
            if(_gamerCheckService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine("Oyuncu kaydoldu : " + gamer.FirstName);
            }
            else
            {
                throw new Exception("Oyuncu doğrulanamadı");
            }
            
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu güncellendi : " + gamer.FirstName);
        }
    }
}
