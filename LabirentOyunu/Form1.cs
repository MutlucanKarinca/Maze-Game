using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabirentOyunu
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer startSoundPlayer=new System.Media.SoundPlayer(@"C:\Windows\Media\chord (2).wav");
        System.Media.SoundPlayer finishSoundPlayer=new System.Media.SoundPlayer(@"C:\Windows\Media\tada.wav");
        public Form1()
        {
            InitializeComponent();
            MoveToStart();
        }

        private void lblFinish_MouseEnter(object sender, EventArgs e)
        {   
            finishSoundPlayer.Play();
            MessageBox.Show("Congratulations !");
            Close();
        }

        private void MoveToStart()
        {   
            startSoundPlayer.Play();
            Point startingPoint = panel1.Location;
            startingPoint.Offset(10,10);
            Cursor.Position = PointToScreen(startingPoint);
        }

        private void wall_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }
    }
}
