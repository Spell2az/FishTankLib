namespace FishTankLib.Fish;

public class AngelFish : IFish
{
    public string Name { get; }

    public Food FoodAmount { get; set; }

    public string GetSpecies => "Angel fish";

    public AngelFish(string name)
    {
        Name = name;
        FoodAmount = new Food(0.2m);
    }
}
