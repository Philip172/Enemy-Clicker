namespace EnemyClicker
{
	public static class FightHelpers
	{
		readonly public static string[,] Names =
		{
			//ru
			{
			"",
			"Иван",
			"Рыцарь-мастер",
			"Профессиональный перчаточник",
			"Скоростная дёргалка",
			"Убийца богов",
			"Лазерный андроид",
			},

			//en
			{
			"",
			"Gabriel",
			"Knight master",
			"Professional glover",
			"Speedy twitch",
			"The god killer",
			"Laser android",
			}
		};

		readonly public static int[] Cost =
		{
			0,
			50, // Иван
			180, // Рыцарь-мастер
			800, // Профессиональный перчаточник
			8000, // Скоростная дёргалка
			100000, // Убийца богов
			1200000, // Лазерный андроид
		};

		readonly public static int[] Streight =
		{
			0,
			1, // Иван
			8, // Рыцарь-мастер
			80, // Профессиональный перчаточник
			3, // Скоростная дёргалка
			30000, // Убийца богов
			75, // Лазерный андроид
		};

		readonly public static int[] DamageInterval =
		{
			0,
			1000, // Иван
			900, // Рыцарь-мастер
			8500, // Профессиональный перчаточник
			100, // Скоростная дёргалка
			30000, // Убийца богов
			50, // Лазерный андроид
		};


		// Количество оружий
		public static int FightHelpersCount = Names.GetLength(1);

		// Статистика
		public static int helpers_streight = 0; // Урон помощника
		public static int update_helper_cost = 40; // Стоимость улучшения помощника
		public static int helper_number = 0; // Номер помощника сейчас
	}
}
