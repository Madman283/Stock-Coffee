using System;
using System.Collections.Generic;
using System.Text;
using static EventDemo.Utility;

namespace EventDemo
{
    class Stock
    {
        string symbol;
        decimal price;

        public Stock(string symbol) { this.symbol = symbol; }

        public event EventHandler<PriceChangedEventArgs> PriceChanged;

        protected virtual void OnPriceChanged(PriceChangedEventArgs e)
        {
            PriceChanged?.Invoke(this, e);
        }

        public void PriceFluctuation()
        {
            if (GetRandomInteger(2)==1)
            Price = Price + GetRandomInteger(-10, 0);
            if (Price <= 5)
            {
                Print($"You waited to long to drink {symbol}! Now it is cold.");
            }
            
        }


        public decimal Price
        {
            get { return price; }
            set
            {
                if (price == value) return;
                decimal oldPrice = price;
                price = value;
                OnPriceChanged(new PriceChangedEventArgs(oldPrice, price));
            }
        }

        public string Symbol { get => symbol; set => symbol = value; }

        public void stock_PriceChanged(object sender, PriceChangedEventArgs e)
        {
            if (e.LastPrice != e.NewPrice)
                Print($"{Symbol} temp has changed. Previous temp was {e.LastPrice}, new temp is {e.NewPrice}. The difference is {e.LastPrice - e.NewPrice} degrees celcius.");
        }

        public class PriceChangedEventArgs : EventArgs
        {
            public readonly decimal LastPrice;
            public readonly decimal NewPrice;

            public PriceChangedEventArgs(decimal lastPrice, decimal newPrice)
            {
                LastPrice = lastPrice; NewPrice = newPrice;
            }
        }

    }
}
