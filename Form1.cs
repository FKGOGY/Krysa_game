using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krysa_game
{
    public partial class Hra : Form
    {
        bool mRight, mLeft, jump;
        int mSpeed = 5;
        int gravity = 20;
        int force;
        

        public Hra()
        {
            InitializeComponent();
        }

        private void TimerEvent(object sender, EventArgs e)
        {
           
            if (mLeft && Krysa.Left > 0) { Krysa.Left -= mSpeed; }
            if (mRight && Krysa.Right > 0) { Krysa.Left += mSpeed; }

            if (jump == true)
            {
                Krysa.Top -= force; 
                force -= 1;
            }

            if (Krysa.Top + Krysa.Height >= gameArea.Height)
            {
                Krysa.Top = gameArea.Height - Krysa.Height;
                jump = false;
            }
            else
            {
                Krysa.Top += 5;
            }
        }

        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) { mLeft = true; }
            if (e.KeyCode == Keys.Right) { mRight = true; }

            
            if (e.KeyCode == Keys.Space && jump == false)
            {
                    jump = true;
                    force = gravity;
            }
            
        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) { mLeft = false; }
            if (e.KeyCode == Keys.Right) { mRight = false; }
            if (jump == true && force == 0) { jump = false; }


        }
    }
}
