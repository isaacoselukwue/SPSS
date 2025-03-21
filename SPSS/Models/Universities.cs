namespace SPSS.Models;

public class University
{
    public int Id { get; set; }
    public string UniversityName { get; set; } = "";
    public string Url { get; set; } = "";
    public string City { get; set; } = "";
}

public class UniversityCost
{
    public int Id { get; set; }
    public int UniversityId { get; set; }
    public string GroceriesCostPerWeek { get; set; } = "";
    public string NoOfJobsAvailable { get; set; } = "";
    public string EntertainmentCostPerWeek { get; set; } = "";
    public string AccommodationCostPerWeek { get; set; } = "";
    public GroceriesInfo? Groceries { get; set; }
}

public class GroceriesInfo
{
    public List<AccommodationInfo>? Accommodations { get; set; }
}

public class AccommodationInfo
{
    public string Name { get; set; } = "";
    public bool UniversityOwned { get; set; }
    public string NearestSupermarket { get; set; } = "";
    public decimal AverageSupermarketCost { get; set; }
}