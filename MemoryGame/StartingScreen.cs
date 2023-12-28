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
    public partial class StartingScreen : Form
    {
        public StartingScreen()
        {
            InitializeComponent();
        }

        private void easybutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            instructionWindow window_easy = new instructionWindow();
            window_easy.Show();
            
            //Form2 windowEasy = new Form2();

            //windowEasy.Show();
        }

        /**private void mediumbutton_Click(object sender, EventArgs e)
        {

            this.Hide();
            //HTPMedium window_medium = new HTPMedium();
            //window_medium.Show();

            //Form1 windowMedium = new Form1();

            //windowMedium.Show();
        }**/

        /**private void hardbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            //HTPDifficult window_difficult = new HTPDifficult();
            //window_difficult.Show();

            //Form3 windowDifficult = new Form3();

            //windowDifficult.Show();
        }**/

        private void mediumbutton_MouseHover(object sender, EventArgs e)
        {
            //mediumbutton.BackgroundImage = Properties.Resources.hover_medium;
        }

        private void easybutton_MouseHover(object sender, EventArgs e)
        {
            startbutton.BackgroundImage = Properties.Resources.start_hover;
        }

        private void hardbutton_MouseHover(object sender, EventArgs e)
        {
            //hardbutton.BackgroundImage = Properties.Resources.hover_difficult;
        }

        private void easybutton_MouseLeave(object sender, EventArgs e)
        {
            startbutton.BackgroundImage = Properties.Resources.start;
        }

        private void mediumbutton_MouseLeave(object sender, EventArgs e)
        {
            //mediumbutton.BackgroundImage = Properties.Resources.button_medium;
        }

        private void hardbutton_MouseLeave(object sender, EventArgs e)
        {
            //hardbutton.BackgroundImage = Properties.Resources.button_difficult;
        }
    }
}
