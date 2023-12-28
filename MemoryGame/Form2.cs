using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Form2 : Form
    {
        public static String easyScore;
        public Form2()
        {
            InitializeComponent();
            lbl_value.Text = Properties.Settings.Default.easyh_score;
        }
        PictureBox prev;
        byte flag = 0;
        int remain = 6;
        byte hint = 3;
        byte timeLeft = 60;
        int score = 0;

        

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        void resetImages()
        {
            foreach (Control x in this.Controls) if (x is PictureBox) (x as PictureBox).Image = Properties.Resources.box1;

            // Initialize all pictureBoxes' images to question mark (?). 
        }

        void resetTags()
        {
            foreach (Control x in this.Controls) if (x is PictureBox) (x as PictureBox).Tag = "0";

            // Initialize all pictureBoxes' tags to 0
        }

        void showImage(PictureBox box)
        {
            switch (Convert.ToInt32(box.Tag))
            {
                case 1:
                    box.Image = Properties.Resources.card_alien;
                    break;
                case 2:
                    box.Image = Properties.Resources.card_bat;
                    break;
                case 3:
                    box.Image = Properties.Resources.card_broom;
                    break;
                case 4:
                    box.Image = Properties.Resources.card_bubbles;
                    break;
                case 5:
                    box.Image = Properties.Resources.card_candle;
                    break;
                case 6:
                    box.Image = Properties.Resources.card_candy;
                    break;
                default:
                    box.Image = Properties.Resources.box1;
                    break;
            }
            // This function converts picureBox tag to image;

        }


        void setTagRandom()
        {
            int[] arr = new int[12];
            int index = 0;
            Random rand = new Random();
            int r;
            while (index < 12)
            {
                r = rand.Next(1, 13);
                if (Array.IndexOf(arr, r) == -1)
                {
                    arr[index] = r;
                    index++;
                }
            }
            for (index = 0; index < 12; index++)
            {
                if (arr[index] > 6) arr[index] -= 6;
            }
            index = 0;
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    (x as PictureBox).Tag = arr[index].ToString();
                    index++;
                }
            }


            /* This function has 3 steps.
             * 1) It creates an array and fill inside of the array with random numbers between 1 and 16.
             * 2) It does subtraction process for numbers greater than 8. (because we have 8 different images for this game.
             * 3) It sets array's numbers to pictureBoxes' tags.
             */
        }
        void compare(PictureBox previous, PictureBox current)
        {
            if (previous.Tag.ToString() == current.Tag.ToString())
            {
                Application.DoEvents();
                System.Threading.Thread.Sleep(500);
                previous.Visible = false;
                current.Visible = false;
                score += 10;
                scorelabel.Text = score.ToString();

                int a = Int32.Parse(lbl_value.Text);
                if(score > a)
                {
                    lbl_value.Text = score.ToString();
                    Properties.Settings.Default.easyh_score = lbl_value.Text;
                    Properties.Settings.Default.Save();
                }
    
                if (--remain == 0)
                {
                    timer1.Enabled = false;
                    remaining.Text = "0";
                    DialogResult message;
                    message = MessageBox.Show("You are at the Easy Level. Do you want to continue?", "Good game!", MessageBoxButtons.YesNo);
                    if (message == DialogResult.Yes)
                    {
                        easyScore = Convert.ToString(score);
                        this.Hide();
                        Form1 windowMedium = new Form1(easyScore);
                        windowMedium.Show();
                        
                    }
                    else
                    {
                        this.Close();
                    }
                    Hint.Enabled = false;
                }

                else remaining.Text = "" + remain;
            }
            else
            {
                Application.DoEvents();
                System.Threading.Thread.Sleep(500);
                previous.Image = Properties.Resources.box1;
                current.Image = Properties.Resources.box1;
            }
        }

        void allvisibleTrue()
        {
            foreach (Control x in this.Controls) if (x is PictureBox) (x as PictureBox).Visible = true;
        }
        void activeAll()
        {
            foreach (Control x in this.Controls) if (x is PictureBox) (x as PictureBox).Enabled = true;
        }
        void deActiveAll()
        {
            foreach (Control x in this.Controls) if (x is PictureBox) (x as PictureBox).Enabled = false;
        }
        void newgame()
        {
            remain = 6;
            hint = 3;
            setTagRandom();
            allvisibleTrue();
            resetImages();
            Hint.Enabled = true;
            remaining.Text = "" + remain;
            Hint.Text = "HINT (" + hint + ")";
            flag = 0;
            timeLeft = 60;
            time.Text = "" + timeLeft;
            timer1.Enabled = true;
            score = 0;
            scorelabel.Text = score.ToString();
            activeAll();

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox current = (sender as PictureBox);
            showImage((sender as PictureBox));
            if (flag == 0)
            {
                prev = current;
                flag = 1;

            }
            else if (prev != current)
            {
                compare(prev, current);
                flag = 0;
            }

        }

        private void Hint_Click(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls) if (x is PictureBox) showImage((x as PictureBox));
            Application.DoEvents();
            System.Threading.Thread.Sleep(1500);
            resetImages();
            if (--hint == 0) Hint.Enabled = false;

            Hint.Text = "HINT (" + hint + ")";
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (--timeLeft == 0)
            {
                timer1.Enabled = !timer1.Enabled;
                //time.Text = "Time's out.";
                MessageBox.Show("TIME IS OVER", "End of the game");
                deActiveAll();
                Hint.Enabled = false;

            }
            else
                time.Text = "" + timeLeft;
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            this.Close();
            StartingScreen windowMain = new StartingScreen();
            windowMain.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            newgame();
        }

        /**private void back_Click(object sender, EventArgs e)
        {
            this.Close();

            StartingScreen windowStarting = new StartingScreen();

            windowStarting.Show();
        }**/

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void scorelabel_Click(object sender, EventArgs e)
        {

        }
    }
}
