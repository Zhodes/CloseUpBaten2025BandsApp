namespace CloseUpBåten2025BandsApp.Web.Models
{
    public class Band
    {
        private DateTime performanceTime;
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string? ImagePath { get; set; }
        public string? VideoUrl { get; set; }
        public DateTime PerformanceTime
        {
            get => performanceTime;
            set
            {
                if (value < PerformanceTimeLimits.MinTime || value > PerformanceTimeLimits.MaxTime)
                    throw new ArgumentException($"PerformanceTime must be between {PerformanceTimeLimits.MinTime} and {PerformanceTimeLimits.MaxTime}.");
                performanceTime = value;
            }
        }
        public string[]? Albums { get; set; }


    }
}
