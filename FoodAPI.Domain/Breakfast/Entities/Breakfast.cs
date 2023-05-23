using FoodAPI.Domain.Breakfast.ValueObjects;
using FoodAPI.Domain.Models;

namespace FoodAPI.Domain.Breakfast.Entities;

public sealed class Breakfast : AggregateRoot<BreakfastId>
{
    public Breakfast(
        BreakfastId breakfastId, string name, string description, DateTime startDateTime, DateTime endDateTime, DateTime lastModifiedDateTime,
        List<string> savory,
        List<string> sweet) : base(breakfastId)
    {
        Name = name;
        Description = description;
        StartDateTime = startDateTime;
        EndDateTime = endDateTime;
        LastModifiedDateTime = lastModifiedDateTime;
        Savory = savory;
        Sweet = sweet;
    }

    public string Name { get; }
    public string Description { get; }
    public DateTime StartDateTime { get; }
    public DateTime EndDateTime { get; }
    public DateTime LastModifiedDateTime { get; }
    public List<string> Savory { get; }
    public List<string> Sweet { get; }

    public static Breakfast Create(string name, string description, List<string> savory, List<string> sweet)
    {
        return new Breakfast(BreakfastId.CreateUnique(), name, description, DateTime.UtcNow, DateTime.UtcNow, DateTime.UtcNow, savory, sweet);
    }
}