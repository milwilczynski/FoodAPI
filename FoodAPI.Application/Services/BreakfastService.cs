using FoodAPI.Application.Persistence;

namespace FoodAPI.Application.Services;

public class BreakfastService
{
    private readonly IBreakfastRepository _breakfastRepository;

    public BreakfastService(IBreakfastRepository breakfastRepository)
    {
        _breakfastRepository = breakfastRepository;
    }
}