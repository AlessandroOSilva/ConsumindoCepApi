using System;
using Newtonsoft.Json;

namespace Models
{
    public partial class Stock
    {
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty( "name")]
        public string Name { get; set; }

        [JsonProperty("company_name")]
        public string CompanyName { get; set; }

        [JsonProperty("document")]
        public string Document { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("website")]
        public Uri Website { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("market_time")]
        public MarketTime MarketTime { get; set; }

        [JsonProperty("market_cap")]
        public string MarketCap { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("change_percent")]
        public string ChangePercent { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        public Stock()
        {   
        }

        public Stock(string symbol, string name, string companyName, string document, 
            string description, Uri website, string region, string currency, MarketTime marketTime, 
            string marketCap, double price, string changePercent, DateTimeOffset updatedAt)
        {
            Symbol = symbol;
            Name = name;
            CompanyName = companyName;
            Document = document;
            Description = description;
            Website = website;
            Region = region;
            Currency = currency;
            MarketTime = marketTime;
            MarketCap = marketCap;
            Price = price;
            ChangePercent = changePercent;
            UpdatedAt = updatedAt;
        }
    }

}
