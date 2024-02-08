using AutoMapper;
using GroceryExpress.API.DTO.Addresses;
using GroceryExpress.API.DTO.Items;
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
            CreateMap<Item, ShowItemDTO>()



                ;

        }
    }
}
