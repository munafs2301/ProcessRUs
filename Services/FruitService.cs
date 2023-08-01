using AutoMapper;
using ProcessRUs.Data;
using ProcessRUs.DTOs;
using ProcessRUs.Entities;
using ProcessRUs.Helpers;
using ProcessRUs.Interfaces;
using System.Collections.Generic;

namespace ProcessRUs.Services
{
    public class FruitService : IFruitService
    {
        private readonly ProcessRUsContext _context;
        private readonly IMapper _mapper;

        public FruitService(ProcessRUsContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<FruitResponse> GetFruits(FruitType fruitType)
        {
            if (fruitType == 0)
            {
                return _mapper.Map<List<FruitResponse>>(_context.Fruits.OrderBy(f => f.Name).ToList());
            }
            var fruits = _context.Fruits.Where(f => f.Type == fruitType).OrderBy(f => f.Name).ToList();
            return _mapper.Map<List<FruitResponse>>(fruits);


        }
    }
}
