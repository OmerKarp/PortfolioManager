using System;

namespace PortfolioManager
{
	internal class Asset
	{
		public string Name;
		public string Sector;
		public string Broker;
		public float Price;
		public string Symbol;

		public Asset(string name, string sector, string broker, float price, string symbol)
		{
			Name = name;
			Sector = sector;
			Broker = broker;
			Price = price;
			Symbol = symbol;
		}
	}
}
