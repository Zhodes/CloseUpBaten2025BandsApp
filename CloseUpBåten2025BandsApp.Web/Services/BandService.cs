using CloseUpBåten2025BandsApp.Web.Models;
namespace CloseUpBåten2025BandsApp.Web.Services.BandService;

public class BandService
{
    List<Band> bands = new List<Band>
{
    new Band { Id = 1, Name = "Kampen", PerformanceTime = new DateTime(2025, 5, 16, 18, 00, 0), Description = "Kampen är ett svenskt punkband med rötter i Göteborgsscenen. Deras musik kännetecknas av energiska riff och samhällskritiska texter.", ImagePath = "", VideoUrl = "", Albums = Array.Empty<string>() },

new Band { Id = 2, Name = "Bonni & BASTARDERNA", PerformanceTime = new DateTime(2025, 5, 16, 18, 45, 0), Description = "Bonni & BASTARDERNA är ett svenskt punkband känt för sina intensiva liveframträdanden och råa texter.", ImagePath = "", VideoUrl = "", Albums = Array.Empty<string>() },

new Band { Id = 3, Name = "Skithuvve", PerformanceTime = new DateTime(2025, 5, 16, 19, 50, 0), Description = "Skithuvve är ett svenskt punkband som levererar snabb och aggressiv musik med humoristiska inslag.", ImagePath = "", VideoUrl = "", Albums = Array.Empty<string>() },

new Band { Id = 4, Name = "Trubbel", PerformanceTime = new DateTime(2025, 5, 16, 20, 35, 0), Description = "Trubbel är ett punkband från Göteborg som kombinerar klassisk svensk punk med humor och attityd.", ImagePath = "", VideoUrl = "", Albums = Array.Empty<string>() },

new Band { Id = 5, Name = "Śmierć", PerformanceTime = new DateTime(2025, 5, 16, 21, 20, 0), Description = "Śmierć är ett svenskt D-beat punkband med polska rötter, känt för sin intensiva ljudbild och politiska texter.", ImagePath = "", VideoUrl = "", Albums = Array.Empty<string>() },

new Band { Id = 6, Name = "The Baboon Show", PerformanceTime = new DateTime(2025, 5, 16, 21, 35, 0), Description = "The Baboon Show är ett svenskt punkband som blandar 77-punk, garage och powerpop med politiska texter och energiska framträdanden.", ImagePath = "", VideoUrl = "", Albums = Array.Empty<string>() },

new Band { Id = 7, Name = "Lawmaker", PerformanceTime = new DateTime(2025, 5, 16, 23, 00, 0), Description = "Lawmaker är ett svenskt punkband med en kraftfull och dynamisk ljudbild, inspirerad av klassisk hardcore.", ImagePath = "", VideoUrl = "", Albums = Array.Empty<string>() },

new Band { Id = 8, Name = "Lastkaj 14", PerformanceTime = new DateTime(2025, 5, 17, 0, 20, 0), Description = "Lastkaj 14 är ett svenskt trallpunkband som kombinerar melodiska inslag med snabb och energisk punkrock.", ImagePath = "", VideoUrl = "", Albums = Array.Empty<string>() },

new Band { Id = 9, Name = "Mothugget", PerformanceTime = new DateTime(2025, 5, 17, 1, 35, 0), Description = "Mothugget är ett svenskt punkband känt för sin råa energi och samhällskritiska texter.", ImagePath = "", VideoUrl = "", Albums = Array.Empty<string>() },

new Band { Id = 10, Name = "City Saints", PerformanceTime = new DateTime(2025, 5, 17, 12, 30, 0), Description = "City Saints är ett punkband från Göteborg som blandar Oi!, streetpunk och rock'n'roll med texter på både svenska och engelska.", ImagePath = "", VideoUrl = "", Albums = Array.Empty<string>() },

new Band { Id = 11, Name = "Avemaria", PerformanceTime = new DateTime(2025, 5, 17, 13, 20, 0), Description = "Avemaria är ett svenskt punkband med en unik blandning av melodiska inslag och kraftfulla texter.", ImagePath = "", VideoUrl = "", Albums = Array.Empty<string>() },

new Band { Id = 12, Name = "Vänsternäven", PerformanceTime = new DateTime(2025, 5, 17, 14, 10, 0), Description = "Vänsternäven är ett svenskt punkband med starka politiska texter och en energisk scenpresence.", ImagePath = "", VideoUrl = "", Albums = Array.Empty<string>() },

new Band { Id = 13, Name = "Coca Carola", PerformanceTime = new DateTime(2025, 5, 17, 15, 00, 0), Description = "Coca Carola är ett svenskt punkband från Åkersberga, bildat 1986, känt för sin trallpunkstil och samhällskritiska texter.", ImagePath = "", VideoUrl = "", Albums = Array.Empty<string>() },

new Band { Id = 14, Name = "Björn Limander", PerformanceTime = new DateTime(2025, 5, 17, 18, 00, 0), Description = "Björn Limander är en svensk singer-songwriter som blandar punkinfluenser med akustiska element.", ImagePath = "", VideoUrl = "", Albums = Array.Empty<string>() },

new Band { Id = 15, Name = "Svarta Solen", PerformanceTime = new DateTime(2025, 5, 17, 18, 45, 0), Description = "Svarta Solen är ett svenskt punkband med en mörk och atmosfärisk ljudbild, inspirerad av post-punk och goth.", ImagePath = "", VideoUrl = "", Albums = Array.Empty<string>() },

new Band { Id = 16, Name = "Elfte Timmen", PerformanceTime = new DateTime(2025, 5, 17, 19, 30, 0), Description = "Elfte Timmen är ett svenskt punkband som kombinerar melodiska inslag med kraftfulla texter om samhällsfrågor.", ImagePath = "", VideoUrl = "", Albums = Array.Empty<string>() },

new Band { Id = 17, Name = "Kriminella Gitarrer", PerformanceTime = new DateTime(2025, 5, 17, 20, 15, 0), Description = "Kriminella Gitarrer är ett svenskt punkband från 1970-talet, kända för sin råa och minimalistiska stil.", ImagePath = "", VideoUrl = "", Albums = Array.Empty<string>() },

new Band { Id = 18, Name = "Anal Kallsup", PerformanceTime = new DateTime(2025, 5, 17, 21, 00, 0), Description = "Anal Kallsup är ett svenskt punkband med provocerande texter och en energisk scenstil.", ImagePath = "", VideoUrl = "", Albums = Array.Empty<string>() },

new Band { Id = 19, Name = "Hyrda Knektar", PerformanceTime = new DateTime(2025, 5, 17, 21, 55, 0), Description = "Hyrda Knektar är ett svenskt punkband som blandar traditionell punk med moderna influenser.", ImagePath = "", VideoUrl = "", Albums = Array.Empty<string>() },

new Band { Id = 20, Name = "Bödel", PerformanceTime = new DateTime(2025, 5, 17, 22, 50, 0), Description = "Bödel är ett svenskt punkband med en tung och aggressiv ljudbild, inspirerad av hardcore och metal.", ImagePath = "", VideoUrl = "", Albums = Array.Empty<string>() },

new Band { Id = 21, Name = "Björnarna", PerformanceTime = new DateTime(2025, 5, 17, 0, 00, 0), Description = "Björnarna är ett svenskt punkband med humoristiska texter och en energisk scenstil.", ImagePath = "", VideoUrl = "", Albums = Array.Empty<string>() },

new Band { Id = 22, Name = "Fruktansvärld", PerformanceTime = new DateTime(2025, 5, 18, 0, 35, 0), Description = "Fruktansvärld är ett svenskt punkband med en mörk och intensiv ljudbild, inspirerad av D-beat och crustpunk.", ImagePath = "", VideoUrl = "", Albums = Array.Empty<string>() },

new Band { Id = 23, Name = "Vägsjäl", PerformanceTime = new DateTime(2025, 5, 18, 1, 20, 0), Description = "Vägsjäl är ett svenskt punkband som kombinerar melodiska inslag med kraftfulla texter om existentiella frågor.", ImagePath = "", VideoUrl = "", Albums = Array.Empty<string>() }

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
