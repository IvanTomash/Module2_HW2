using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_2
{
    internal class App
    {
        private readonly CustomerService _customerService;

        public App(CustomerService customerService) 
        { 
            _customerService = customerService;
        }

        public void Run()
        {
            Product[] assortment =
            {
            new Product("Холодильник INTERLUX", 8777), new Product("Мережевий фільтр Gembird", 259),
            new Product("Asus PCI-Ex GeForce RTX 3060", 14399), new Product("Миша Razer DeathAdder Essential", 999),
            new Product("Logitech WebCam C270", 1399), new Product("PlayStation 5", 22699),
            new Product("Valve Steam Deck", 26999), new Product("Nintendo Switch OLED", 19999),
            new Product("Клейка стрічка Buromax", 79), new Product("Бренді Одеський", 199),
            new Product("Кавомашина KRUPS Essential", 14399), new Product("Сушарка для овочів і фруктів WetAir ", 8499),
            new Product("Бойлер ATLANTIC OPRO Sample R 80", 4889), new Product("Ноутбук Lenovo IdeaPad Gaming 3 16IAH7", 54999),
            new Product("ASUS VivoBook 15", 34591), new Product("Вентилятор RZTK Tower M36", 1799),
            new Product("Комплект лотків для пастили WetAir", 500), new Product("Apple iPhone 14 Pro", 54999),
            new Product("Samsung Galaxy Flip 4", 29999), new Product(" Samsung Galaxy A04", 5299),
            new Product("Навушники Samsung Galaxy Buds2 Pro", 5999), new Product("Apple iPhone EarPods with Mic", 999),
            };

            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                _customerService.ShoppingCart.AddProduct(assortment[rand.Next(0, assortment.Length)]);
            }

            _customerService.MakePurchase("user2004@gmail.com");            
            File.WriteAllText("log.txt", Logger.Instance.AllLogs);
        }
    }
}
