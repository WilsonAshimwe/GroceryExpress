using AutoMapper;
using GroceryExpress.API.DTO.Addresses;
using GroceryExpress.API.DTO.Baskets;
using GroceryExpress.API.DTO.BasketItems;

using GroceryExpress.API.DTO.Items;
using GroceryExpress.API.DTO.Orders;
using GroceryExpress.API.DTO.Users;
using GroceryExpress.DOMAIN.Entities;

namespace GroceryExpress.API.Profiles
{
    public class DomainToDTO : Profile
    {
        public DomainToDTO()
        {
            CreateMap<User, ShowUserDTO>();
            CreateMap<User, ShowUserWithoutAddressDTO>();
            CreateMap<Address, ShowAddressDTO>();
            CreateMap<Item, ShowItemDTO>();
            CreateMap<Order, OrderDTO>();
            CreateMap<ItemOrder, ShowItemOrderDTO>();
            CreateMap<Order, ShowOrderDTO>();
            CreateMap<Basket, BasketDTO>();
            CreateMap<Basket, ShowBasketDTO>();
            CreateMap<BasketItem, ShowBasketItemsDTO>();
            CreateMap<BasketItem, ShowBasketItemDTO>();






        }
    }
}
