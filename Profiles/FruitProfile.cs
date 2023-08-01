using AutoMapper;
using ProcessRUs.DTOs;
using ProcessRUs.Entities;

namespace ProcessRUs.Profiles
{
    public class FruitProfile: Profile 
    {
        public FruitProfile()
        {
            CreateMap<Fruit, FruitResponse>().ReverseMap();
        }

    }
}
