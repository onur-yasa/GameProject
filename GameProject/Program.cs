using GameProject.Adapter;
using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Oyuncu eklenmesi
            Gamer gamer1 = new Gamer() {Id=1,FirstName = "Ahmet Efecan", LastName="Bayat",
            DateOfBirth = new DateTime(1997,1,1), NationalityId="TcKimlikNo giriniz"};
                   
            GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            gamerManager.SignUp(gamer1);

            // Oyun eklenmesi
            Game game1 = new Game() { Id = 1, Name = "CSGO", Price = 50 };

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);           

            //Kampanya eklenmesi
            Campaign campaign1 = new Campaign() {Id=1,Name="Black Friday",DiscountRate=30};

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);

            // Satış yapılması
            SaleManager saleManager = new SaleManager();
            saleManager.Sale(game1, gamer1,campaign1);


        }
    }
}
