using AutoMapper;
using FoodRepositoryServiceDemo.Models;
using FoodRepositoryServiceDemo.ViewModels;

namespace FoodRepositoryServiceDemo.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<FoodItemViewModel, FoodItem>();
            CreateMap<FoodItem, FoodItemViewModel>();
        }
    }
}
