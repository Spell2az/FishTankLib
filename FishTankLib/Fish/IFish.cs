namespace FishTankLib.Fish;

public interface IFish
{
    public string Name { get; }
    public Food FoodAmount { get; }
    public string GetSpecies { get; }
}
