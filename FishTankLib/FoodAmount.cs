namespace FishTankLib;

public record Food
{
    public decimal Amount { get; init; }
    public WeightUnits WeightUnit { get; init; }
    public Food(decimal amount, WeightUnits weightUnit = WeightUnits.gram)
    {
        Amount = amount;
        WeightUnit = weightUnit;
    }
}
