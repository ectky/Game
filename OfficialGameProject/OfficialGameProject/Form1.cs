#define ToDel // To display x and y coordinates
using OfficialGameProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace OfficialGameProject
{
    public partial class Game : Form
    {
#if ToDel
        int _x = 0;
        int _y = 0;
#endif


        public static WindowsMediaPlayer song = new WindowsMediaPlayer();
        public static Options optionsForm = new Options();
        bool optionsShowed = false;
        public static Instructions instructionsForm = new Instructions();
        AboutTheGame abt = new AboutTheGame();
        Image options = Resources.gear;
        public static bool toClose;


        public Game()
        {
            if (toClose)
            {
                Close();
            }
            InitializeComponent();
            abt.StartPosition = FormStartPosition.Manual;
            abt.Location = new Point(424, 600);
            song.URL = "song.mp3";
            optionsPic.Image = options;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics dc = e.Graphics;

#if ToDel
            TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.EndEllipsis;
            Font _font = new System.Drawing.Font("Andalus", 12, FontStyle.Regular);
            TextRenderer.DrawText(dc, "X=" + _x.ToString() + ":Y=" + _y.ToString(), _font,
                new Rectangle(0, 0, 120, 20), SystemColors.ControlDark, flags);
#endif
            base.OnPaint(e);
        }

        private void Game_MouseMove(object sender, MouseEventArgs e)
        {
#if ToDel
            _x = e.X;
            _y = e.Y;
#endif
            this.Refresh();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // To make the form full size
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            //TopMost = true;
            // To make the form full size
            song.controls.play();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // To make the form sizable if key = esc
            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                TopMost = false;
            }
        }


        private void game1_MouseEnter(object sender, EventArgs e)
        {
            abt.Show();
            abt.abotText.Text = "Text1";
        }

        private void game1_MouseLeave(object sender, EventArgs e)
        {
            abt.Hide();
        }

        private void game2_MouseEnter(object sender, EventArgs e)
        {
            abt.Show();
            abt.abotText.Text = "Text2";
        }

        private void game2_MouseLeave(object sender, EventArgs e)
        {
            abt.Hide();
        }

        private void game3_MouseEnter(object sender, EventArgs e)
        {
            abt.Show();
            abt.abotText.Text = "Text3";
        }

        private void game3_MouseLeave(object sender, EventArgs e)
        {
            abt.Hide();
        }

        private void optionsPic_Click(object sender, EventArgs e)
        {
            optionsForm.StartPosition = FormStartPosition.Manual;
            optionsForm.Location = new Point(1288, 45);
            if (optionsShowed)
            {
                optionsShowed = false;
                optionsForm.Hide();
            }
            else
            {
                optionsShowed = true;
                optionsForm.Show();
            }

        }

        private void game2_Click(object sender, EventArgs e)
        {
            Game2Maze maze = new Game2Maze();
            maze.Show();
        }
    }
}