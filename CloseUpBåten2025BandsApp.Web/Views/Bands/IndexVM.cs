namespace CloseUpBåten2025BandsApp.Web.Views.Bands
{
    public class IndexVM
    {
        public BandVM[] BandVMs { get; set; } = null!;

        public class BandVM
        {
            public required int Id { get; set; }
            public required string Name { get; set; }
        }
    }
}
