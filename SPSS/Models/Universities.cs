namespace SPSS.Models;

public class University
{
    public int Id { get; set; }
    public string UniversityName { get; set; } = string.Empty;
    public int CityId { get; set; }
    public string Url { get; set; } = string.Empty;
}

public class GroceriesInfo
{
    public List<AccommodationInfo>? Accommodations { get; set; }
}

public class AccommodationInfo
{
    public string Name { get; set; } = string.Empty;
    public bool UniversityOwned { get; set; }
    public int UniversityId { get; set; }
    public string NearestSupermarket { get; set; } = string.Empty;
    public decimal AverageSupermarketCost { get; set; }
    public decimal AccommodationCostPerWeek { get; set; }
}

public class City
{
    public int Id { get; set; }
    public string CityName { get; set; } = string.Empty;
    public AccommodationsInfo? Accommodations { get; set; }
    public JobsInfo? Jobs { get; set; }
    public EntertainmentInfo? Entertainment { get; set; }
    public GroceriesInfo? Groceries { get; set; }
}

public class JobsInfo
{
    public decimal MedianWage { get; set; }
    public decimal EmploymentRate { get; set; }
    public decimal UnemploymentRate { get; set; }
    public string PartTimeJobPostings { get; set; } = string.Empty;
}

public class EntertainmentInfo
{
    public decimal GoingOut { get; set; }
    public decimal HolidayAndEvents { get; set; }
    public decimal ClubsAndSocieties { get; set; }
    public decimal CinemaTickets { get; set; }
}
public class AccommodationsInfo
{
    public List<HallInfo>? Halls { get; set; }
    public List<HouseInfo>? Houses { get; set; }
}

public class HallInfo
{
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public decimal Ratings { get; set; }
}

public class HouseInfo
{
    public decimal AvePerMonth { get; set; }
}