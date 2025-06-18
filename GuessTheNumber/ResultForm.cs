using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheNumber
{
    public partial class ResultForm : Form
    {
        private int attempts;
        private PlayerStats stats;

        public ResultForm(int attempts, PlayerStats stats)
        {
            InitializeComponent();
            this.attempts = attempts;
            this.stats = stats;
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            label1.Text = $"Вы угадали за {attempts} попыток!";
            label2.Text = $"Всего игр: {stats.GamesPlayed}, Побед: {stats.GamesWon}, Попыток: {stats.TotalAttempts}";

            var topPlayers = PlayerStats.GetTopPlayers(5);
            topPlayersGrid.Columns.Clear();
            topPlayersGrid.Rows.Clear();
            topPlayersGrid.Columns.Add("UserName", "Игрок");
            topPlayersGrid.Columns.Add("BestScore", "Лучшая попытка");
            topPlayersGrid.Columns.Add("GamesPlayed", "Сыграно игр");

            foreach (var player in topPlayers)
            {
                topPlayersGrid.Rows.Add(player.UserName, player.BestScore, player.GamesPlayed);
            }

            var allPlayers = PlayerStats.LoadAllStats();
            allPlayersListBox.Items.Clear();

            foreach (var p in allPlayers)
            {
                string best = p.BestScore == int.MaxValue ? "-" : p.BestScore.ToString();
                allPlayersListBox.Items.Add($"{p.UserName} — игр: {p.GamesPlayed}, лучшая попытка: {best}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangeUser_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void allPlayersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

