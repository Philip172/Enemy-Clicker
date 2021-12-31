using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnemyClicker
{
	public partial class ConsoleFrom : Form
	{
		public ConsoleFrom()
		{
			InitializeComponent();
		}

		private void btn_add_command_Click(object sender, EventArgs e)
		{
			#region Настраиваемые читы
			if (tb_console.Text.Contains("get_money_"))
			{
				int.TryParse(tb_console.Text.Replace("get_money_", ""), out int add_money);
				Player.money += add_money;
			}
			else if (tb_console.Text.Contains("get_brackets_"))
			{
				int.TryParse(tb_console.Text.Replace("get_brackets_", ""), out int add_brackets);
				Player.brackets += add_brackets;
			}
			else if (tb_console.Text.Contains("set_player_streight_"))
			{
				int.TryParse(tb_console.Text.Replace("set_player_streight_", ""), out int change);
				Player.streight = change;
			}
			else if (tb_console.Text.Contains("set_player_health_"))
			{
				int.TryParse(tb_console.Text.Replace("set_player_health_", ""), out int change);
				Player.health = change;
			}
			else if (tb_console.Text.Contains("set_player_maxhealth_"))
			{
				int.TryParse(tb_console.Text.Replace("set_player_maxhealth_", ""), out int change);
				Player.MaxValues.player_health_max = change;
			}
			else if (tb_console.Text.Contains("set_shans_of_hitting_"))
			{
				int.TryParse(tb_console.Text.Replace("set_shans_of_hitting_", ""), out int change);
				Player.shans_of_hitting = change;
			}
			else if (tb_console.Text.Contains("set_money_"))
			{
				int.TryParse(tb_console.Text.Replace("set_money_", ""), out int change);
				Player.money = change;
			}
			else if (tb_console.Text.Contains("set_helpers_streight_"))
			{
				int.TryParse(tb_console.Text.Replace("set_helpers_streight_", ""), out int change);
				FightHelpers.helpers_streight = change;
			}
			else if (tb_console.Text.Contains("set_anti_stabilization_"))
			{
				int.TryParse(tb_console.Text.Replace("set_anti_stabilization_", ""), out int change);
				Player.anti_stabilization = Math.Abs(change);
			}
			#endregion


			#region Ненастраиваемые читы
			switch (tb_console.Text.Replace(" ", ""))
			{
				// Включение/отключение бессмертия
				case "enable_godmode":
					Console_parameters.godmode = true;
					MessageBox.Show("godmode is enabled");
					break;
				case "disable_godmode":
					Console_parameters.godmode = false;
					MessageBox.Show("godmode is disabled");
					break;

				// Включение/отключение изменения позиции при ударе
				case "enable_change_position_in_fight":
					Console_parameters.change_position_in_fight = true;
					MessageBox.Show("now cursor's position will be changed after click");
					break;
				case "disable_change_position_in_fight":
					Console_parameters.change_position_in_fight = false;
					MessageBox.Show("now cursor's position will not be changed after click");
					break;

				// Включение/отключение проверки удара
				case "enable_punch_checking":
					Console_parameters.Punch_checking = true;
					MessageBox.Show("punch checking is enabled");
					break;
				case "disable_punch_checking":
					Console_parameters.Punch_checking = false;
					MessageBox.Show("punch checking is disabled");
					break;

				// Получение максимального уроян игроком
				case "get_level_max":
					Player.weaponNumber = Weapons_characteristic.WeaponsCount - 1;
					Player.money = 1000000000;
					Player.brackets = 1000000;
					Player.streight = Weapons_characteristic.NextStreight[Weapons_characteristic.NextStreight.Length - 1];
					Player.anti_stabilization = Weapons_characteristic.AntiStabilization[Weapons_characteristic.NextStreight.Length - 1];
					Player.shans_of_hitting = Weapons_characteristic.Shans_of_hitting[Weapons_characteristic.NextStreight.Length - 1];
					MessageBox.Show("DONE");
					break;



				// Включение/отключение буста на золото
				case "bust_gold_enable":
					Boosts.enable_goldBoost = true;
					MessageBox.Show("gold boost is enabled");
					break;
				case "bust_gold_disnable":
					Boosts.enable_goldBoost = false;
					MessageBox.Show("gold boost is disabled");
					break;

				// Очистка всех данных
				case "reset_all_data":
					{
						#region Игрок
						// Основные характеристики

						// Язык
						Player.choosedLanguage = "ru";
						Player.choosedLanguage_number = 0;

						// Валюты
						Player.money = 0;// Деньги
						Player.brackets = 0;// Скобки

						// Основные характеристики: Сила
						Player.weaponNumber = 0;// Номер оружия
						Player.streight = 1;// Сила игрока
						Player.shans_of_hitting = 98;// Шанс попадания
						Player.anti_stabilization = 10;// Разброс при ударе
						Player.shans_of_ctritical_damage = 1;// Шанс критического урона
						Player.critical_damage_bet = 3;// Множитель критического урона

						// Основные характеристики: Устойчивость
						Player.health = 100;// Здоровье игрока
						Player.armorNumber = 0;// Номер брони
						Player.armor = 0;// Броня игрока

						// Основные характеристики: Уровень
						Player.currentlevel = 1;// Уровень в данный момент

						// Максимальные значения
						Player.MaxValues.player_health_max = 100;// Макс. здоровье игрока
						#endregion

						#region Бусты
						Boosts.enable_goldBoost = false;
						#endregion

						MessageBox.Show("Приложение будет перезапущено!");

						Application.Restart();
					}
					break;
			}
			#endregion
		}

		private void cb_commands_list_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cB_fastPasting.Checked)
				tb_console.Text = cb_commands_list.Text;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
		}


		private void ConsoleFrom_Load(object sender, EventArgs e)
		{
			//Локализация
			switch (Player.choosedLanguage)
			{
				case "ru":
					btn_add_command.Text = AllLanguageManager.ConsoleForm.ru.btn_add_command;
					cB_fastPasting.Text = AllLanguageManager.ConsoleForm.ru.cB_fastPasting;
					btn_closeConsole.Text = AllLanguageManager.ConsoleForm.ru.btn_closeConsole;
					break;
				case "en":
					btn_add_command.Text = AllLanguageManager.ConsoleForm.en.btn_add_command;
					cB_fastPasting.Text = AllLanguageManager.ConsoleForm.en.cB_fastPasting;
					btn_closeConsole.Text = AllLanguageManager.ConsoleForm.en.btn_closeConsole;
					break;
			}
		}
	}
}
