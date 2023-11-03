namespace pHelper
{
    partial class pHelper
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.colorTimer = new System.Windows.Forms.Timer(this.components);
            this.cWeatherLabel = new System.Windows.Forms.Label();
            this.weatherListComboBox = new System.Windows.Forms.ComboBox();
            this.weatherUpdateButton = new System.Windows.Forms.Button();
            this.weatherSetButton = new System.Windows.Forms.Button();
            this.weatherIdTextBox = new System.Windows.Forms.TextBox();
            this.cWeatherIdLabel = new System.Windows.Forms.Label();
            this.timeListComboBox = new System.Windows.Forms.ComboBox();
            this.setTimeLabel = new System.Windows.Forms.Label();
            this.timeSetButton = new System.Windows.Forms.Button();
            this.timeUpdateButton = new System.Windows.Forms.Button();
            this.timeIntTextBox = new System.Windows.Forms.TextBox();
            this.cTimeLabel = new System.Windows.Forms.Label();
            this.closeTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_game = new System.Windows.Forms.ComboBox();
            this.closeCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // colorTimer
            // 
            this.colorTimer.Enabled = true;
            this.colorTimer.Interval = 1;
            this.colorTimer.Tick += new System.EventHandler(this.colorTimer_Tick);
            // 
            // cWeatherLabel
            // 
            this.cWeatherLabel.AutoSize = true;
            this.cWeatherLabel.Location = new System.Drawing.Point(131, 71);
            this.cWeatherLabel.Name = "cWeatherLabel";
            this.cWeatherLabel.Size = new System.Drawing.Size(126, 18);
            this.cWeatherLabel.TabIndex = 5;
            this.cWeatherLabel.Text = "Смена погоды";
            // 
            // weatherListComboBox
            // 
            this.weatherListComboBox.FormattingEnabled = true;
            this.weatherListComboBox.Items.AddRange(new object[] {
            "[0] EXTRASUNNY_LA (голубое небо и облака)",
            "[1] SUNNY_LA (голубое небо и облака)",
            "[2] EXTRASUNNY_SMOG_LA (голубое небо и облака)",
            "[3] SUNNY_SMOG_LA (голубое небо и облака)",
            "[4] CLOUDY_LA (голубое небо и облака)",
            "[5] SUNNY_SF",
            "[6] EXTRASUNNY_SF",
            "[7] CLOUDY_SF",
            "[8] RAINY_SF (дождь)",
            "[9] FOGGY_SF (туман)",
            "[10] SUNNY_VEGAS (ясно и сухо)",
            "[11] EXTRASUNNY_VEGAS (ясно и сухо)",
            "[12] CLOUDY_VEGAS (ясно и сухо)",
            "[13] EXTRASUNNY_COUNTRYSIDE",
            "[14] SUNNY_COUNTRYSIDE",
            "[15] CLOUDY_COUNTRYSIDE",
            "[16] RAINY_COUNTRYSIDE (гроза)",
            "[17] EXTRASUNNY_DESERT",
            "[18] SUNNY_DESERT",
            "[19] SANDSTORM_DESERT (песчаная буря)",
            "[20] UNDERWATER (грязь, плохая видимость)",
            "[21] EXTRACOLOURS_1 (фиолетовое/белое)",
            "[22] EXTRACOLOURS_2 (черное/белое)",
            "[23] Бледно-оранжевая погода",
            "[24] Бледно-оранжевая погода",
            "[25] Бледно-оранжевая погода",
            "[26] Бледно-оранжевая погода",
            "[27] Свежая синяя погода",
            "[28] Свежая синяя погода",
            "[29] Свежая синяя погода",
            "[30] Темная, облачная, синеватая погода",
            "[31] Темная, облачная, синеватая погода",
            "[32] Темная, облачная, синеватая погода",
            "[33] Темная, облачная, бурая погода",
            "[34] Сине-фиолетовая, постоянная погода"});
            this.weatherListComboBox.Location = new System.Drawing.Point(12, 113);
            this.weatherListComboBox.Name = "weatherListComboBox";
            this.weatherListComboBox.Size = new System.Drawing.Size(373, 26);
            this.weatherListComboBox.TabIndex = 4;
            this.weatherListComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // weatherUpdateButton
            // 
            this.weatherUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.weatherUpdateButton.Location = new System.Drawing.Point(12, 211);
            this.weatherUpdateButton.Name = "weatherUpdateButton";
            this.weatherUpdateButton.Size = new System.Drawing.Size(188, 35);
            this.weatherUpdateButton.TabIndex = 3;
            this.weatherUpdateButton.Text = "Обновить";
            this.weatherUpdateButton.UseVisualStyleBackColor = true;
            this.weatherUpdateButton.Click += new System.EventHandler(this.weatherUpdateButton_Click);
            // 
            // weatherSetButton
            // 
            this.weatherSetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.weatherSetButton.Location = new System.Drawing.Point(206, 211);
            this.weatherSetButton.Name = "weatherSetButton";
            this.weatherSetButton.Size = new System.Drawing.Size(179, 35);
            this.weatherSetButton.TabIndex = 2;
            this.weatherSetButton.Text = "Установить";
            this.weatherSetButton.UseVisualStyleBackColor = true;
            this.weatherSetButton.Click += new System.EventHandler(this.weatherSetButton_Click);
            // 
            // weatherIdTextBox
            // 
            this.weatherIdTextBox.Location = new System.Drawing.Point(12, 178);
            this.weatherIdTextBox.Name = "weatherIdTextBox";
            this.weatherIdTextBox.Size = new System.Drawing.Size(373, 27);
            this.weatherIdTextBox.TabIndex = 1;
            // 
            // cWeatherIdLabel
            // 
            this.cWeatherIdLabel.AutoSize = true;
            this.cWeatherIdLabel.Location = new System.Drawing.Point(101, 156);
            this.cWeatherIdLabel.Name = "cWeatherIdLabel";
            this.cWeatherIdLabel.Size = new System.Drawing.Size(191, 18);
            this.cWeatherIdLabel.TabIndex = 0;
            this.cWeatherIdLabel.Text = "Смена погоды (по ID)";
            // 
            // timeListComboBox
            // 
            this.timeListComboBox.FormattingEnabled = true;
            this.timeListComboBox.Items.AddRange(new object[] {
            "День",
            "Ночь"});
            this.timeListComboBox.Location = new System.Drawing.Point(503, 113);
            this.timeListComboBox.Name = "timeListComboBox";
            this.timeListComboBox.Size = new System.Drawing.Size(369, 26);
            this.timeListComboBox.TabIndex = 1;
            this.timeListComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // setTimeLabel
            // 
            this.setTimeLabel.AutoSize = true;
            this.setTimeLabel.Location = new System.Drawing.Point(613, 71);
            this.setTimeLabel.Name = "setTimeLabel";
            this.setTimeLabel.Size = new System.Drawing.Size(137, 18);
            this.setTimeLabel.TabIndex = 0;
            this.setTimeLabel.Text = "Смена времени";
            // 
            // timeSetButton
            // 
            this.timeSetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timeSetButton.Location = new System.Drawing.Point(693, 211);
            this.timeSetButton.Name = "timeSetButton";
            this.timeSetButton.Size = new System.Drawing.Size(179, 35);
            this.timeSetButton.TabIndex = 3;
            this.timeSetButton.Text = "Установить";
            this.timeSetButton.UseVisualStyleBackColor = true;
            this.timeSetButton.Click += new System.EventHandler(this.timeSetButton_Click);
            // 
            // timeUpdateButton
            // 
            this.timeUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timeUpdateButton.Location = new System.Drawing.Point(508, 211);
            this.timeUpdateButton.Name = "timeUpdateButton";
            this.timeUpdateButton.Size = new System.Drawing.Size(179, 35);
            this.timeUpdateButton.TabIndex = 2;
            this.timeUpdateButton.Text = "Обновить";
            this.timeUpdateButton.UseVisualStyleBackColor = true;
            this.timeUpdateButton.Click += new System.EventHandler(this.timeUpdateButton_Click);
            // 
            // timeIntTextBox
            // 
            this.timeIntTextBox.Location = new System.Drawing.Point(503, 178);
            this.timeIntTextBox.Name = "timeIntTextBox";
            this.timeIntTextBox.Size = new System.Drawing.Size(369, 27);
            this.timeIntTextBox.TabIndex = 1;
            // 
            // cTimeLabel
            // 
            this.cTimeLabel.AutoSize = true;
            this.cTimeLabel.Location = new System.Drawing.Point(589, 157);
            this.cTimeLabel.Name = "cTimeLabel";
            this.cTimeLabel.Size = new System.Drawing.Size(233, 18);
            this.cTimeLabel.TabIndex = 0;
            this.cTimeLabel.Text = "Смена времени (по часам)";
            // 
            // closeTimer
            // 
            this.closeTimer.Interval = 500;
            this.closeTimer.Tick += new System.EventHandler(this.closeTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Автор: vk.com/Drygok : by Forever Young";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox_game
            // 
            this.comboBox_game.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_game.FormattingEnabled = true;
            this.comboBox_game.Items.AddRange(new object[] {
            "Amazing RP",
            "SAMP/CRMP 0.3.7 R3"});
            this.comboBox_game.Location = new System.Drawing.Point(19, 323);
            this.comboBox_game.Name = "comboBox_game";
            this.comboBox_game.Size = new System.Drawing.Size(840, 26);
            this.comboBox_game.TabIndex = 10;
            this.comboBox_game.SelectedIndexChanged += new System.EventHandler(this.comboBox_game_SelectedIndexChanged);
            // 
            // closeCheckBox
            // 
            this.closeCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeCheckBox.AutoSize = true;
            this.closeCheckBox.Location = new System.Drawing.Point(630, 295);
            this.closeCheckBox.Name = "closeCheckBox";
            this.closeCheckBox.Size = new System.Drawing.Size(255, 22);
            this.closeCheckBox.TabIndex = 11;
            this.closeCheckBox.Text = "Закрывать игру по Alt+End";
            this.closeCheckBox.UseVisualStyleBackColor = true;
            this.closeCheckBox.CheckedChanged += new System.EventHandler(this.closeCheckBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Выберите игру";
            // 
            // pHelper
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(884, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timeSetButton);
            this.Controls.Add(this.timeListComboBox);
            this.Controls.Add(this.timeUpdateButton);
            this.Controls.Add(this.weatherSetButton);
            this.Controls.Add(this.timeIntTextBox);
            this.Controls.Add(this.setTimeLabel);
            this.Controls.Add(this.cTimeLabel);
            this.Controls.Add(this.weatherUpdateButton);
            this.Controls.Add(this.cWeatherLabel);
            this.Controls.Add(this.closeCheckBox);
            this.Controls.Add(this.weatherIdTextBox);
            this.Controls.Add(this.weatherListComboBox);
            this.Controls.Add(this.cWeatherIdLabel);
            this.Controls.Add(this.comboBox_game);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MinimumSize = new System.Drawing.Size(900, 400);
            this.Name = "pHelper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pHelper";
            this.Load += new System.EventHandler(this.pHelper_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer colorTimer;
        private System.Windows.Forms.Label cWeatherLabel;
        private System.Windows.Forms.ComboBox weatherListComboBox;
        private System.Windows.Forms.Label cWeatherIdLabel;
        private System.Windows.Forms.Button weatherUpdateButton;
        private System.Windows.Forms.Button weatherSetButton;
        private System.Windows.Forms.TextBox weatherIdTextBox;
        private System.Windows.Forms.ComboBox timeListComboBox;
        private System.Windows.Forms.Label setTimeLabel;
        private System.Windows.Forms.Label cTimeLabel;
        private System.Windows.Forms.Button timeSetButton;
        private System.Windows.Forms.Button timeUpdateButton;
        private System.Windows.Forms.TextBox timeIntTextBox;
        private System.Windows.Forms.Timer closeTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_game;
        private System.Windows.Forms.CheckBox closeCheckBox;
        private System.Windows.Forms.Label label2;
    }
}

