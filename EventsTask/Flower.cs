using System;
using System.Runtime.CompilerServices;

namespace EventsTask
{
	enum FlowerTypes
	{
		денна = 1,
		нічна = 2
	}
	enum FlowerState
	{
		відкрита = 1,
		закрита = 2
	}
	class Flower
	{
		public static List<Flower> allFlowerInstances = new List<Flower>();
		private string name;
		private FlowerTypes type;
		public uint lifeTerm;
		public FlowerState State { get; set; }
		private uint dayOfLife;
        public Flower(string _name = "", uint _lifeterm = 2,FlowerTypes _type = FlowerTypes.денна, FlowerState _state = FlowerState.закрита)
		{
			this.name = _name;
			this.type = _type;
			this.lifeTerm = _lifeterm;
			dayOfLife = 1;
			allFlowerInstances.Add(this);
			State = _state;
		}
		
		public override string ToString()
		{
			return $"Я {this.name} i я {this.type} квiтка. Я цвiту {dayOfLife}-й день";	
		}
		public static void nextDay()
		{
			foreach (Flower f in allFlowerInstances)
			{
				f.dayOfLife = f.dayOfLife + 1;
			}
			allFlowerInstances.RemoveAll(x => x.dayOfLife == x.lifeTerm + 1);
			
		}
		public static void onSunset(object sender)
		{
			foreach (Flower f in allFlowerInstances)
			{
				if(f.type == FlowerTypes.денна)
				{
					f.State = FlowerState.закрита;
					Console.WriteLine($"{f} Зараз {(sender as Sun)} сонця, тому я {f.State} :)");
				}
			}
		}
		public static void onMidday(object sender)
		{
			foreach (Flower f in allFlowerInstances)
			{
				if (f.type == FlowerTypes.денна)
				{
					f.State = FlowerState.закрита;
					Console.WriteLine($"{f} Зараз {(sender as Sun)}, тому я {f.State} :)");
				}
			}
		}
		public static void onEvening(object sender)
		{
			foreach (Flower f in allFlowerInstances)
			{
					f.State = FlowerState.відкрита;
					Console.WriteLine($"{f} Зараз {(sender as Sun)}, тому я {f.State} :)");	
			}
		}
		public static void onSunrise(object sender)
		{
			foreach (Flower f in allFlowerInstances)
			{
				if (f.type == FlowerTypes.денна)
				{
					f.State = FlowerState.відкрита;
					Console.WriteLine($"{f} Зараз {(sender as Sun)} сонця, тому я {f.State} :)");
				}
				else
				{
					f.State = FlowerState.закрита;
					Console.WriteLine($"{f} Зараз {(sender as Sun)} сонця, тому я {f.State} :)");
				}
			}
		}
	}
}
