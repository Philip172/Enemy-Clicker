using MyLib;
using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnemyClicker
{
	public partial class GameForm : Form
	{
		public static Random random = new Random();

		// Игрок уже победил или нет?
		bool player_won = false;

		// Противник
		FightNow Enemy;


		// Запуск конструктора при запуске формы
		public GameForm()
		{
			InitializeComponent();
		}


		// Действия при загрузке формы
		private void GameForm_Load(object sender, EventArgs e)
		{
			// Установка размеров формы
			this.Size = new Size(1650, 675);// 1650; 675

			// Установка размеров и позиции StartForm
			StartForm.Size = this.Size;
			StartForm.Location = new Point(0, 0);

			// Установка языка
			CultureInfo ci = CultureInfo.InstalledUICulture;
			Player.choosedLanguage = ci.TwoLetterISOLanguageName;
			switch (Player.choosedLanguage)
			{
				case "ru":
					Player.choosedLanguage_number = 0;
					break;

				case "en":
					Player.choosedLanguage_number = 0;
					break;
			}

			// Локализация StartForm
			switch (Player.choosedLanguage)
			{
				case "ru":
					btn_play.Text = AllLanguageManager.StartForm.ru.btn_play;
					btn_changeLang.Text = AllLanguageManager.StartForm.ru.btn_changeLang;
					btn_changelangresult.Text = AllLanguageManager.StartForm.ru.btn_changelangresult;
					break;

				case "en":
					btn_play.Text = AllLanguageManager.StartForm.en.btn_play;
					btn_changeLang.Text = AllLanguageManager.StartForm.en.btn_changeLang;
					btn_changelangresult.Text = AllLanguageManager.StartForm.en.btn_changelangresult;
					break;
			}
		}


		#region Functions
		// Изменение позиции курсора
		private void Change_cursor_position(int count)
		{
			// Получаем модуль от count
			count = Math.Abs(count);

			int x = random.Next(-count, count); // изменение x-координаты
			int y = random.Next(-count, count); // изменение y-координаты

			Cursor.Position = new Point
				(Cursor.Position.X + x, Cursor.Position.Y + y);
		}

		// Проверка - был ли удар
		private void Checking_if_punch()
		{
			int CursorPos_X = Cursor.Position.X - this.Left;
			int CursorPos_Y = Cursor.Position.Y - this.Top;

			if (
				CursorPos_Y - 15 > btn_enemyFight.Bottom
				||
				CursorPos_Y - 32 < btn_enemyFight.Top
				||
				CursorPos_X - 8 < btn_enemyFight.Left
				||
				CursorPos_X + 5 > btn_enemyFight.Right
				)
			{
				int damageToPlayer = EnemyStatisticOnLevels.EnemiesStreight[Player.currentlevel] - EnemyStatisticOnLevels.EnemiesStreight[Player.currentlevel] / 100 * Player.armor;
				if (damageToPlayer > 3)
					Player.health -= (EnemyStatisticOnLevels.EnemiesStreight[Player.currentlevel] - Player.armor);
				else
					Player.health -= 3;

				BackColor = Color.Red;
				EndPunchToPlayer.Start();
			}
		}

		// Обьявление нового противника
		private void Create_enemy(int lvl)
		{
			if (lvl >= 0 && lvl < EnemyStatisticOnLevels.EnemiesHealth.Length)
			{
				Enemy = new FightNow()
				{
					maxhealth = EnemyStatisticOnLevels.EnemiesHealth[lvl],
					health = EnemyStatisticOnLevels.EnemiesHealth[lvl],
					reward = EnemyStatisticOnLevels.EnemiesReward[lvl],
					defend = EnemyStatisticOnLevels.EnemiesDefend[lvl]
				};
			}
		}

		// Получение стоимости оружия
		private int GetCost(string pre_cost)
		{
			//выводим цифры из строки
			string resultString = string.Join(string.Empty, Regex.Matches(pre_cost, @"\d+").OfType<Match>().Select(m => m.Value));
			int.TryParse(resultString, out int cost);

			//возвращаем истинную стоимость
			return cost;
		}

		// Метод, происходящий при победе над последним противником
		private void PlayerHasWon()
		{
			Player.brackets += 10;
			Player.money += 555000;
			player_won = true;
			Timer_Player_has_won.Start();
			MessageBox.Show("Поздравляю! Вы прошли игру!");
		}
		#endregion


		#region Улучшения

		// Покупка аптечки
		private void buy_4_Click(object sender, EventArgs e)
		{
			if (Player.money >= 500)
			{
				DialogResult result;
				if (Player.health >= Player.MaxValues.player_health_max)
					result = MessageBox.Show("Вы уверены что хотите купить аптечку?\n(у вас макс. количество здоровья)", "", MessageBoxButtons.YesNo);
				else
					result = DialogResult.Yes;


				if (result == DialogResult.Yes)
				{
					//Такое кооличество жизней мы попытаемся прибавить
					int addingHeath = 24;

					Player.money -= 500;

					if (Player.health + addingHeath <= Player.MaxValues.player_health_max)// <=100
						Player.health += addingHeath;
					else
						Player.health = Player.MaxValues.player_health_max;// =100

					btn_buyFirstAidKit.Enabled = false;
					btn_buyFirstAidKit.BackColor = Color.Black;
					Timer_waitingForNewFirstAidKit.Start();
				}
			}
		}


		// comboBox с выбором оружия для покупки
		private void cB_chooseWeapons_SelectedIndexChanged(object sender, EventArgs e)
		{
			int numberWeaponSelect = cB_chooseWeapons.SelectedIndex; // номер выбранного сейчас оружия
			int numberWeaponWas = Player.weaponNumber; // номер оружия, что уже экипировно у игрока

			// Проверяем, является ли "новое" оружие действительно новым или же старым
			if (numberWeaponSelect == numberWeaponWas)
			{
				// Игроком было выбрано уже экипированное оружие
				//  а значит перекрашиваем label выбора оружий в зелёный
				lb_weapons.ForeColor = Color.Green;
			}
			else
			{
				// Игрок выбрал новое оружие
				//  а значит перекрашиваем label выбора оружий обратно в чёрный
				lb_weapons.ForeColor = Color.Black;
			}


			if (cB_chooseWeapons.SelectedIndex != 0)
			{
				int nextBuyTheWeaponText = GetCost(cB_chooseWeapons.Text);

				btn_buyTheWeapon.Text = $"buy the weapon ({nextBuyTheWeaponText} $)";
			}
			else
				btn_buyTheWeapon.Text = $"buy the weapon (??? $)";

		}

		// Покупка выбранного оружия из comboBox-а
		private void btn_buyTheWeapon_Click(object sender, EventArgs e)
		{
			// выясняем стоимость оружия
			int costBuyTheWeapon = GetCost(cB_chooseWeapons.Text);

			// если хватает денег, то покупаем оружжие
			if (Player.money >= costBuyTheWeapon && costBuyTheWeapon >= 0)
			{
				Player.money -= costBuyTheWeapon;
				Player.weaponNumber = cB_chooseWeapons.SelectedIndex;

				try
				{
					Player.streight = Weapons_characteristic.NextStreight[cB_chooseWeapons.SelectedIndex];
					Player.anti_stabilization = Weapons_characteristic.AntiStabilization[cB_chooseWeapons.SelectedIndex];
					Player.shans_of_hitting = Weapons_characteristic.Shans_of_hitting[cB_chooseWeapons.SelectedIndex];

					if (
						cB_chooseWeapons.SelectedIndex == 11 ||
						cB_chooseWeapons.SelectedIndex == 15 ||
						cB_chooseWeapons.SelectedIndex == 18
						)
					{
						int newLaserInterval = 0;

						switch (cB_chooseWeapons.SelectedIndex)
						{
							case 11:
								newLaserInterval = 50;
								break;

							case 15:
								newLaserInterval = 15;
								break;

							case 18:
								newLaserInterval = 10;
								break;

							case 19:
								newLaserInterval = 8;
								break;
						}

						laser_attack.Interval = newLaserInterval;
					}

					// Перекраска label выбора оружий в зелёный, поскольку выбранное оружие является только что купленным
					lb_weapons.ForeColor = Color.Green;
				}
				catch
				{
					MessageBox.Show("Вы не выбрали оружие!\nВыберите же оружие!");
				}
			}
		}
		#endregion



		#region Обзор возможности купить
		// Помощь в приведении строки к нужному формату
		string check_helper(string str, int mode)
		{
			if (mode == 0)
			{
				return str.Replace(" ", "").Replace("$", "").Replace(")", "").Replace("(", "");
			}
			return "0";
		}

		// Проверка на возможность покупки
		private void can_buy_Tick(object sender, EventArgs e)
		{
			// buy_theWeapon (покупка оружия)
			btn_buyTheWeapon.ForeColor = Player.money >= MyUniversal.VancedConvert.toInt(check_helper(btn_buyTheWeapon.Text, 0).Replace("buytheweapon", ""))
				? Color.Blue : Color.Red;

			// btn_buyTheArmor (покупка брони)
			btn_buyTheArmor.ForeColor = Player.money >= MyUniversal.VancedConvert.toInt(check_helper(btn_buyTheArmor.Text, 0).Replace("buythearmor", ""))
				? Color.Blue : Color.Red;

			// btn_buyTheHelper (покупка помощника)
			btn_buyTheHelper.ForeColor = Player.money >= MyUniversal.VancedConvert.toInt(check_helper(btn_buyTheHelper.Text, 0).Replace("buythehelper", ""))
				? Color.Blue : Color.Red;

			// buy_4 (купить аптечку)
			btn_buyFirstAidKit.ForeColor = Player.money >= MyUniversal.VancedConvert.toInt(check_helper(btn_buyFirstAidKit.Text, 0).Replace("buyfirst-aidkit", ""))
				? Color.Blue : Color.Red;
		}

		#endregion Обзор возможности купить


		// Помощник ударяет противника
		private void helpers_Tick(object sender, EventArgs e)
		{
			if (FightHelpers.helpers_streight != 0 && Enemy.health > 0)
			{
				Enemy.health -= FightHelpers.helpers_streight;
			}
		}



		// Перезарядка(получение) возможности купить аптечку
		private void waiting_for_new_first_aid_kit_Tick(object sender, EventArgs e)
		{
			btn_buyFirstAidKit.BackColor = SystemColors.ControlLight;
			btn_buyFirstAidKit.Enabled = true;
		}


		#region Активация/дезактивация groupbox-ов
		//Активация/дезактивация улучшений
		private void enable_Updates_Click(object sender, EventArgs e)
		{
			groupBox1.Visible = !groupBox1.Visible;
		}
		#endregion


		#region Битва с противником

		#region Смена уровня
		// Переключение на предыдущий уровень
		private void btn_GoToPrevousLevel_Click(object sender, EventArgs e)
		{
			btn_GoToNextLevel.Enabled = true;

			if (Player.currentlevel > 1)
				Player.currentlevel--;

			if (Player.currentlevel == 1)
				btn_GoToPrevousLevel.Enabled = false;

			Create_enemy(Player.currentlevel);
		}

		// Переключение на следующий уровень
		private void btn_GoToNextLevel_Click(object sender, EventArgs e)
		{
			// Оповещаем о переходе на финального босса
			if (Player.currentlevel == EnemyStatisticOnLevels.level_count_without_zero)//кол-во уровней противника мы получаем от количества переменных(жизни противника согласно уровню) в массиве
			{
				DialogResult mboxResult = MessageBox.Show("Вы уверены, что хотите перейти на финального босса?\nВы не сможете вернуться обратно", "", MessageBoxButtons.YesNo);
				if (mboxResult == DialogResult.Yes)
				{
					//Запрещаем переход обратно
					btn_GoToPrevousLevel.Enabled = false;

					//Увеличиваем уровень противника на 1
					Player.currentlevel++;

					//Создаём финального босса
					Create_enemy(Player.currentlevel);

					//Оповещаем игрока о вступлении в схватку с финальным боссом
					MessageBox.Show("Финал!");
				}
			}
			else if (Player.currentlevel <= EnemyStatisticOnLevels.level_count_without_zero)//кол-во уровней противника мы получаем от количества переменных(жизни противника согласно уровню) в массиве
			{
				// Увеличиваем уровень противника на 1
				Player.currentlevel++;

				// Добавить разрешения
				btn_GoToPrevousLevel.Enabled = true;
				if (Player.currentlevel >= EnemyStatisticOnLevels.level_count_without_zero)
					btn_GoToNextLevel.Enabled = false;

				// Создаём нового противника
				Create_enemy(Player.currentlevel);
			}
		}

		//Таймер, иполняющийся ежесекундно когда игрок победил последнего противника
		private void Player_has_won_Tick(object sender, EventArgs e)
		{
			Player.money += random.Next(15, 30);
		}
		#endregion

		//Удар на противника, перекрашевание его в другой цвет
		bool fireWeapon_isOn = false;
		private void btn_enemyFight_MouseClick(object sender, MouseEventArgs e)
		{
			if (Player.weaponNumber != 11 && Player.weaponNumber != 15 && Player.weaponNumber != 18)
			{
				//Проверяем левой ли кнопкой мыши нажал игрок,
				//  если нажал левой - выполняем тело
				if (e.Button == MouseButtons.Left && Enemy.health > 0)
				{
					if (Player.health > 0)
					{
						if (Console_parameters.change_position_in_fight)
							Change_cursor_position(Player.anti_stabilization);

						if (random.Next(100) < Player.shans_of_hitting)
						{
							int damage = 0;
							if (Player.streight - Enemy.defend > 0)
							{
								if (random.Next(10000) < Player.shans_of_ctritical_damage)
								{
									damage = Player.streight * Player.critical_damage_bet - Enemy.defend;

								}
								else
								{
									damage = Player.streight - Enemy.defend;

								}

								if (Player.weaponNumber == 16 && !fireWeapon_isOn)
									fireWeapon_isOn = true;

							}
							else
							{
								if (random.Next(10000) < Player.shans_of_ctritical_damage)
									damage = 2;
								else
									damage = 1;
							}
							Enemy.health -= damage;

							if (Player.weaponNumber == 14)
							{
								int health_regen = damage / 100;

								if (Player.health + health_regen <= Player.MaxValues.player_health_max)// <=100
									Player.health += health_regen;
								else
									Player.health = Player.MaxValues.player_health_max;// =100
							}
							if (Player.weaponNumber == 16)
								fireWeaponDamage.Start();


							Timer_btn_enemy_back.Stop();

							btn_enemyFight.BackColor = Color.Red;
							btn_enemyFight.Font = new Font("Microsoft Sans Serif", 28);
						}
						else
						{
							Timer_btn_enemy_back.Stop();
							btn_enemyFight.BackColor = Color.Yellow;
						}

						if (Enemy.health > 0 && !Console_parameters.godmode)
							Checking_if_punch();


						Timer_btn_enemy_back.Start();

						// Перепоказываем здоровье противника
						if (Enemy.health > 0)
							tb_enemyHealth.Text = $"{MyStrings.DivideToGradesEndlessNewVersion(Enemy.health)} / {MyStrings.DivideToGradesEndlessNewVersion(Enemy.maxhealth)}";
						else
							tb_enemyHealth.Text = $"0 / {MyStrings.DivideToGradesEndlessNewVersion(Enemy.maxhealth)}";
					}
					else
					{
						Change_cursor_position(100);

						int variants_count = 2;
						int variant = random.Next(variants_count);

						switch (variant)
						{
							case 1:
								MessageBox.Show("Всё, жизни на нуле, это конец...");
								break;

							default:
								MessageBox.Show("Вы мертвы, друг мой");
								break;
						}
					}
				}
			}
		}

		//Возврат изменённого ранее цвета противника
		private void btn_enemy_back_Tick(object sender, EventArgs e)
		{
			btn_enemyFight.BackColor = SystemColors.ControlLight;
			btn_enemyFight.Font = new Font("Microsoft Sans Serif", 35);
			Timer_btn_enemy_back.Stop();
		}

		//Удар по игроку
		private void punch_to_player_Tick(object sender, EventArgs e)
		{
			BackColor = SystemColors.Control;
			EndPunchToPlayer.Stop();
		}

		// Получение награды за убийство противника
		private void GetRewardFromKilledEnemy()
		{
			#region Получаем золото
			int bonus_gold = 0; // бонус в золоте, в %

			if (Boosts.enable_goldBoost)
				bonus_gold = 50;

			// Вычисляем награду
			int reward = (Enemy.reward + random.Next(-Enemy.reward / 10, Enemy.reward / 10));

			// Получаем награду
			Player.money += reward + reward * bonus_gold / 100;
			#endregion


			#region Получаем скобки
			// Вычисляем шанс получить скобки
			int power_toGet_brackets = 3000;//шанс, влияющий на шанс получения скобок(шанс больше->шанс получ. скобок больше)(шанс меньше->шанс получ. скобок меньше)
			int shans_toGet_brackets = (int)((Math.Pow(Player.currentlevel, 3) * power_toGet_brackets) / (Math.Pow(EnemyStatisticOnLevels.level_count_without_zero, 3)));

			// Получаем скобки
			if (random.Next(10000) + 1 <= shans_toGet_brackets)
				Player.brackets += 1;
			#endregion
		}

		//Проверка смерти противника
		private void Timer_if_enemy_killed_Tick(object sender, EventArgs e)
		{
			//Если жизни противника <= 0 , выполняем тело
			if (Enemy.health <= 0)
			{
				fireWeaponDamage.Stop();

				//Если уроень убитого противника >= 20 (И) Оружие игрока = 12 или 18, выполняем тело
				if (Player.currentlevel >= 20 && (Player.weaponNumber == 12 || Player.weaponNumber == 18))
				{
					switch (Player.weaponNumber)
					{
						//Меч крови
						case 12:
							Player.streight += 1;
							break;

						//Оружие от NotNick
						case 18://Не сделано
							break;
					}
				}

				//Проверяем, последний ли уровень у противника(босс), и, если да, выполняем код
				if (!player_won && Player.currentlevel == EnemyStatisticOnLevels.level_count_without_zero)
				{
					// Активируем снова возможность возврата на предыдущий уровень
					btn_GoToPrevousLevel.Visible = true;

					//Убийство финального босса и победа
					PlayerHasWon();
				}

				btn_enemyFight.BackColor = SystemColors.ControlLight;
				btn_enemyFight.Font = new Font("Microsoft Sans Serif", 35);

				//Получение награды за убийство противника
				GetRewardFromKilledEnemy();

				//Создание нового противника
				Create_enemy(Player.currentlevel);
			}
		}
		#endregion





		// Смерть игрока и оповещение о низком уровне здоровья
		int procentsOfHealth_player = 7;// проценты от жизней игрока, необходимые для его оповещения о низости уровня жизни
		private void healthIsNull_Tick(object sender, EventArgs e)
		{
			if (Player.health <= 0)
			{
				tb_health.BackColor = Color.Red;
				tb_health.ForeColor = Color.White;


				Player.streight = -1;
				Player.health = -1;
				FightHelpers.helpers_streight = -1;
				Player.anti_stabilization += 220;

				btn_enemyFight.ForeColor = Color.Red;
				btn_enemyFight.Text = "you losed";

				btn_buyTheHelper.Enabled = false;

				this.BackColor = Color.Red;
				EndPunchToPlayer.Stop();
				healthIsNull.Stop();
			}
			else if (Player.health <= Player.MaxValues.player_health_max / 100 * procentsOfHealth_player)
			{
				tb_health.BackColor = Color.Black;
				tb_health.ForeColor = Color.Red;
			}
			else
			{
				tb_health.ForeColor = Color.Black;
				tb_health.BackColor = Color.White;
			}
		}


		// Перезагрузка данных
		int procentsOfHealth_enemy = 11;// проценты от жизней противника, необходимые для оповещения пользователя
		private void Timer_reload_Tick(object sender, EventArgs e)
		{
			try
			{
				tb_money.Text = $"{MyStrings.DivideToGradesEndlessNewVersion(Player.money)} $";
				tb_brackets.Text = $"{MyStrings.DivideToGradesEndlessNewVersion(Player.brackets)} </>";
				tb_armor.Text = $"{MyStrings.DivideToGradesEndlessNewVersion(Player.armor)}";

				if (Enemy.health > 0)
					tb_enemyHealth.Text = $"{MyStrings.DivideToGradesEndlessNewVersion(Enemy.health)} / {MyStrings.DivideToGradesEndlessNewVersion(Enemy.maxhealth)}";
				else
					tb_enemyHealth.Text = $"0 / {MyStrings.DivideToGradesEndlessNewVersion(Enemy.maxhealth)}";

				tb_health.Text = MyStrings.DivideToGradesEndlessNewVersion(Player.health);

				double needHealth = (double)Enemy.maxhealth / 100 * procentsOfHealth_enemy;
				if (Enemy.health <= needHealth || Enemy.health <= 1)
				{
					tb_enemyHealth.BackColor = Color.Red;
					tb_enemyHealth.ForeColor = Color.White;
				}
				else
				{
					tb_enemyHealth.BackColor = Color.White;
					tb_enemyHealth.ForeColor = Color.Black;
				}

				switch (Player.choosedLanguage)
				{
					case "ru":
						Lb_currentLevel.Text = MyStrings.DivideToGradesEndlessNewVersion(Player.currentlevel) + " " + AllLanguageManager.GameForm.ru.Lb_currentLevel;
						break;

					case "en":
						Lb_currentLevel.Text = MyStrings.DivideToGradesEndlessNewVersion(Player.currentlevel) + " " + AllLanguageManager.GameForm.en.Lb_currentLevel;
						break;
				}
			}
			catch { }
		}


		// Запуск консоли
		private void button1_Click(object sender, EventArgs e)
		{
			new ConsoleFrom().ShowDialog();
		}

		// Атака лазером
		private void laser_attack_Tick(object sender, EventArgs e)
		{
			var rand = new Random();


			//Проверяем левой ли кнопкой мыши нажал игрок,
			//  если нажал левой - выполняем тело
			if (Enemy.health > 0)
			{
				if (Player.health > 0)
				{
					if (Console_parameters.change_position_in_fight)
						Change_cursor_position(Player.anti_stabilization);

					//Шанс попадания от лазеров = 100%
					if (Player.streight - Enemy.defend > 0)
					{
						if (random.Next(10000) < Player.shans_of_ctritical_damage)
							Enemy.health -= Player.streight * Player.critical_damage_bet - Enemy.defend;
						else
							Enemy.health -= Player.streight - Enemy.defend;
					}
					else
					{
						if (random.Next(10000) < Player.shans_of_ctritical_damage)
							Enemy.health -= 3;
						else
							Enemy.health -= 1;
					}

					Timer_btn_enemy_back.Stop();
					btn_enemyFight.BackColor = Color.Red;

					btn_enemyFight.Font = new Font("Microsoft Sans Serif", 28);

					if (Enemy.health > 0 && !Console_parameters.godmode)
						Checking_if_punch();


				}
			}

		}

		// Кнопка удара по противнику, нажатие
		private void btn_enemyFight_MouseDown(object sender, MouseEventArgs e)
		{
			if ((Player.weaponNumber == 11 || Player.weaponNumber == 15 || Player.weaponNumber == 18) && e.Button == MouseButtons.Left && Enemy.health > 0)
				laser_attack.Start();
		}

		// Кнопка удара по противнику, отжатие
		private void btn_enemyFight_MouseUp(object sender, MouseEventArgs e)
		{
			laser_attack.Stop();

			if (Player.weaponNumber == 11 && Player.weaponNumber == 15 && Player.weaponNumber == 18 && e.Button == MouseButtons.Left)
				Timer_btn_enemy_back.Start();
		}

		// Проверка получения урона на 'F'
		private void btn_enemyFight_KeyDown(object sender, KeyEventArgs e)
		{
			if (Console_parameters.Punch_checking)
			{
				if (e.KeyCode == Keys.F)
				{
					Checking_if_punch();
				}
				else if (e.KeyCode == Keys.H)
				{
					Player.health = 100000;
				}
			}
		}

		// Таймер урона противнику от огня
		private void fireWeaponDamage_Tick(object sender, EventArgs e)
		{
			int procents = 5;
			Enemy.health -= Weapons_characteristic.NextStreight[16] / 100 * procents;
		}

		private void cB_chooseArmor_SelectedIndexChanged(object sender, EventArgs e)
		{
			int numberArmorSelect = cB_chooseArmor.SelectedIndex; // номер выбранной сейчас брони
			int numberArmorWas = Player.armorNumber; // номер брони, что уже экипировна у игрока

			// Проверяем, является ли "новые" помощник действительно новым или же старым
			if (numberArmorSelect == numberArmorWas)
			{
				// Игроком была выбрана уже экипированная броня
				//  а значит перекрашиваем label выбора брони в зелёный
				lb_armor.ForeColor = Color.Green;
			}
			else
			{
				// Игрок выбрал новую броню
				//  а значит перекрашиваем label выбора брони обратно в чёрный
				lb_armor.ForeColor = Color.Black;
			}



			if (cB_chooseArmor.SelectedIndex != 0)
			{
				int nextBuyTheArmorText = GetCost(cB_chooseArmor.Text);

				btn_buyTheArmor.Text = $"buy the armor ({nextBuyTheArmorText} $)";
			}
			else
				btn_buyTheArmor.Text = $"buy the armor (??? $)";

		}

		// Покупка брони
		private void btn_buyTheArmor_Click(object sender, EventArgs e)
		{
			// выясняем стоимость оружия
			int costBuyTheArmor = GetCost(cB_chooseArmor.Text);

			// если хватает денег, то покупаем оружжие
			if (Player.money >= costBuyTheArmor && costBuyTheArmor >= 0)
			{
				Player.money -= costBuyTheArmor;
				Player.armorNumber = cB_chooseArmor.SelectedIndex;

				try
				{
					Player.armor = Armor_characteristic.NextDefence[cB_chooseArmor.SelectedIndex];

					if (cB_chooseArmor.SelectedIndex == 9)
					{
						healArmorHealing.Start();
					}
					else
					{
						healArmorHealing.Stop();
					}


					// Перекраска label выбора брони в зелёный, поскольку выбранная броня является только что купленной
					lb_armor.ForeColor = Color.Green;
				}
				catch
				{
					MessageBox.Show("Вы не выбрали броню!\nНужно выбрать броню!");
				}
			}
		}

		private void healArmorHealing_Tick(object sender, EventArgs e)
		{
			Player.health++;
		}

		// Старт игры, подготовка зоны игры
		private async void btn_play_Click(object sender, EventArgs e)
		{
			int actionsCount = 8,
				nonrealactions = 9,
				emptyactions = 3,
				falseactionsCount = 5,
				safevalue = 1;

			pb_play.Maximum =
				actionsCount + (Weapons_characteristic.WeaponsCount + FightHelpers.FightHelpersCount + Armor_characteristic.ArmorCount - emptyactions) - nonrealactions + falseactionsCount + safevalue;

			#region Actions
			pb_play.Visible = true; // показываем progressBar загрузки игры

			pb_play.Value++; // увеличиваем прогресс загрузки подготовки игры

			Create_enemy(1); // создаём противника 1 уровня

			pb_play.Value++; // увеличиваем прогресс загрузки подготовки игры

			// Запуск оповещения о возможностях покупки
			Timer_can_buy.Start();

			pb_play.Value++; // увеличиваем прогресс загрузки подготовки игры

			// Запуск проверки противника на его смерть
			Timer_if_enemy_killed.Start();

			pb_play.Value++; // увеличиваем прогресс загрузки подготовки игры

			// Запуск проверки игрока на его смерть
			healthIsNull.Start();

			pb_play.Value++; // увеличиваем прогресс загрузки подготовки игры

			// Запуск обновления данных
			Timer_reload.Start();

			pb_play.Value++; // увеличиваем прогресс загрузки подготовки игры

			// Запуск помощников
			Timer_helpers.Start();

			pb_play.Value++; // увеличиваем прогресс загрузки подготовки игры

			// Теперь combobox-ы только readonly, устанавливаем из default значения
			cB_chooseWeapons.DropDownStyle = ComboBoxStyle.DropDownList;
			cB_chooseArmor.DropDownStyle = ComboBoxStyle.DropDownList;
			cB_chooseHelpers.DropDownStyle = ComboBoxStyle.DropDownList;

			pb_play.Value++; // увеличиваем прогресс загрузки подготовки игры
			#endregion

			pb_play.Value++; // увеличиваем прогресс загрузки подготовки игры

			#region False actions
			// Заполнение combobox-а оружий
			cB_chooseWeapons.Items.Add("-");
			for (int i = 1; i < Weapons_characteristic.WeaponsCount; i++)
			{
				cB_chooseWeapons.Items.Add($"{Weapons_characteristic.WeaponNames[Player.choosedLanguage_number, i]} ({MyStrings.DivideToGradesEndlessNewVersion(Weapons_characteristic.WeaponsCost[i])} $)");

				pb_play.Value++; // увеличиваем прогресс загрузки подготовки игры
			}

			pb_play.Value++; // увеличиваем прогресс загрузки подготовки игры

			// Заполнение combobox-а помощников
			cB_chooseHelpers.Items.Add("-");
			for (int i = 1; i < FightHelpers.FightHelpersCount; i++)
			{
				cB_chooseHelpers.Items.Add($"{FightHelpers.Names[Player.choosedLanguage_number, i]} ({MyStrings.DivideToGradesEndlessNewVersion(FightHelpers.Cost[i])} $)");

				pb_play.Value++; // увеличиваем прогресс загрузки подготовки игры
			}

			pb_play.Value++; // увеличиваем прогресс загрузки подготовки игры


			// Заполнение combobox-а брони
			cB_chooseArmor.Items.Add("-");
			for (int i = 1; i < Armor_characteristic.ArmorCount; i++)
			{
				cB_chooseArmor.Items.Add($"{Armor_characteristic.ArmorNames[Player.choosedLanguage_number, i]} ({MyStrings.DivideToGradesEndlessNewVersion(Armor_characteristic.ArmorCost[i])} $)");
			}

			pb_play.Value++; // увеличиваем прогресс загрузки подготовки игры

			// Локализация
			switch (Player.choosedLanguage)
			{
				case "ru":
					Lb_Health_main.Text = AllLanguageManager.GameForm.ru.Lb_Health_main;
					Lb_Armor_main.Text = AllLanguageManager.GameForm.ru.Lb_Armor_main;
					Lb_enable_Updates.Text = AllLanguageManager.GameForm.ru.Lb_enable_Updates;
					lb_weapons.Text = AllLanguageManager.GameForm.ru.lb_weapons;
					btn_buyTheWeapon.Text = AllLanguageManager.GameForm.ru.btn_buyTheWeapon;
					btn_buyFirstAidKit.Text = AllLanguageManager.GameForm.ru.btn_buyFirstAidKit;
					btn_buyTheHelper.Text = AllLanguageManager.GameForm.ru.btn_buyTheHelper;
					btn_buyTheArmor.Text = AllLanguageManager.GameForm.ru.btn_buyTheArmor;
					lb_helpers.Text = AllLanguageManager.GameForm.ru.lb_helpers;
					lb_armor.Text = AllLanguageManager.GameForm.ru.lb_armor;
					Lb_Money.Text = AllLanguageManager.GameForm.ru.Lb_Money;
					btn_openConsole.Text = AllLanguageManager.GameForm.ru.btn_openConsole;
					break;

				case "en":
					Lb_Health_main.Text = AllLanguageManager.GameForm.en.Lb_Health_main;
					Lb_Armor_main.Text = AllLanguageManager.GameForm.en.Lb_Armor_main;
					Lb_enable_Updates.Text = AllLanguageManager.GameForm.en.Lb_enable_Updates;
					lb_weapons.Text = AllLanguageManager.GameForm.en.lb_weapons;
					btn_buyTheWeapon.Text = AllLanguageManager.GameForm.en.btn_buyTheWeapon;
					btn_buyFirstAidKit.Text = AllLanguageManager.GameForm.en.btn_buyFirstAidKit;
					btn_buyTheHelper.Text = AllLanguageManager.GameForm.en.btn_buyTheHelper;
					btn_buyTheArmor.Text = AllLanguageManager.GameForm.en.btn_buyTheArmor;
					lb_helpers.Text = AllLanguageManager.GameForm.en.lb_helpers;
					lb_armor.Text = AllLanguageManager.GameForm.en.lb_armor;
					Lb_Money.Text = AllLanguageManager.GameForm.en.Lb_Money;
					btn_openConsole.Text = AllLanguageManager.GameForm.en.btn_openConsole;
					break;
			}


			pb_play.Value += 2; // увеличиваем прогресс загрузки подготовки игры

			// Адаптация формы
			gB_GameForm.Location = new Point(0, 0);
			gB_GameForm.Size = this.Size;
			#endregion

			pb_play.Value = pb_play.Maximum; // увеличиваем прогресс загрузки подготовки игры

			await Task.Delay(680);

			StartForm.Visible = false;
		}

		private void cB_chooseHealper_SelectedIndexChanged(object sender, EventArgs e)
		{
			int numberHelperSelect = cB_chooseHelpers.SelectedIndex; // номер выбранного сейчас помощника
			int numberHelperWas = FightHelpers.helper_number; // номер помощника, что уже экипировно у игрока

			// Проверяем, является ли "новые" помощник действительно новым или же старым
			if (numberHelperSelect == numberHelperWas)
			{
				// Игроком был выбран уже экипированный помощник
				//  а значит перекрашиваем label выбора помощников в зелёный
				lb_helpers.ForeColor = Color.Green;
			}
			else
			{
				// Игрок выбрал нового помощника
				//  а значит перекрашиваем label выбора помощника обратно в чёрный
				lb_helpers.ForeColor = Color.Black;
			}


			if (cB_chooseHelpers.SelectedIndex != 0)
			{
				int nextBuyTheHelperText = GetCost(cB_chooseHelpers.Text);

				btn_buyTheHelper.Text = $"buy the helper ({nextBuyTheHelperText} $)";
			}
			else
				btn_buyTheHelper.Text = $"buy the helper (??? $)";

		}

		// Улучшение помощника игрока(который тоже бьёт противника)
		private void btn_buyTheHealper_Click(object sender, EventArgs e)
		{
			// выясняем стоимость помощника
			int costBuyTheHelper = GetCost(cB_chooseArmor.Text);

			// если хватает денег, то покупаем броню
			if (Player.money >= costBuyTheHelper && costBuyTheHelper >= 0)
			{
				Player.money -= costBuyTheHelper;
				FightHelpers.helper_number = cB_chooseHelpers.SelectedIndex;

				try
				{
					FightHelpers.helpers_streight = FightHelpers.Streight[FightHelpers.helper_number];
					Timer_helpers.Interval = FightHelpers.DamageInterval[FightHelpers.helper_number];

					// Перекраска label выбора помощников в зелёный, поскольку выбранный помощник является только что купленным
					lb_helpers.ForeColor = Color.Green;
				}
				catch
				{
					MessageBox.Show("Вы не выбрали помощника!\nНужно бы выбрать!");
				}
			}
		}

		// Активация возможности смены языка
		private void btn_changeLang_Click(object sender, EventArgs e)
		{
			btn_play.Enabled = false;
			btn_changeLang.Enabled = false;
			gB_ChangeLang.Visible = true;
		}

		// Смена языка
		private void btn_changelangresult_Click(object sender, EventArgs e)
		{
			// Сама смена языка
			switch (cB_changeLang.SelectedIndex)
			{
				case 0:
					//ru
					Player.choosedLanguage_number = 0;
					Player.choosedLanguage = "ru";
					break;

				case 1:
					//en
					Player.choosedLanguage_number = 1;
					Player.choosedLanguage = "en";
					break;
			}

			// Перелокализация
			switch (Player.choosedLanguage)
			{
				case "ru":
					btn_play.Text = AllLanguageManager.StartForm.ru.btn_play;
					btn_changeLang.Text = AllLanguageManager.StartForm.ru.btn_changeLang;
					btn_changelangresult.Text = AllLanguageManager.StartForm.ru.btn_changelangresult;
					break;

				case "en":
					btn_play.Text = AllLanguageManager.StartForm.en.btn_play;
					btn_changeLang.Text = AllLanguageManager.StartForm.en.btn_changeLang;
					btn_changelangresult.Text = AllLanguageManager.StartForm.en.btn_changelangresult;
					break;
			}

			gB_ChangeLang.Visible = false;
			btn_play.Enabled = true;
			btn_changeLang.Enabled = true;
		}
	}
}
