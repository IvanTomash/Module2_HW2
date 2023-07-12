using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_2
{
    internal class CustomerService
    {
        private ShoppingCart _shoppingCart;
        public ShoppingCart ShoppingCart { get { return _shoppingCart; } }

        private NotificationSystem _notificator;

        public CustomerService(ShoppingCart shoppingCart, NotificationSystem notificator)
        {
            _shoppingCart = shoppingCart;
            _notificator = notificator;
        }

        public void MakePurchase(string phoneOrEmail)
        {
            NotifyType type;            

            if (phoneOrEmail.Contains('@'))
            {
                type = NotifyType.Email;
            }
            else
            {
                type= NotifyType.Phone;
            }

            string buf;
            if (string.IsNullOrEmpty(_shoppingCart.ProductList()))
            {
                buf = $"Shopping cart is empty.";
                _notificator.Notify(type, buf, phoneOrEmail);
                return;
            }
            
            string id = Guid.NewGuid().ToString();
            buf = $"You have made a purchase: {id}\nYou have bought:\n{_shoppingCart.ProductList()}Total price: {_shoppingCart.TotalPrice}";
            _shoppingCart.Clear();
            _notificator.Notify(type, buf, phoneOrEmail);
        }
    }
}
