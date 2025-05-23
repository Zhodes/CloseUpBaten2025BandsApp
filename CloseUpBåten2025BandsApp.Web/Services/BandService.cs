using CloseUpBåten2025BandsApp.Web.Models;
namespace CloseUpBåten2025BandsApp.Web.Services.BandService;

public class BandService
{
    List<Band> bands = new List<Band>
{
    new Band { Id = 1, Name = "Kampen", PerformanceTime = new DateTime(2025, 5, 16, 18, 00, 0), Description = "", ImagePath = "", VideoUrl = "", Albums = Array.Empty<string>()},
    new Band { Id = 2, Name = "Bonni & BASTARDERNA", PerformanceTime = new DateTime(2025, 5, 16, 18, 45, 0), Description = "", ImagePath = "", VideoUrl = "", Albums = Array.Empty<string>() },
    new Band { Id = 3, Name = "Skithuvve", PerformanceTime = new DateTime(2025, 5, 16, 19, 50, 0), Description = "", ImagePath = "", VideoUrl = "", Albums = Array.Empty<string>() },
    new Band { Id = 4, Name = "Trubbel", PerformanceTime = new DateTime(2025, 5, 16, 20, 35, 0), Description = "", ImagePath = "", VideoUrl = "", Albums = Array.Empty<string>() },
    new Band { Id = 5, Name = "Śmierć", PerformanceTime = new DateTime(2025, 5, 16, 21, 20, 0), Description = "", ImagePath = "", VideoUrl = "", Albums = Array.Empty<string>() },
    new Band { Id = 6, Name = "The Baboon Show", PerformanceTime = new DateTime(2025, 5, 16, 21, 35, 0), Description = "", ImagePath = "", VideoUrl = "", Albums = Array.Empty<string>() },
    new Band { Id = 7, Name = "Lawmaker", PerformanceTime = new DateTime(2025, 5, 16, 23, 00, 0), Description = "", ImagePath = "", VideoUrl = "", Albums = Array.Empty<string>() },
    new Band { Id = 8, Name = "Lastkaj 14", PerformanceTime = new DateTime(2025, 5, 17, 0, 20, 0), Description = "", ImagePath = "", VideoUrl = "", Albums = Array.Empty<string>() },
    new Band { Id = 9, Name = "Mothugget", PerformanceTime = new DateTime(2025, 5, 17, 1, 35, 0), Description = "", ImagePath = "", VideoUrl = "", Albums = Array.Empty<string>() },

    new Band { Id = 10, Name = "City Saints", PerformanceTime = new DateTime(2025, 5, 17, 12, 30, 0), Description = "", ImagePath = "", VideoUrl = "", Albums = Array.Empty<string>() },
    new Band { Id = 11, Name = "Avemaria", PerformanceTime = new DateTime(2025, 5, 17, 13, 20, 0), Description = "", ImagePath = "", VideoUrl = "", Albums = Array.Empty<string>() },
    new Band { Id = 12, Name = "Vänsternäven", PerformanceTime = new DateTime(2025, 5, 17, 14, 10, 0), Description = "", ImagePath = "", VideoUrl = "", Albums = Array.Empty<string>() },
    new Band { Id = 13, Name = "Coca Carola", PerformanceTime = new DateTime(2025, 5, 17, 15, 00, 0), Description = "", ImagePath = "", VideoUrl = "", Albums = Array.Empty<string>() },
    new Band { Id = 14, Name = "Björn Limander", PerformanceTime = new DateTime(2025, 5, 17, 18, 00, 0), Description = "", ImagePath = "", VideoUrl = "", Albums = Array.Empty<string>() },
    new Band { Id = 15, Name = "Svarta Solen", PerformanceTime = new DateTime(2025, 5, 17, 18, 45, 0), Description = "", ImagePath = "", VideoUrl = "", Albums = Array.Empty<string>() },
    new Band { Id = 16, Name = "Elfte Timmen", PerformanceTime = new DateTime(2025, 5, 17, 19, 30, 0), Description = "", ImagePath = "", VideoUrl = "", Albums = Array.Empty<string>() },
    new Band { Id = 17, Name = "Kriminella Gitarrer", PerformanceTime = new DateTime(2025, 5, 17, 20, 15, 0), Description = "", ImagePath = "", VideoUrl = "", Albums = Array.Empty<string>() },
    new Band { Id = 18, Name = "Anal Kallsup", PerformanceTime = new DateTime(2025, 5, 17, 21, 00, 0), Description = "", ImagePath = "", VideoUrl = "", Albums = Array.Empty<string>() },
    new Band { Id = 19, Name = "Hyrda Knektar", PerformanceTime = new DateTime(2025, 5, 17, 21, 55, 0), Description = "", ImagePath = "", VideoUrl = "", Albums = Array.Empty<string>() },
    new Band { Id = 20, Name = "Bödel", PerformanceTime = new DateTime(2025, 5, 17, 22, 50, 0), Description = "", ImagePath = "", VideoUrl = "", Albums = Array.Empty<string>() },
    new Band { Id = 21, Name = "Björnarna", PerformanceTime = new DateTime(2025, 5, 17, 0, 00, 0), Description = "", ImagePath = "", VideoUrl = "", Albums = Array.Empty<string>() },
    new Band { Id = 22, Name = "Fruktansvärld", PerformanceTime = new DateTime(2025, 5, 18, 0, 35, 0), Description = "", ImagePath = "", VideoUrl = "", Albums = Array.Empty<string>() },
    new Band { Id = 23, Name = "Vägsjäl", PerformanceTime = new DateTime(2025, 5, 18, 1, 20, 0), Description = "", ImagePath = "", VideoUrl = "", Albums = Array.Empty<string>() }
};


public void AddBand(Band band)
    {
        band.Id = bands.Count == 0 ? 1 : bands.Max(e => e.Id) + 1;
        bands.Add(band);
    }

    public Band GetBandById(int id) => bands.Single(e => e.Id == id);

    public Band[] GetAllBands() => bands.OrderBy(e => e.Name).ToArray();

    internal Band GetById(int id) => bands.Single(e => e.Id == id);
}
