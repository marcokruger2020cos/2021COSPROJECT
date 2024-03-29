﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace _2021COSPROJECT
{
    public partial class Form1 : Form
    {

        Graphics g; //declare a graphics object called g so we can draw on the Form
        Character character = new Character(); //create an instance of the Character Class called spaceship
        //declare a list  missiles from the Missile class
        List<Missile> missiles = new List<Missile>();
        List<Enemy> enemies = new List<Enemy>();
        List<Character> characters = new List<Character>();

        int Score = 0;
        int Health = 10000;

        public Form1()
        {


            InitializeComponent();
            for (int i = 0; i < 7; i++)
            {
                int displacement = 9 + (i * 70);
                enemies.Add(new Enemy(displacement));
                Random yspeed = new Random();
                int rndmspeed = yspeed.Next(5, 20);
               // Enemy [i] += rndmspeed; There has to be a way to implement this!
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            character.Movecharacter(e.X);
            this.Invalidate();
        }



        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();          //Close game when exit is clicked
        }

        private void Explosive1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Be carefull not to shoot the barels ");//This warns you
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tmrCharacter.Stop();//Pause button
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tmrCharacter.Start();//Start button
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(); //Just move from main game form to Help Form
            frm.Show();
            this.Hide();
        }

     

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)//This fires the missle
            {
                missiles.Add(new Missile(character.characterrec));

            }
        }

        private void tmrShoot_Tick(object sender, EventArgs e)
        {
            foreach (Enemy p in enemies)
            {

                foreach (Missile m in missiles)
                {
                    if (p.enemyRec.IntersectsWith(m.missileRec))//Not only does this  draw the majority of stuff it also calculate the score as well as the intersect.
                    {

                        p.y = -100;// relocate planet to the top of the form
                        missiles.Remove(m);//Remove the missle
                        Score++;//Add score +1
                        lblScore.Text = "Score" + Score;
                        break;
                    }
                    if (pictureBox1.Bounds.IntersectsWith(p.enemyRec))
                    {
                        Health--;//Health minus
                        lblHealth.Text = "Health" + Health;//-Health 
                        break;
                    }



                }

            }



            this.Invalidate();
        }

        private void explosive1_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Score > 54) //At this score you win and it opens the you win form.
            {
                tmrStop.Stop();
                tmrCharacter.Stop();
                tmrShoot.Stop();
                Form4 newForm = new Form4();
                newForm.Show();


            }
        }

        private void lbHealth_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the reactor integrity");//Message
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the city reator protect it from the invaders");
        }

        private void tmrCharacter_Tick(object sender, EventArgs e)
        {
            int width = this.Width = 483; // get the width of Form.

            if (Reactor.Location.X > width - Reactor.Width) //to check condition if pic box is touch the boundroy of form width
            {
                Reactor.Location = new Point(1, Reactor.Location.Y); // pic box is set to the new point. here 1 is indicate of X coordinate.
            }
            else
            {
                Reactor.Location = new Point(Reactor.Location.X + 2, Reactor.Location.Y); // to move picture box from x coordinate by 100 Point.
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3(); //Links to the about menu and info
            frm.Show();
            this.Hide();
        }

       

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode =
            System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //get the graphics used to paint on the Form control
            g = e.Graphics;
            //Draw the spaceship
            character.drawcharacter(g);
            foreach (Missile m in missiles)
            {
                m.draw(g);
            }
           

            foreach (Enemy p in enemies)
            {
                p.Draw(g);//Draw the enemy
                p.Moveenemy(g);//move the enemy
                if (p.y >= ClientSize.Height)
                {
                    p.y = -15;//This moves the planet to the side to make it so that there is multiple planets
                }

            }


        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            Form5 FrmHighScore2 = new Form5(TXTname.Text,TXTScore.Text);
            Hide();
            FrmHighScore2.ShowDialog();



        }
    }
}

