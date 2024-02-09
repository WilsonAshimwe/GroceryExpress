using AutoMapper;
using GroceryExpress.API.DTO.Items;
using GroceryExpress.DOMAIN.Entities;

namespace GroceryExpress.API.Profiles
{
    public class DTOToDomain : Profile
    {
        public DTOToDomain()
        {

            CreateMap<CreateItemDTO, Item>();

        }
    }
}
