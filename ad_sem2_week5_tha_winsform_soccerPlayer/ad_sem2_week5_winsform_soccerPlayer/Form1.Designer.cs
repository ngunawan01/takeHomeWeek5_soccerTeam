namespace ad_sem2_week5_winsform_soccerPlayer
{
    partial class Form1
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
            this.labelSoccerTeamList = new System.Windows.Forms.Label();
            this.labelChooseCountry = new System.Windows.Forms.Label();
            this.labelChooseTeam = new System.Windows.Forms.Label();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.comboBoxTeam = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.labelTeamName = new System.Windows.Forms.Label();
            this.labelTeamCountry = new System.Windows.Forms.Label();
            this.labelTeamCity = new System.Windows.Forms.Label();
            this.textBoxNameTeam = new System.Windows.Forms.TextBox();
            this.textBoxCountryTeam = new System.Windows.Forms.TextBox();
            this.textBoxCityTeam = new System.Windows.Forms.TextBox();
            this.labelAddingTeam = new System.Windows.Forms.Label();
            this.buttonAddTeam = new System.Windows.Forms.Button();
            this.buttonAddPlayer = new System.Windows.Forms.Button();
            this.labelAddingPlayers = new System.Windows.Forms.Label();
            this.textBoxPlayerNumber = new System.Windows.Forms.TextBox();
            this.textBoxPlayerName = new System.Windows.Forms.TextBox();
            this.labelPlayerName = new System.Windows.Forms.Label();
            this.labelPlayerPosition = new System.Windows.Forms.Label();
            this.labelPlayerNumber = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxPlayerPosition = new System.Windows.Forms.ComboBox();
            this.labelTeamNamee = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSoccerTeamList
            // 
            this.labelSoccerTeamList.AutoSize = true;
            this.labelSoccerTeamList.Location = new System.Drawing.Point(41, 50);
            this.labelSoccerTeamList.Name = "labelSoccerTeamList";
            this.labelSoccerTeamList.Size = new System.Drawing.Size(112, 16);
            this.labelSoccerTeamList.TabIndex = 0;
            this.labelSoccerTeamList.Text = "Soccer Team List";
            // 
            // labelChooseCountry
            // 
            this.labelChooseCountry.AutoSize = true;
            this.labelChooseCountry.Location = new System.Drawing.Point(41, 92);
            this.labelChooseCountry.Name = "labelChooseCountry";
            this.labelChooseCountry.Size = new System.Drawing.Size(105, 16);
            this.labelChooseCountry.TabIndex = 1;
            this.labelChooseCountry.Text = "Choose Country:";
            // 
            // labelChooseTeam
            // 
            this.labelChooseTeam.AutoSize = true;
            this.labelChooseTeam.Location = new System.Drawing.Point(41, 137);
            this.labelChooseTeam.Name = "labelChooseTeam";
            this.labelChooseTeam.Size = new System.Drawing.Size(96, 16);
            this.labelChooseTeam.TabIndex = 2;
            this.labelChooseTeam.Text = "Choose Team:";
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(178, 92);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCountry.TabIndex = 3;
            this.comboBoxCountry.SelectedIndexChanged += new System.EventHandler(this.comboBoxCountry_SelectedIndexChanged);
            // 
            // comboBoxTeam
            // 
            this.comboBoxTeam.FormattingEnabled = true;
            this.comboBoxTeam.Location = new System.Drawing.Point(178, 134);
            this.comboBoxTeam.Name = "comboBoxTeam";
            this.comboBoxTeam.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTeam.TabIndex = 4;
            this.comboBoxTeam.SelectedIndexChanged += new System.EventHandler(this.comboBoxTeam_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(44, 191);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(255, 164);
            this.listBox1.TabIndex = 5;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(224, 377);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 6;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // labelTeamName
            // 
            this.labelTeamName.AutoSize = true;
            this.labelTeamName.Location = new System.Drawing.Point(326, 89);
            this.labelTeamName.Name = "labelTeamName";
            this.labelTeamName.Size = new System.Drawing.Size(0, 16);
            this.labelTeamName.TabIndex = 7;
            // 
            // labelTeamCountry
            // 
            this.labelTeamCountry.AutoSize = true;
            this.labelTeamCountry.Location = new System.Drawing.Point(326, 131);
            this.labelTeamCountry.Name = "labelTeamCountry";
            this.labelTeamCountry.Size = new System.Drawing.Size(94, 16);
            this.labelTeamCountry.TabIndex = 8;
            this.labelTeamCountry.Text = "Team Country:";
            // 
            // labelTeamCity
            // 
            this.labelTeamCity.AutoSize = true;
            this.labelTeamCity.Location = new System.Drawing.Point(326, 168);
            this.labelTeamCity.Name = "labelTeamCity";
            this.labelTeamCity.Size = new System.Drawing.Size(71, 16);
            this.labelTeamCity.TabIndex = 9;
            this.labelTeamCity.Text = "Team City:";
            // 
            // textBoxNameTeam
            // 
            this.textBoxNameTeam.Location = new System.Drawing.Point(427, 89);
            this.textBoxNameTeam.Name = "textBoxNameTeam";
            this.textBoxNameTeam.Size = new System.Drawing.Size(100, 22);
            this.textBoxNameTeam.TabIndex = 11;
            // 
            // textBoxCountryTeam
            // 
            this.textBoxCountryTeam.Location = new System.Drawing.Point(427, 127);
            this.textBoxCountryTeam.Name = "textBoxCountryTeam";
            this.textBoxCountryTeam.Size = new System.Drawing.Size(100, 22);
            this.textBoxCountryTeam.TabIndex = 12;
            // 
            // textBoxCityTeam
            // 
            this.textBoxCityTeam.Location = new System.Drawing.Point(427, 165);
            this.textBoxCityTeam.Name = "textBoxCityTeam";
            this.textBoxCityTeam.Size = new System.Drawing.Size(100, 22);
            this.textBoxCityTeam.TabIndex = 13;
            // 
            // labelAddingTeam
            // 
            this.labelAddingTeam.AutoSize = true;
            this.labelAddingTeam.Location = new System.Drawing.Point(438, 59);
            this.labelAddingTeam.Name = "labelAddingTeam";
            this.labelAddingTeam.Size = new System.Drawing.Size(89, 16);
            this.labelAddingTeam.TabIndex = 14;
            this.labelAddingTeam.Text = "Adding Team";
            // 
            // buttonAddTeam
            // 
            this.buttonAddTeam.Location = new System.Drawing.Point(452, 205);
            this.buttonAddTeam.Name = "buttonAddTeam";
            this.buttonAddTeam.Size = new System.Drawing.Size(75, 23);
            this.buttonAddTeam.TabIndex = 15;
            this.buttonAddTeam.Text = "Add";
            this.buttonAddTeam.UseVisualStyleBackColor = true;
            this.buttonAddTeam.Click += new System.EventHandler(this.buttonAddTeam_Click);
            // 
            // buttonAddPlayer
            // 
            this.buttonAddPlayer.Location = new System.Drawing.Point(679, 205);
            this.buttonAddPlayer.Name = "buttonAddPlayer";
            this.buttonAddPlayer.Size = new System.Drawing.Size(75, 23);
            this.buttonAddPlayer.TabIndex = 24;
            this.buttonAddPlayer.Text = "Add";
            this.buttonAddPlayer.UseVisualStyleBackColor = true;
            this.buttonAddPlayer.Click += new System.EventHandler(this.buttonAddPlayer_Click);
            // 
            // labelAddingPlayers
            // 
            this.labelAddingPlayers.AutoSize = true;
            this.labelAddingPlayers.Location = new System.Drawing.Point(665, 59);
            this.labelAddingPlayers.Name = "labelAddingPlayers";
            this.labelAddingPlayers.Size = new System.Drawing.Size(99, 16);
            this.labelAddingPlayers.TabIndex = 23;
            this.labelAddingPlayers.Text = "Adding Players";
            // 
            // textBoxPlayerNumber
            // 
            this.textBoxPlayerNumber.Location = new System.Drawing.Point(659, 127);
            this.textBoxPlayerNumber.Name = "textBoxPlayerNumber";
            this.textBoxPlayerNumber.Size = new System.Drawing.Size(100, 22);
            this.textBoxPlayerNumber.TabIndex = 21;
            this.textBoxPlayerNumber.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBoxPlayerName
            // 
            this.textBoxPlayerName.Location = new System.Drawing.Point(659, 89);
            this.textBoxPlayerName.Name = "textBoxPlayerName";
            this.textBoxPlayerName.Size = new System.Drawing.Size(100, 22);
            this.textBoxPlayerName.TabIndex = 20;
            // 
            // labelPlayerName
            // 
            this.labelPlayerName.AutoSize = true;
            this.labelPlayerName.Location = new System.Drawing.Point(553, 92);
            this.labelPlayerName.Name = "labelPlayerName";
            this.labelPlayerName.Size = new System.Drawing.Size(89, 16);
            this.labelPlayerName.TabIndex = 19;
            this.labelPlayerName.Text = "Player Name:";
            // 
            // labelPlayerPosition
            // 
            this.labelPlayerPosition.AutoSize = true;
            this.labelPlayerPosition.Location = new System.Drawing.Point(553, 168);
            this.labelPlayerPosition.Name = "labelPlayerPosition";
            this.labelPlayerPosition.Size = new System.Drawing.Size(100, 16);
            this.labelPlayerPosition.TabIndex = 18;
            this.labelPlayerPosition.Text = "Player Position:";
            // 
            // labelPlayerNumber
            // 
            this.labelPlayerNumber.AutoSize = true;
            this.labelPlayerNumber.Location = new System.Drawing.Point(553, 131);
            this.labelPlayerNumber.Name = "labelPlayerNumber";
            this.labelPlayerNumber.Size = new System.Drawing.Size(100, 16);
            this.labelPlayerNumber.TabIndex = 17;
            this.labelPlayerNumber.Text = "Player Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(553, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 16;
            // 
            // comboBoxPlayerPosition
            // 
            this.comboBoxPlayerPosition.FormattingEnabled = true;
            this.comboBoxPlayerPosition.Items.AddRange(new object[] {
            "GK",
            "DF",
            "MF",
            "FW"});
            this.comboBoxPlayerPosition.Location = new System.Drawing.Point(659, 165);
            this.comboBoxPlayerPosition.Name = "comboBoxPlayerPosition";
            this.comboBoxPlayerPosition.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPlayerPosition.TabIndex = 25;
            // 
            // labelTeamNamee
            // 
            this.labelTeamNamee.AutoSize = true;
            this.labelTeamNamee.Location = new System.Drawing.Point(326, 95);
            this.labelTeamNamee.Name = "labelTeamNamee";
            this.labelTeamNamee.Size = new System.Drawing.Size(86, 16);
            this.labelTeamNamee.TabIndex = 26;
            this.labelTeamNamee.Text = "Team Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTeamNamee);
            this.Controls.Add(this.comboBoxPlayerPosition);
            this.Controls.Add(this.buttonAddPlayer);
            this.Controls.Add(this.labelAddingPlayers);
            this.Controls.Add(this.textBoxPlayerNumber);
            this.Controls.Add(this.textBoxPlayerName);
            this.Controls.Add(this.labelPlayerName);
            this.Controls.Add(this.labelPlayerPosition);
            this.Controls.Add(this.labelPlayerNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonAddTeam);
            this.Controls.Add(this.labelAddingTeam);
            this.Controls.Add(this.textBoxCityTeam);
            this.Controls.Add(this.textBoxCountryTeam);
            this.Controls.Add(this.textBoxNameTeam);
            this.Controls.Add(this.labelTeamCity);
            this.Controls.Add(this.labelTeamCountry);
            this.Controls.Add(this.labelTeamName);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBoxTeam);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.labelChooseTeam);
            this.Controls.Add(this.labelChooseCountry);
            this.Controls.Add(this.labelSoccerTeamList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSoccerTeamList;
        private System.Windows.Forms.Label labelChooseCountry;
        private System.Windows.Forms.Label labelChooseTeam;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.ComboBox comboBoxTeam;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label labelTeamName;
        private System.Windows.Forms.Label labelTeamCountry;
        private System.Windows.Forms.Label labelTeamCity;
        private System.Windows.Forms.TextBox textBoxNameTeam;
        private System.Windows.Forms.TextBox textBoxCountryTeam;
        private System.Windows.Forms.TextBox textBoxCityTeam;
        private System.Windows.Forms.Label labelAddingTeam;
        private System.Windows.Forms.Button buttonAddTeam;
        private System.Windows.Forms.Button buttonAddPlayer;
        private System.Windows.Forms.Label labelAddingPlayers;
        private System.Windows.Forms.TextBox textBoxPlayerNumber;
        private System.Windows.Forms.TextBox textBoxPlayerName;
        private System.Windows.Forms.Label labelPlayerName;
        private System.Windows.Forms.Label labelPlayerPosition;
        private System.Windows.Forms.Label labelPlayerNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxPlayerPosition;
        private System.Windows.Forms.Label labelTeamNamee;
    }
}

