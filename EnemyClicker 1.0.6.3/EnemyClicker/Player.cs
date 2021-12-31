namespace EnemyClicker
{
	public static class Player
	{
		// Основные характеристики

		// Язык
		public static string choosedLanguage = "ru";
		public static int choosedLanguage_number = 0;

		// Валюты
		private static long Money = 0;// Деньги
		private static long Brackets = 0;// Скобки

		// Основные характеристики: Сила
		public static int weaponNumber = 0;// Номер оружия
		public static int streight = 1;// Сила игрока
		public static int shans_of_hitting = 98;// Шанс попадания
		public static int anti_stabilization = 10;// Разброс при ударе
		public static int shans_of_ctritical_damage = 1;// Шанс критического урона
		public static int critical_damage_bet = 3;// Множитель критического урона

		// Основные характеристики: Устойчивость
		private static long Health = 100;// Здоровье игрока
		public static int armorNumber = 0;// Номер брони
		public static int armor = 0;// Броня игрока

		// Основные характеристики: Уровень
		public static int currentlevel = 1;// Уровень в данный момент

		// Максимальные значения
		public static class MaxValues
		{
			public static int player_health_max = 100;// Макс. здоровье игрока
		}



		// Контроллеры

		// Деньги
		public static long money
		{
			get
			{
				return Money;
			}
			set
			{
				if (value > long.MaxValue / 10)
				{
					Money = long.MaxValue / 10;
					return;
				}

				Money = value;
			}
		}

		// Скобки
		public static long brackets
		{
			get
			{
				return Brackets;
			}
			set
			{
				if (value > long.MaxValue / 10)
				{
					Brackets = long.MaxValue / 10;
					return;
				}

				Brackets = value;
			}
		}

		// Здоровье
		public static long health
		{
			get
			{
				return Health;
			}
			set
			{
				if (value > MaxValues.player_health_max)
				{
					Health = MaxValues.player_health_max;
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
	}
}
