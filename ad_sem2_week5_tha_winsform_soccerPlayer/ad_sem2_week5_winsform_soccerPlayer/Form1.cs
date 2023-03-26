using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ad_sem2_week5_winsform_soccerPlayer
{
    public partial class Form1 : Form
    {
        List<Team> listTeam = new List<Team>();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Team newTeam1 = new Team("Real Madrid", "Spain", "Madrid");
            Team newTeam2 = new Team("Manchester United", "England", "Manchester");
            Team newTeam3 = new Team("Liverpool FC", "England", "Livepool");
            listTeam.Add(newTeam1);
            listTeam.Add(newTeam2);
            listTeam.Add(newTeam3);
            newTeam1.player.Add(new Player("Thibat Courtouis", "01", "GK"));
            newTeam1.player.Add(new Player("Eder Militao", "03", "DF"));
            newTeam1.player.Add(new Player("David Alaba", "04", "DF"));
            newTeam1.player.Add(new Player("Dani Carvajal", "11", "GK"));
            newTeam1.player.Add(new Player("Antoni Rudiger", "22", "DF"));
            newTeam1.player.Add(new Player("Toni Kroos", "08", "MF"));
            newTeam1.player.Add(new Player("Marco Asensio", "11", "MF"));
            newTeam1.player.Add(new Player("Karim Benzema", "09", "FW"));
            newTeam1.player.Add(new Player("Lucas Vazquez", "17", "FW"));
            newTeam1.player.Add(new Player("Luka Modric", "10", "MF"));
            newTeam1.player.Add(new Player("Rodrygo", "21", "FW"));
            newTeam2.player.Add(new Player("David De Gea", "01", "GK"));
            newTeam2.player.Add(new Player("Dean Henderson", "26", "GK"));
            newTeam2.player.Add(new Player("Rodrygo", "21", "FW"));
            newTeam2.player.Add(new Player("Victor Lindelof", "02", "DF"));
            newTeam2.player.Add(new Player("Eric Bailly", "03", "DF"));
            newTeam2.player.Add(new Player("Raphael Varane", "19", "DF"));
            newTeam2.player.Add(new Player("Lisandro Martinez", "06", "DF"));
            newTeam2.player.Add(new Player("Bruno Fernandes", "08", "MF"));
            newTeam2.player.Add(new Player("Christian Eriksen", "14", "MF"));
            newTeam2.player.Add(new Player("Casemiro", "18", "MF"));
            newTeam2.player.Add(new Player("Marcus Rashford", "10", "FW"));
            newTeam3.player.Add(new Player("Allison", "01", "GK"));
            newTeam3.player.Add(new Player("Virgil Van Dijk", "04", "DF"));
            newTeam3.player.Add(new Player("Joel Matip", "31", "DF"));
            newTeam3.player.Add(new Player("Trent Alexander-Arnold", "66", "DF"));
            newTeam3.player.Add(new Player("Ibrahima Konate", "05", "DF"));
            newTeam3.player.Add(new Player("Thiago", "06", "MF"));
            newTeam3.player.Add(new Player("Fabinho", "03", "MF"));
            newTeam3.player.Add(new Player("James Milnder", "07", "MF"));
            newTeam3.player.Add(new Player("Jordan Henderson", "14", "MF"));
            newTeam3.player.Add(new Player("Mohammed Salah", "11", "FW"));
            newTeam3.player.Add(new Player("Darwin Nunez", "27", "FW"));

            foreach (Team team in listTeam)
            {
                if (!comboBoxCountry.Items.Contains(team.teamCountry))
                {
                    comboBoxCountry.Items.Add(team.teamCountry);
                }
            }


            //playerAdder("Thibat Courtouis", "1", "GK", 0);
            //playerAdder("Eder Militao", "3", "DF", 0);
            //playerAdder("David Alaba", "4", "DF", 0);
            //playerAdder("Antoni Rudiger", "22", "DF", 0);
            //playerAdder("Toni Kroos", "8", "MF", 0);
            //playerAdder("Marco Asensio", "11", "MF", 0);
            //playerAdder("Karim Benzema", "9", "FW", 0);
            //playerAdder("Lucas Vazquez", "17", "FW", 0);
            //playerAdder("Luka Modric", "10", "MF", 0);
            //playerAdder("Rodrygo", "21", "FW", 0);
            //playerAdder("Vinicius Junior", "20", "FW", 0);
            //playerAdder("David De Gea", "1", "GK", 1);
            //playerAdder("Dean Henderson", "26", "GK", 1);
            //playerAdder("Victor Lindelof", "2", "DF", 1);
            //playerAdder("Eric Bailly", "3", "DF", 1);
            //playerAdder("Raphael Varane", "19", "DF", 1);
            //playerAdder("Lisandro Martinez", "6", "DF", 1);
            //playerAdder("Bruno Fernandes", "8", "MF", 1);
            //playerAdder("Christian Eriksen", "14", "MF", 1);
            //playerAdder("Casemiro", "18", "MF", 1);
            //playerAdder("Marcus Rashford", "10", "FW", 1);
            //playerAdder("Alejandro Garnacho", "49", "FW", 1);
            //playerAdder("Allison", "1", "GK", 2);
            //playerAdder("Virgil Van Dijk", "4", "DF", 2);
            //playerAdder("Joel Matip", "31", "DF", 2);
            //playerAdder("Trent Alexander-Arnold", "66", "DF", 2);
            //playerAdder("Ibrahima Konate", "5", "DF", 2);
            //playerAdder("Thiago", "6", "MF", 2);
            //playerAdder("Fabinho", "3", "MF", 2);
            //playerAdder("James Milnder", "7", "MF", 2);
            //playerAdder("Jordan Henderson", "14", "MF", 2);
            //playerAdder("Mohammed Salah", "11", "FW", 2);
            //playerAdder("Darwin Nunez", "27", "FW", 2);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddTeam_Click(object sender, EventArgs e)
        {
            if (textBoxNameTeam.Text == "" || textBoxCountryTeam.Text == "" || textBoxCityTeam.Text == "")
            {
                MessageBox.Show("You must fill all the required fields", "Error Message");
            }
            else
            {
                bool teamChecker = true;
                foreach (Team team in listTeam)
                {
                    if (team.teamName == textBoxNameTeam.Text && team.teamCountry == textBoxCountryTeam.Text)
                    {
                        teamChecker = false;
                    }
                }
                if (teamChecker == true)
                {
                    Team newTeam = new Team(textBoxNameTeam.Text, textBoxCountryTeam.Text, textBoxCityTeam.Text);
                    listTeam.Add(newTeam);
                    if (!comboBoxCountry.Items.Contains(newTeam.teamCountry))
                    {
                        comboBoxCountry.Items.Add(newTeam.teamCountry);
                    }
                    comboBoxTeam.Items.Clear();
                    foreach (var x in listTeam)
                    {
                        if (x.teamCountry == comboBoxCountry.Text)
                        {
                            comboBoxTeam.Items.Add(x.teamName);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Team Already Exist", "Error Message");
                }
                textBoxNameTeam.Text = "";
                textBoxCountryTeam.Text = "";
                textBoxCityTeam.Text = "";

                

            }
            
           
           
            //for (int i = 0; i < listTeam.Count; i++)
            //{
            //    if (textBoxNameTeam.Text == listTeam[i].teamName && comboBoxTeam.Text == listTeam[i].teamName)
            //    {
            //        listTeam[i].player.Add(newPlayer);
            //    }
            //}

        }

        private void buttonAddPlayer_Click(object sender, EventArgs e)
        {
            if (textBoxPlayerName.Text == "" || textBoxPlayerNumber.Text == "" || comboBoxPlayerPosition.Text == "")
            {
                MessageBox.Show("You must fill all the required fields", "Error Message");
            }
            else
            {
                bool playerExist = true;
                foreach (Team team in listTeam)
                {
                    if (team.teamName == comboBoxTeam.Text)
                    {
                        foreach (Player _player in team.player)
                        {
                            if (_player.playerName == textBoxPlayerName.Text)
                            {
                                playerExist = false;
                            }
                        }
                    }
                }
                if (playerExist == true)
                {
                    Player newPlayer = new Player(textBoxPlayerName.Text, textBoxPlayerNumber.Text, comboBoxPlayerPosition.Text);
                    for (int i = 0; i < listTeam.Count; i++)
                    {
                        if (comboBoxCountry.Text == listTeam[i].teamCountry && comboBoxTeam.Text == listTeam[i].teamName)
                        {
                            listTeam[i].player.Add(newPlayer);
                            listBox1.Items.Clear();
                            foreach (Team team in listTeam)
                            {
                                if (team.teamName == comboBoxTeam.Text && team.teamCountry == comboBoxCountry.Text)
                                {
                                    foreach (Player _player in team.player)
                                    {
                                        listBox1.Items.Add("(" + _player.playerNum + ")" + _player.playerName + "," + _player.playerPos);
                                    }
                                    listBox1.Sorted = true;
                                }
                            }
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Player Already Exist", "Error Message");
                }
                textBoxPlayerName.Text = "";
                textBoxPlayerNumber.Text = "";
                comboBoxPlayerPosition.Text = "";
            }
  
        }

        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            comboBoxTeam.Items.Clear();
            foreach (var x in listTeam)
            {
                if (x.teamCountry == comboBoxCountry.Text)
                {
                    comboBoxTeam.Items.Add(x.teamName);
                }
            }
        }

        private void comboBoxTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Team team in listTeam)
            {
                if (team.teamName == comboBoxTeam.Text && team.teamCountry == comboBoxCountry.Text)
                {
                    foreach (Player _player in team.player)
                    {
                        listBox1.Items.Add("(" + _player.playerNum + ")" + _player.playerName + "," + _player.playerPos);
                    }
                    listBox1.Sorted = true;
                }
            }
        }

        private void comboBoxFunction(object sender, EventArgs e)
        {

        }

        private void playerAdder(string pName, string pNum, string pPos, int index)
        {
            //Player newPlayer = new Player();
            //newPlayer.playerName = pName;
            //newPlayer.playerNum = pNum;
            //newPlayer.playerPos = pPos;
            //listTeam[index].player.Add(newPlayer);
        }
        private void teamAdder(string tName, string tCountry, string tCity)
        {
            //Team newTeam = new Team();
            //newTeam.teamName = tName;
            //newTeam.teamCountry = tCountry;
            //newTeam.teamCity = tCity;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count <= 11)
            {
                MessageBox.Show("Unable to remove player because player is less then 11", "Error Message");
            }
            else
            {
                foreach (Team team in listTeam)
                {
                    if (team.teamName == comboBoxTeam.Text)
                    {
                        foreach (Player _player in team.player)
                        {
                            if (listBox1.SelectedItem.ToString().Contains("(" + _player.playerNum + ")" + _player.playerName + "," + _player.playerPos))
                            {
                                team.player.Remove(_player);
                                break;
                            }
                        }
                    }
                }
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }
    }

    public class Team
    {
        public string teamName;
        public string teamCountry;
        public string teamCity;
        public List<Player> player = new List<Player>();
        public Team(string _teamName, string _teamCountry, string _teamCity)
        {
            teamName = _teamName;
            teamCountry = _teamCountry;
            teamCity = _teamCity;
        }
    }
    public class Player
    {
        public string playerName;
        public string playerNum;
        public string playerPos;

        public Player(string _playerName, string _playerNum, string _playerPos)
        {
            playerName = _playerName;
            playerNum = _playerNum;
            playerPos = _playerPos;
        }
    }
}
