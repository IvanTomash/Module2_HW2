using System;

namespace Homework_2_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var app = new App(new CustomerService(new ShoppingCart(), new NotificationSystem(Logger.Instance)));
            app.Run();
        }
    }
}