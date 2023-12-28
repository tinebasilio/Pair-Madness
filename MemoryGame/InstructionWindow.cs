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
    public partial class instructionWindow : Form
    {
        public instructionWindow()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 windowEasy = new Form2();
            windowEasy.Show();
        }

        /**private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            StartingScreen windowStarting = new StartingScreen();
            windowStarting.Show();
        }**/
    }
}
