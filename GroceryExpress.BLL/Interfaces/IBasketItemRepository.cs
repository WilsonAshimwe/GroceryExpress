﻿using GroceryExpress.DOMAIN.Entities;

namespace GroceryExpress.BLL.Interfaces
{
    public interface IBasketItemRepository
    {
        Task<BasketItem?> Find(int basketId, int ItemId);
        Task<List<BasketItem>> FindAll();

        Task<BasketItem> Add(BasketItem basketItem);

        Task<BasketItem> Update(BasketItem basketItem);
        Task Delete(BasketItem basketItem);
    }
}
