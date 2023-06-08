namespace FishTankLib.Fish;

public class BabelFish : IFish
{
    public string Name { get; }

    public Food FoodAmount { get; set; }

    public string GetSpecies => "Babel fish";

    public BabelFish(string name)
    {
        Name = name;
        FoodAmount = new Food(0.3m);
    }
}
