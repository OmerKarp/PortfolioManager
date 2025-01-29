using System;
using System.Collections.Generic;

namespace PortfolioManager
{
	internal class Portfolio
	{
		public Person owner;
		public float valuation;
		public List<Asset> assets;
		public List<string> sectors;
		public List<string> brokers;

		public Portfolio(Person owner)
		{
			this.owner = owner;
			valuation = 0;
			assets = new List<Asset>();
			sectors = new List<string>();
			brokers = new List<string>();
		}

		public void AddAsset(Asset asset)
		{
			assets.Add(asset);
			Console.WriteLine($"Added asset: {asset.Name}");
		}
	}
}
