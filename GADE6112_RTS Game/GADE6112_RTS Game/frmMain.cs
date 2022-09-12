using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADE6112_RTS_Game
{
    public partial class frmMain : Form, IView
    {
        private GameEngine Game;
        public frmMain()
        {
            InitializeComponent();

            Game = new GameEngine(this, 20, 43, 20, 30, 10);
            RenderMap(Game.MapCreate);
            this.Refresh();

            frmPlayerStats frmPlayerStats = new frmPlayerStats(Game.MapCreate.Hero);
            frmPlayerStats.Show();
            Application.DoEvents();
            this.Refresh();
            frmPlayerStats.Refresh();

            this.Focus();
        }

        public void Output(string text)
        {
            txtOutput.Text += text + "\r\n";
        }

        public void DeleteTile(Tile t)
        {
            this.Controls.Remove(t.Button);
        }

        private void RenderMap(Map map)
        {
            for (int i = 0; i < map.MapWidth; i++)
            {
                for (int j = 0; j < map.MapHeight; j++)
                {
                    Tile tile = map.ArrMap[i, j];

                    if (tile == null || tile.GetType() == typeof(EmptyTile)) { continue; }

                    Button button = new Button();
                    button.Tag = tile;
                    button.Click += CharacterButton_Click;
                    button.Text = tile.Symbol.ToString();
                    button.Width = 20;
                    button.Height = 20;
                    button.Location = new Point(tile.X * 20, tile.Y * 20);
                    tile.Button = button;
                    this.Controls.Add(button);
                }
            }
        }

        private void CharacterButton_Click(object sender, System.EventArgs e)
        {
            if (((Button)sender).Tag.GetType().BaseType.Name != "Enemy") { return; }

            Enemy enemy = (Enemy)((Button)sender).Tag;

            Game.Attack(enemy);

            if (enemy.Hp > 0)
            {
                Game.AttackBack(enemy);
            }

        }

        public void ShowEndGame()
        {
            MessageBox.Show("You are dead !");

            List<Control> controls = new List<Control>();
            // May not modifiy collection using foreach
            foreach (Control c in this.Controls)
            {
                if (c.Name != "txtOutput" && c.Name != "btnUp" && c.Name != "btnDown" && c.Name != "btnLeft" && c.Name != "btnRight")
                {
                    controls.Add(c);
                }
            }

            foreach (Control c in controls)
            {
                this.Controls.Remove(c);
            }

            Button newGame = new Button();
            newGame.Text = "New Game";
            newGame.Location = new Point(this.Location.X / 2, this.Location.Y / 2 - 40);
            newGame.Click += NewGame_Click;
            this.Controls.Add(newGame);
        }

        private void NewGame_Click(object sender, System.EventArgs e)
        {
            this.Controls.Remove((Control)sender);
            txtOutput.Text = String.Empty;
            Game = new GameEngine(this, 20, 43, 20, 30, 10);
            RenderMap(Game.MapCreate);
            this.Refresh();
            this.Focus();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            Game.MovePlayer(Character.Movement.Up);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            Game.MovePlayer(Character.Movement.Right);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            Game.MovePlayer(Character.Movement.Down);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            Game.MovePlayer(Character.Movement.Left);
        }
        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
