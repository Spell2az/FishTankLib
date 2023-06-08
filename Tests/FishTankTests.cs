namespace Tests;

public class FishTankTests
{
    [Theory]
    [MemberData(nameof(FishTestData))]
    public void GivenFishTankWithFish_WhenFeedIsCalled_ThenCorrectAmountOfFoodIsReturned(List<IFish> fish, decimal expectedFood)
    {
        var fishTank = new FishTank(fish);
        fishTank.Feed().Amount.Should().Be(expectedFood);
    }

   public static IEnumerable<object[]> FishTestData =>
        new List<object[]>
        {
            new object[] { new List<IFish>{ new GoldFish("Jack")}, 0.1m },
            new object[] { new List<IFish>{ new AngelFish("Jack")}, 0.2m },
            new object[] { new List<IFish>{ new BabelFish("Jack")}, 0.3m },
            new object[] { new List<IFish>{ new AngelFish("Jack"), new BabelFish("Joe")}, 0.5m },
            new object[] { new List<IFish>{ new AngelFish("Jack"), new AngelFish("Jim"), new BabelFish("Joe")}, 0.7m },
            new object[] { new List<IFish>{ new GoldFish("Jack"), new AngelFish("Jack"), new AngelFish("Jim"), new BabelFish("Joe")}, 0.8m },
            new object[] { new List<IFish>(Enumerable.Range(0, 10).Select(_ => new GoldFish("fish"))) , 1.0m },
            new object[] { new List<IFish>{ }, 0.0m },
        };
}