using CloseUpBåten2025BandsApp.Web.Services.BandService;
namespace CloseUpBåten2025BandsApp.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddSingleton<BandService>();
            var app = builder.Build();
            app.MapControllers();
            app.Run();
        }
    }
}
