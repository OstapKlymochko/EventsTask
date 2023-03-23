using System;

namespace EventsTask
{
	enum SunStates
	{
		схід = 1,
		обід = 2,
		вечір = 3,
		захід = 4
	}
	class Sun
	{
		public delegate void MyEvent(object sender);
		public event MyEvent Sunrise;
		public event MyEvent Midday;
		public event MyEvent Evening;
		public event MyEvent Sunset;
        public string State { get; set; }
		public void sunUp()
		{
			this.State = SunStates.схід.ToString();
			if(this.Sunrise != null)
			{
				Sunrise(this);
			}
            Console.WriteLine("\n");
        }
		public void midday() 
		{
			this.State = SunStates.обід.ToString();
			if (this.Sunrise != null)
			{
				Midday(this);
			}
			Console.WriteLine("\n");

		}
		public void evening()
		{
			this.State = SunStates.вечір.ToString();
			if (this.Sunrise != null)
			{
				Evening(this);
			}
			Console.WriteLine("\n");

		}
		public void sunDown()
		{
			this.State = SunStates.захід.ToString();
			if (this.Sunset != null)
			{
				Sunset(this);
			}
			Console.WriteLine("\n");

		}
		public override string ToString()
		{
			return this.State;
		}
	}
	public class SunEventsArgument
	{
		public string Message{ get; set; }
		public SunEventsArgument(string msg)
		{
			Message = msg;
		}
	}
}
