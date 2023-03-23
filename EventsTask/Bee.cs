using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsTask
{
	enum WorkingStates
	{
		працюю = 1,
		відпочиваю = 2,
		сплю = 3
	}
	class Bee
	{
		public static List<Bee> allBees = new List<Bee>();
		private string name;
		public WorkingStates State { get; set; }
		public Bee(string _name = "", WorkingStates _state = WorkingStates.відпочиваю)
		{
			this.name = _name;
			allBees.Add(this);
			State = _state;
		}
		public override string ToString()
		{
			return $"Я бджiлка {name}. Зараз я {State}.";
		}
		public static void onSunset(object sender)
		{
			foreach (Bee b in allBees)
			{
				b.State = WorkingStates.сплю;
                Console.WriteLine($"Зараз {(sender as Sun)}. {b}");
            }
		}
		public static void onMidday(object sender)
		{
			foreach (Bee b in allBees)
			{
				b.State = WorkingStates.відпочиваю;
				Console.WriteLine($"Зараз {(sender as Sun)}. {b}");
			}
		}
		public static void onEvening(object sender)
		{
			foreach (Bee b in allBees)
			{
				b.State = WorkingStates.працюю;
				Console.WriteLine($"Зараз {(sender as Sun)}. {b}");
			}
		}
		public static void onSunrise(object sender)
		{
			foreach (Bee b in allBees)
			{
				b.State = WorkingStates.працюю;
				Console.WriteLine($"Зараз {(sender as Sun)}. {b}");
			}
		}
	}
}
