using System;
using System.Text;
using static EventsTask.Program;

namespace EventsTask
{
	class Girl
	{
		private string name;
        public daysOfWeek DayOfWeek { get; set; }
		public WorkingStates State { get; set; }
		public Girl(string _name = "", daysOfWeek day = daysOfWeek.понеділок) 
		{
			this.name = _name;
			this.DayOfWeek = day;
		}
		public override string ToString()
		{
			return $"Я {name}.";
		}
		public void onSunset(object sender)
		{
			this.State = WorkingStates.сплю;
			Console.WriteLine($"{this} Сьогоднi {this.DayOfWeek}, зараз {(sender as Sun).State} сонця i я {this.State}");
		}
		public void onMidday(object sender)
		{
			string ending = string.Empty;
			if (this.DayOfWeek == daysOfWeek.субота || this.DayOfWeek == daysOfWeek.неділя)
			{
				this.State = WorkingStates.відпочиваю;
				ending = "Нюхаю деннi квiти i роблю селфi.";
			}
			else
			{
				this.State = WorkingStates.працюю;
            }
			Console.WriteLine($"{this} Сьогоднi {this.DayOfWeek}, зараз {(sender as Sun).State} i я {this.State}. {ending}");
		}
		public void onEvening(object sender)
		{
			this.State = WorkingStates.відпочиваю;
			Console.WriteLine($"{this} Сьогоднi {this.DayOfWeek}, зараз {(sender as Sun).State} i я {this.State}. Нюхаю вечiрнi квiти i роблю селфi.");
		}
		public void onSunrise(object sender)
		{
			if (this.DayOfWeek == daysOfWeek.субота || this.DayOfWeek == daysOfWeek.неділя)
			{
				this.State = WorkingStates.сплю;

			}
			else
			{
				this.State = WorkingStates.працюю;
			}
			Console.WriteLine($"{this} Сьогоднi {this.DayOfWeek}, зараз {(sender as Sun).State} сонця i я {this.State}");
		}
	}
}
