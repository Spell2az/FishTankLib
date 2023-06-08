namespace FishTankLib.Fish;

public class GoldFish : IFish
{
    public string Name { get; }

    public Food FoodAmount { get; set; }

    public string GetSpecies => "Gold fish";

    public GoldFish(string name)
    {
        Name = name;
        FoodAmount = new Food(0.1m);
    }
}
