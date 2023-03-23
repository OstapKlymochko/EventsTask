namespace EventsTask
{
	class Program
	{
		public enum daysOfWeek
		{
			понеділок, вівторок, середа, четвер, пятниця, субота, неділя
		}
		static void Main(string[] args)
		{
			Sun sun = new Sun();
			Console.WriteLine(sun);
			Flower mak = new Flower("Мак", 5, FlowerTypes.денна);
			Flower romashka = new Flower("Ромашка", 7, FlowerTypes.денна);
			////Console.WriteLine(mak);
			Girl Anya = new Girl("Аня", daysOfWeek.неділя);
			Flower matiola = new Flower("Матiола", 7, FlowerTypes.нічна);
			Bee maya = new Bee("Мая");
			sun.Sunset += Flower.onSunset;
			sun.Sunrise += Flower.onSunrise;
			sun.Evening += Flower.onEvening;
			sun.Midday += Flower.onMidday;

			sun.Sunset += Bee.onSunset;
			sun.Sunrise += Bee.onSunrise;
			sun.Evening += Bee.onEvening;
			sun.Midday += Bee.onMidday;

			sun.Sunset += Anya.onSunset;
			sun.Sunrise += Anya.onSunrise;
			sun.Evening += Anya.onEvening;
			sun.Midday += Anya.onMidday;

			

			for(uint i = 0; i < 4; ++i)
			{
				foreach(int j in Enum.GetValues(typeof(daysOfWeek)))
				{
					if(Flower.allFlowerInstances.Count() == 0)
					{
						mak = new Flower("Мак", 5, FlowerTypes.денна);
						romashka = new Flower("Ромашка", 7, FlowerTypes.денна);
						matiola = new Flower("Матiола", 7, FlowerTypes.нічна);
					}
                    Console.WriteLine("-----------"+ (daysOfWeek)j + "-----------");
                    Anya.DayOfWeek = (daysOfWeek)j;
					sun.sunUp();
					sun.midday();
					sun.evening();
					sun.sunDown();
					Flower.nextDay();
                    Console.WriteLine("-----------"+ (daysOfWeek)j + "-----------");
				}
			}

		}
	}
}