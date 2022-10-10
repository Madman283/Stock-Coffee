using System;
using System.Collections.Generic;
using System.Text;
using static EventDemo.Utility;

namespace EventDemo
{
    class Exchange
    {
        private string name = "Your current beverage temp sim";
        List<Stock> Stocks = new List<Stock>()
        {
            new Stock("Coffee"),
            new Stock("Hot Chocolate"),
            new Stock("Tea")
        };
        public void Open()
        {
            SetStockPrices();
            PrintAllStockPrices();
            Run();
        }
        private void Menu()
        {
            Print("Press x to exit, any other key to check for temps.");
            string input = Console.ReadLine();
            if (input.ToLower() != "x")
            {
                Run();
            }

        }
        private void Run()
        {
            ClearScreen();
            Print(name);
            Print("--------------------------");
            PrintAllStockPrices();
            Print("--------------------------");
        
            
            //call setstockprices on all stocks in the list
            foreach (Stock s in Stocks)
            {
                s.PriceFluctuation();
            }
            Menu();

        }
        private void SetStockPrices()
        {
            foreach (Stock s in Stocks)
            {
                // Register with the PriceChanged event
                s.PriceChanged += s.stock_PriceChanged;
                s.Price = Utility.RandomNumber.Next(71, 85);
            }
        }
      
        private void PrintAllStockPrices()
        {
            foreach (Stock s in Stocks)
            {
                Print($"Your drink of {s.Symbol} is currently at {s.Price} degrees celcius");
            }
        }

    }
}
