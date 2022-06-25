using System;
using System.Collections.Generic;
using System.Linq;

namespace StockMarket
{
    public class Investor
    {
        public List<Stock> Portfolio { get; set; }

        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public decimal MoneyToInvest { get; set; }
        public string BrokerName { get; set; }

        public Investor( string fullName, string emailAddress, decimal moneyToInvest, string brokerName)
        {
            this.Portfolio = new List<Stock>();
            this.FullName = fullName;
            this.EmailAddress = emailAddress;
            this.MoneyToInvest = moneyToInvest;
            this.BrokerName = brokerName;
        }

        public int Count => this.Portfolio.Count;

        public void BuyStock(Stock stock)
        {
            if (stock.MarketCapitalization > 10_000 && this.MoneyToInvest >= stock.PricePerShare)
            {
                Portfolio.Add(stock);
                this.MoneyToInvest -= stock.PricePerShare;
            }
        }

        public string SellStock(string companyName, decimal sellPrice)
        {
            Stock stock = FindStock(companyName);

            if (stock == null)
            {
                return $"{companyName} does not exist.";
            }
            else if (stock.PricePerShare > sellPrice)
            {
                return $"Cannot sell {companyName}";
            }
            else
            {
            Portfolio.Remove(stock);
            this.MoneyToInvest += sellPrice;
            return $"{companyName} was sold";
            }
        }

        public Stock FindStock(string companyName)
        {
            foreach (var stock in this.Portfolio)
            {
                if (stock.CompanyName == companyName)
                {
                    return stock;
                }
            }
            return null;
        }

        public Stock FindBiggestCompany()
        {
            if (Portfolio.Count == 0)
            {
                return null;
            }
            else
            {
            List<Stock> biggestStock = Portfolio.OrderByDescending(stock => stock.PricePerShare).ToList();
            return biggestStock[0];
            }
        }

        public string InvestorInformation()
        {
            return
                $"The investor {this.FullName} with a broker {this.BrokerName} has stocks:" + Environment.NewLine +
                string.Join(Environment.NewLine, this.Portfolio);
        }
    }
}
