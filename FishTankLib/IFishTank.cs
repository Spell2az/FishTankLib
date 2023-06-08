namespace FishTankLib;

public interface IFishTank
{
    public Food Feed();
    public void AddFish(IFish fish);
}
