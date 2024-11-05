using AutoMapper;
using Farmacity_Backend.DTOs;
using Farmacity_Backend.Entity;

namespace Farmacity_Backend.Utilities
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<ProductoAddDTO, Producto>();   
        }
    }
}
