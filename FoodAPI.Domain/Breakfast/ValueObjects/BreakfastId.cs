using FoodAPI.Domain.Models;

namespace FoodAPI.Domain.Breakfast.ValueObjects;

public sealed class BreakfastId : ValueObject
{
    private BreakfastId(Guid value)
    {
        Value = value;
    }

    public Guid Value { get; }

    public static BreakfastId CreateUnique()
    {
        return new BreakfastId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        throw new NotImplementedException();
    }
}