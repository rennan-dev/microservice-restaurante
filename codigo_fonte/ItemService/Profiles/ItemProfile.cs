using AutoMapper;
using ItemService.Dtos;
using ItemService.Models;

namespace ItemService.Profiles;
public class ItemProfile : Profile {
    public ItemProfile() {
        CreateMap<RestauranteReadDto, Restaurante>().ForMember(destino=>destino.IdExterno, opt => opt.MapFrom(src=>src.Id));
        CreateMap<Restaurante, RestauranteReadDto>();
        CreateMap<ItemCreateDto, Item>();
        CreateMap<Item, ItemCreateDto>();
    }
}