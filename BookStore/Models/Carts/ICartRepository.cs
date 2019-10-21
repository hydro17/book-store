﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models.Carts
{
    public interface ICartRepository
    {
        IEnumerable<CartItem> GetAllCartItemsSorteAscBy<ReturnTtype>(Func<CartItem, ReturnTtype> sortBy);
        void AddToCart(int id);
        bool RemoveFromCart(int id);
        void ClearCart();

        List<int> GetProductIdList();
    }
}
