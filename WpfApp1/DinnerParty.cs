
// DinnerParty.cs
public class DinnerParty
{
    public int NumberOfPeople { get; set; }
    public decimal CostOfFoodPerPerson = 25.0m;
    public bool FancyDecorations { get; set; }

    public decimal CalculateCostOfDecorations()
    {
        return FancyDecorations ? (NumberOfPeople * 15.0m) + 50 : (NumberOfPeople * 7.5m) + 30;
    }

    public decimal CalculateCost()
    {
        decimal totalCost = NumberOfPeople * CostOfFoodPerPerson;
        totalCost += CalculateCostOfDecorations();

        if (NumberOfPeople > 12)
        {
            totalCost *= 0.95m; // Apply a 5% discount if more than 12 people
        }

        return totalCost;
    }
}
