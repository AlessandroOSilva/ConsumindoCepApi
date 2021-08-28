
namespace Models
{
    public partial class MarketTime
    {
        public string Open { get; set; }
        public string Close { get; set; }
        public long Timezone { get; set; }

        public MarketTime()
        {
        }

        public MarketTime(string open, string close, long timezone)
        {
            Open = open;
            Close = close;
            Timezone = timezone;
        }
    }
}

