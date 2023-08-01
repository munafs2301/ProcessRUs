using ProcessRUs.DTOs;
using ProcessRUs.Entities;
using ProcessRUs.Helpers;

namespace ProcessRUs.Interfaces
{
    public interface IFruitService
    {
        List<FruitResponse> GetFruits(FruitType fruitType);
    }
}