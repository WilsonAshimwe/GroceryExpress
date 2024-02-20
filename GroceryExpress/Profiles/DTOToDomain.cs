using AutoMapper;
using GroceryExpress.API.DTO.BasketItems;
using GroceryExpress.API.DTO.Baskets;
using GroceryExpress.API.DTO.Items;
using GroceryExpress.API.DTO.Orders;
using GroceryExpress.DOMAIN.Entities;

namespace GroceryExpress.API.Profiles
{
    public class DTOToDomain : Profile
    {
        public DTOToDomain()
        {

            CreateMap<CreateItemDTO, Item>();
            CreateMap<CreateItemOrderDTO, ItemOrder>();
            CreateMap<CreateBasketItemsDTO, BasketItem>();
            CreateMap<ShowBasketDTO, Basket>();
            CreateMap<ShowBasketItemDTO, BasketItem>();
            CreateMap<CreateBasketItemsDTO, BasketItem>();
            CreateMap<CreateBasketItemDTO, BasketItem>();




        }
    }
}
