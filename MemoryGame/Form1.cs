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
    public partial class Form1 : Form
    {
        public String easyScore;
        public int easyScore2;

        public String mediumScore;
        public int mediumScore2;
        public Form1(string geteasyscore)
        {
            easyScore = geteasyscore;
            easyScore2 = Int32.Parse(easyScore);
            InitializeComponent();
            lbl_value.Text = Properties.Settings.Default.mediumh_score;
        }

        PictureBox prev;
        byte flag = 0;
        int remain = 8;
        byte hint = 3;
        byte timeLeft = 60;
        int score = 0;

        public object ConvertToInt32 { get; private set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            newgame();

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
            switch(Convert.ToInt32(box.Tag))
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
                    box.Image = Properties.Resources.card_hat;
                    break;
                case 6:
                    box.Image = Properties.Resources.card_candy;
                    break;
                case 7:
                    box.Image = Properties.Resources.card_eye;
                    break;
                case 8:
                    box.Image = Properties.Resources.card_ghost;
                    break;
                default:
                    box.Image = Properties.Resources.box1;
                    break;
            }
            // This function converts picureBox tag to image;

        }
 

        void setTagRandom()
        {
            int[] arr = new int[16];
            int index = 0;
            Random rand = new Random();
            int r;
            while (index < 16)
            {
                r = rand.Next(1, 17);
                if(Array.IndexOf(arr,r)==-1)
                {
                    arr[index] = r;
                    index++;
                }  
            }
            for(index =0; index < 16; index++)
            {
                if (arr[index] > 8) arr[index] -= 8;
            }
            index = 0;
            foreach(Control x in this.Controls)
            {
                if(x is PictureBox)
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
            if(previous.Tag.ToString()==current.Tag.ToString())
            {
                Application.DoEvents();
                System.Threading.Thread.Sleep(500);
                previous.Visible = false;
                current.Visible = false;
                score += easyScore2;
                score += 10;
                scorelabel.Text = score.ToString();

                int a = Int32.Parse(lbl_value.Text);
                if (score > a)
                {
                    lbl_value.Text = score.ToString();
                    Properties.Settings.Default.mediumh_score = lbl_value.Text;
                    Properties.Settings.Default.Save();
                }

                if (--remain == 0)
                {
                    timer1.Enabled = false;
                    remaining.Text = "0";
                    DialogResult message;
                    message = MessageBox.Show("You are at the Medium Level. Do you want to continue?", "Good game!", MessageBoxButtons.YesNo);
                    if (message == DialogResult.Yes)
                    {
                        mediumScore = Convert.ToString(score);
                        this.Hide();
                        Form3 windowDifficult = new Form3(mediumScore);
                        windowDifficult.Show();
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
            remain = 8;
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
            scorelabel.Text = easyScore + score.ToString();
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
            else if(prev!=current)
            {
                compare(prev, current);
                flag = 0;
            }
           
        }

        private void Hint_Click(object sender, EventArgs e)
        {
            foreach(Control x in this.Controls) if(x is PictureBox) showImage((x as PictureBox));
            Application.DoEvents();
            System.Threading.Thread.Sleep(1500);
            resetImages();
            if (--hint == 0) Hint.Enabled = false;

            Hint.Text = "HINT (" + hint + ")";
        }

        private void timer1_Tick(object sender, EventArgs e)
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


        private void remaining_Click(object sender, EventArgs e)
        {

        }

        /**private void back_Click(object sender, EventArgs e)
        {
            this.Close();

            StartingScreen windowStarting = new StartingScreen();

            windowStarting.Show();
        }**/

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void scorelabel_Click(object sender, EventArgs e)
        {

        }
    }
}
