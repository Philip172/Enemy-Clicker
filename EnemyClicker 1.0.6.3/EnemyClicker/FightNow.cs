namespace EnemyClicker
{
	public class FightNow
	{
		public int maxhealth;
		private int Health;
		private int Defend;
		public int reward;


		public int health
		{
			get
			{
				return Health;
			}
			set
			{
				if (value > int.MaxValue / 10)
				{
					Health = int.MaxValue / 10;
					return;
				}
				if (value < 0)
				{
					Health = 0;
					return;
				}

				Health = value;
			}
		}

		public int defend
		{
			get
			{
				return Defend;
			}
			set
			{
				if (value > int.MaxValue / 10)
				{
					Defend = int.MaxValue / 10;
					return;
				}
				if (value < 0)
				{
					Defend = 0;
					return;
				}

				Defend = value;
			}
		}
	}
}
