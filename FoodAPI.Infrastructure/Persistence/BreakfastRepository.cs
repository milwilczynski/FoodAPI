using FoodAPI.Application.Persistence;
using FoodAPI.Domain.Breakfast.Entities;
using FoodAPI.Domain.Breakfast.ValueObjects;

namespace FoodAPI.Infrastructure.Persistence;

public class BreakfastRepository : IBreakfastRepository
{
    //TODO: Context
    private readonly List<Breakfast> _breakfasts = new();

    public void Add(Breakfast breakfast)
    {
        _breakfasts.Add(breakfast);
    }

    public void Delete(BreakfastId breakfastId)
    {
        var find = _breakfasts.Find(food => food.Id == breakfastId);
        if (find is not null)
        {
            _breakfasts.Remove(find);
            return;
        }

        throw new KeyNotFoundException("Breakfast not found");
    }

    public void Update(Breakfast breakfast)
    {
        var find = _breakfasts.Find(food => food.Equals(breakfast));
        if (find is not null)
        {
            _breakfasts.Remove(find);
            _breakfasts.Add(breakfast);
            return;
        }

        throw new KeyNotFoundException("Breakfast not found");
    }
}