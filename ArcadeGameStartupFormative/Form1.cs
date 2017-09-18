using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

/// Created by Avery
/// Arcade Start Up Formative
/// Sept. 13 2017
namespace ArcadeGameStartupFormative
{
    public partial class ArcadeGame : Form
    {
        public ArcadeGame()
        {
            InitializeComponent();
        }

        private void playButton1_Click(object sender, EventArgs e)
        {
            // Play Sound
            SoundPlayer player = new SoundPlayer(Properties.Resources.atari);
            player.Play();

            playButton1.Visible = false;
            titleLabel.Visible = false;
            countLabel1.Visible = true;

            countLabel1.Text = "3";
            Refresh();
            Thread.Sleep(750);

            countLabel1.Text = "2";
            Refresh();
            Thread.Sleep(750);

            countLabel1.Text = "1";
            Refresh();
            Thread.Sleep(750);

            // Start Sound
            SoundPlayer player2 = new SoundPlayer(Properties.Resources.deathRay);
            player2.Play();

            countLabel1.Text = "Start!";
            ArcadeGame.ActiveForm.BackColor = Color.Lime;
            Refresh();
            Thread.Sleep(750);

            countLabel1.Visible = false;

            // Logo Graphics
            Graphics formGraphics = this.CreateGraphics();
            SolidBrush drawBrush = new SolidBrush(Color.Red);

            formGraphics.FillEllipse(drawBrush, 50, 100, 175, 125);

            Font drawFont = new Font("Copperplate Gothic Bold", 80, FontStyle.Bold);
            Font drawFont2 = new Font("Copperplate Gothic Bold", 26, FontStyle.Bold);
            Font drawFont3 = new Font("Copperplate Gothic Bold", 10, FontStyle.Bold);
            SolidBrush drawLettersBrush = new SolidBrush(Color.White);

            // Words for Logo
            formGraphics.DrawString("C", drawFont, drawLettersBrush, 60, 100);
            formGraphics.DrawString("Rams", drawFont2, drawLettersBrush, 103, 138);

            // Rotating Words
            formGraphics.TranslateTransform(250, 90);
            formGraphics.RotateTransform(90);
            formGraphics.DrawString("Central Rams Arcade", drawFont3, drawLettersBrush, new Rectangle());
            formGraphics.ResetTransform();
        }
    }
}
