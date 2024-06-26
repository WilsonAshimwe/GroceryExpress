﻿using AutoMapper;
using GroceryExpress.API.DTO;
using GroceryExpress.API.DTO.Items;
using GroceryExpress.BLL.Services;
using GroceryExpress.Domain.Enums;
using GroceryExpress.DOMAIN.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace GroceryExpress.API.Controllers
{
    [Route("api/items")]
    [ApiController]
    public class ItemsController(ItemService _itemService, IMapper mapper) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetItems(GroceryCategory? searchCategory, string? searchBrand, string? searchName, string? sortProp, bool isDescending, int page = 1, int size = 50)
        {

            //var configuration = new MapperConfiguration(cfg => cfg.CreateMap<Item, ShowItemDTO>());

            var items = await _itemService.GetAll(searchCategory, searchBrand, searchName, sortProp, isDescending, page, size);
            var results = mapper.Map<List<Item>, List<ShowItemDTO>>(items);
            var total = await _itemService.Count(searchCategory, searchBrand);
            var maxPageNumber = Math.Ceiling((float)total / size);

            return Ok(new IndexDTO<ShowItemDTO>(results ?? throw new Exception(), new { page, size, total, maxPageNumber }, new { searchCategory, searchBrand, searchName, sortProp, isDescending }));

        }

        [HttpGet("{id}", Name = "GetItem")]
        public async Task<ActionResult<Item>> GetItem(int id)
        {

            try
            {
                //if(id.ToString() != User.FindFirstValue(ClaimTypes.NameIdentifier) && !User.IsInRole("ADMIN"))
                //{
                //    return Forbid();
                //}


                Item item = await _itemService.Get(id);
                return Ok(mapper.Map<Item, ShowItemDTO>(item));



            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);

            }
        }

        [HttpPost]
        [Authorize(Roles ="Admin")]
        public async Task<ActionResult> CreateItem(CreateItemDTO dto)
        {
            //|| User.FindFirstValue(ClaimTypes.NameIdentifier) == dto.UserId.ToString())
            //if (User.IsInRole("Admin"))
            //{
                Item item = await _itemService.Add(
            dto.Name, dto.Description, dto.Brand, dto.Price, dto.Category, dto.ImageUrl
            );
                return CreatedAtRoute("GetItem", new { item.Id }, mapper.Map<Item, ShowItemDTO>(item));
            //}
            //else
            //{
            //    return Unauthorized();
            //}



        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                await _itemService.Delete(id);
                return NoContent();

            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);

            }


        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, UpdateItemDTO updateItemDTO)
        {
            try
            {
                var newItem = await _itemService.Update(id, updateItemDTO.Name, updateItemDTO.Description, updateItemDTO.Brand, updateItemDTO.Price, updateItemDTO.Category, updateItemDTO.ImageUrl);
                return NoContent();

            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);

            }


        }
    }
}
