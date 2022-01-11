using HtmlAgilityPack;
using Stock_v2.Models;
using Stock_v2.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stock_v2.Data
{
    public class StockScrapper
    {
        private const string BaseUrl = "https://www.bankier.pl/gielda/notowania/akcje";

        public IEnumerable<StocksViewModel> GetStocks()
        {
            var web = new HtmlWeb();
            var document = web.Load(BaseUrl);
            var tableRows = document.QuerySelectorAll("table tr").Skip(1).Skip(11);

            List<StocksViewModel> stocks = new List<StocksViewModel>();

            foreach (var tableRow in tableRows)
            {
                var tds = tableRow.QuerySelectorAll("td");

                var walor = tds[0].QuerySelector("a").InnerText;
                var kursWithComa = tds[1].InnerText;
                var zmiana = tds[2].InnerText;

                float kurs = float.Parse(kursWithComa.Replace(",", ".").Replace("&nbsp;", ""));
                float zmianaFloat = float.Parse(zmiana.Replace(",", "."));
                StocksViewModel stock = new StocksViewModel
                {
                    Walor = walor,
                    Kurs = kurs,                  
                    Zmiana = zmianaFloat
                };

                stocks.Add(stock);

            }
            return stocks;
        }
    }
}

