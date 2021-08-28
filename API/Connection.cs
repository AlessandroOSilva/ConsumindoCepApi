using Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsumoDeApiWPF.API
{
    class Connection
    {
        public async Task<Stock> GetStock(string simbolo)
        {

            string key = "f842c2bb";

            using (HttpClient client = new HttpClient { BaseAddress = new Uri("https://api.hgbrasil.com/finance/stock_price?key=") })
            {
                var response = await client.GetAsync(client.BaseAddress + key + "&symbol=" + simbolo);

                if (response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsStringAsync().Result;

                    Stock stock = JsonConvert.DeserializeObject<Stock>(result);

                    return stock;
                }
                return null;
            }

        }
    }
}
