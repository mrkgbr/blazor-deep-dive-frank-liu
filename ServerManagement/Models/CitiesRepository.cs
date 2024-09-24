namespace ServerManagement.Models;

public class CitiesRepository
{
    private static List<string> _cities =
    [
        "Toronto",
        "Montreal",
        "Ottawa",
        "Calgary",
        "Halifax"
    ];

    public static List<string> GetCities() => _cities;
}
