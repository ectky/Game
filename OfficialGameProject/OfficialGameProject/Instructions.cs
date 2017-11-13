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
    public partial class Instructions : Form
    {
        Image close = Resources.close;

        public Instructions()
        {
            InitializeComponent();
            closePic.Image = close;
        }

        private void closePic_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
