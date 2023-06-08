namespace FishTankLib;

public class FishTank : IFishTank
{
    private List<IFish> Fishes { get; }
    public void AddFish(IFish fish) => Fishes.Add(fish);

    public Food Feed() => new Food(Fishes.Sum(f => f.FoodAmount.Amount));

    public FishTank(List<IFish> fishes) => Fishes = fishes ?? new List<IFish>();

    public int CheckFishCount() => Fishes.Count;
}
