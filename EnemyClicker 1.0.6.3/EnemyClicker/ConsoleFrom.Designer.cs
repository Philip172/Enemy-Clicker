
namespace EnemyClicker
{
    partial class ConsoleFrom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsoleFrom));
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.cB_fastPasting = new System.Windows.Forms.CheckBox();
			this.cb_commands_list = new System.Windows.Forms.ComboBox();
			this.btn_add_command = new System.Windows.Forms.Button();
			this.tb_console = new System.Windows.Forms.TextBox();
			this.btn_closeConsole = new System.Windows.Forms.Button();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.cB_fastPasting);
			this.groupBox3.Controls.Add(this.cb_commands_list);
			this.groupBox3.Controls.Add(this.btn_add_command);
			this.groupBox3.Controls.Add(this.tb_console);
			this.groupBox3.Location = new System.Drawing.Point(13, 43);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox3.Size = new System.Drawing.Size(515, 278);
			this.groupBox3.TabIndex = 17;
			this.groupBox3.TabStop = false;
			// 
			// cB_fastPasting
			// 
			this.cB_fastPasting.AutoSize = true;
			this.cB_fastPasting.Checked = true;
			this.cB_fastPasting.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cB_fastPasting.Location = new System.Drawing.Point(188, 223);
			this.cB_fastPasting.Margin = new System.Windows.Forms.Padding(4);
			this.cB_fastPasting.Name = "cB_fastPasting";
			this.cB_fastPasting.Size = new System.Drawing.Size(153, 33);
			this.cB_fastPasting.TabIndex = 3;
			this.cB_fastPasting.Text = "fast pasting";
			this.cB_fastPasting.UseVisualStyleBackColor = true;
			// 
			// cb_commands_list
			// 
			this.cb_commands_list.BackColor = System.Drawing.Color.White;
			this.cb_commands_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cb_commands_list.ForeColor = System.Drawing.Color.Black;
			this.cb_commands_list.FormattingEnabled = true;
			this.cb_commands_list.Items.AddRange(new object[] {
            "reset_all_data",
            "disable_godmode",
            "disable_change_position_in_fight",
            "enable_godmode",
            "enable_change_position_in_fight",
            "get_money_",
            "get_brackets_",
            "set_player_streight_",
            "set_player_health_",
            "set_player_maxhealth_",
            "set_shans_of_hitting_",
            "set_money_",
            "set_helpers_streight_",
            "set_anti_stabilization_",
            "enable_punch_checking",
            "disable_punch_checking",
            "bust_gold_enable",
            "bust_gold_disnable"});
			this.cb_commands_list.Location = new System.Drawing.Point(8, 174);
			this.cb_commands_list.Margin = new System.Windows.Forms.Padding(4);
			this.cb_commands_list.Name = "cb_commands_list";
			this.cb_commands_list.Size = new System.Drawing.Size(498, 39);
			this.cb_commands_list.TabIndex = 2;
			this.cb_commands_list.SelectedIndexChanged += new System.EventHandler(this.cb_commands_list_SelectedIndexChanged);
			// 
			// btn_add_command
			// 
			this.btn_add_command.Location = new System.Drawing.Point(8, 81);
			this.btn_add_command.Margin = new System.Windows.Forms.Padding(4);
			this.btn_add_command.Name = "btn_add_command";
			this.btn_add_command.Size = new System.Drawing.Size(499, 63);
			this.btn_add_command.TabIndex = 1;
			this.btn_add_command.Text = "add command";
			this.btn_add_command.UseVisualStyleBackColor = true;
			this.btn_add_command.Click += new System.EventHandler(this.btn_add_command_Click);
			// 
			// tb_console
			// 
			this.tb_console.BackColor = System.Drawing.Color.White;
			this.tb_console.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tb_console.ForeColor = System.Drawing.Color.Black;
			this.tb_console.Location = new System.Drawing.Point(8, 35);
			this.tb_console.Margin = new System.Windows.Forms.Padding(4);
			this.tb_console.Name = "tb_console";
			this.tb_console.Size = new System.Drawing.Size(498, 38);
			this.tb_console.TabIndex = 0;
			// 
			// btn_closeConsole
			// 
			this.btn_closeConsole.Location = new System.Drawing.Point(12, 586);
			this.btn_closeConsole.Name = "btn_closeConsole";
			this.btn_closeConsole.Size = new System.Drawing.Size(515, 67);
			this.btn_closeConsole.TabIndex = 18;
			this.btn_closeConsole.Text = "Close console";
			this.btn_closeConsole.UseVisualStyleBackColor = true;
			this.btn_closeConsole.Click += new System.EventHandler(this.button1_Click);
			// 
			// ConsoleFrom
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(544, 679);
			this.Controls.Add(this.btn_closeConsole);
			this.Controls.Add(this.groupBox3);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(7);
			this.Name = "ConsoleFrom";
			this.Text = "CONSOLE";
			this.Load += new System.EventHandler(this.ConsoleFrom_Load);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cB_fastPasting;
        private System.Windows.Forms.ComboBox cb_commands_list;
        private System.Windows.Forms.Button btn_add_command;
        private System.Windows.Forms.TextBox tb_console;
        private System.Windows.Forms.Button btn_closeConsole;
    }
}