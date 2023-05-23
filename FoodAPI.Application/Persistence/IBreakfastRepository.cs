using FoodAPI.Domain.Breakfast.Entities;
using FoodAPI.Domain.Breakfast.ValueObjects;

namespace FoodAPI.Application.Persistence;

public interface IBreakfastRepository
{
    void Add(Breakfast breakfast);
    void Update(Breakfast breakfast);
    void Delete(BreakfastId breakfastId);
}