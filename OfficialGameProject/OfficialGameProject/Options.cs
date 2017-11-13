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

namespace OfficialGameProject
{
    public partial class Options : Form
    {
        bool instuctionsOpened = false;
        Image music = Resources.folder;
        Image mute = Resources.delete;
        Image info = Resources.info;
        Image closeGame = Resources.no;

        public Options()
        {
            InitializeComponent();
            musicPic.Image = music;
            mutePic.Image = mute;
            infoPic.Image = info;
            stopGamePic.Image = closeGame;
        }
        

        private void musicPic_Click(object sender, EventArgs e)
        {
            Game.optionsForm.Hide();
            Game.song.controls.stop();
            mutePic.Visible = true;
        }

        private void infoPic_Click(object sender, EventArgs e)
        {
            Game.instructionsForm.StartPosition = FormStartPosition.CenterScreen;
            Game.optionsForm.Hide();
            if (instuctionsOpened)
            {
                Game.instructionsForm.Hide();
                instuctionsOpened = false;
            }
            else
            {
                Game.instructionsForm.ShowDialog();
                instuctionsOpened = true;
            }
        }

        private void mutePic_Click(object sender, EventArgs e)
        {
            Game.optionsForm.Hide();
            Game.song.controls.play();
            mutePic.Visible = false;
        }

        private void stopGamePic_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
