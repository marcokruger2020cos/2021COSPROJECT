﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace _2021COSPROJECT
{
    public partial class Form1 : Form
    {
        Graphics g; //declare a graphics object called g so we can draw on the Form
        Character character = new Character(); //create an instance of the Spaceship Class called spaceship
        bool turnLeft, turnRight;
        //declare a list  missiles from the Missile class
        List<Missile> missiles = new List<Missile>();
        List<Enemy> enemies = new List<Enemy>();

        public Form1()
        {
            
            
            InitializeComponent();
         //   for (int i = 0; i < 7; i++)
         //   {
         //      int displacement = 10 + (i * 70);
         //       planets.Add(new Planet(displacement));
         //   }  MATH THAT DOES NOT WORK RESULTING IN THE SPINNING OF PLANETS
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            character.moveSpaceship(e.X, e.Y);              //Moves the character with the mouse
            this.Invalidate();
        }

        private void tmrSpaceship_Tick(object sender, EventArgs e)
        {
            if (turnRight)
            {
                character.rotationAngle += 5;               //turn character right
            }
            if (turnLeft)
            {
                character.rotationAngle -= 5;               //turn character left
            }
               
            Invalidate();
        }
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();          //Close game when exit is clicked
        }

        private void Explosive1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Be carefull not to shoot the barels " );
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

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { turnLeft = true; }
            if (e.KeyData == Keys.Right) { turnRight = true; }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { turnLeft = false; }
            if (e.KeyData == Keys.Right) { turnRight = false; }

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                missiles.Add(new Missile(character.spaceRec, character.rotationAngle));
            }

        }

        private void tmrShoot_Tick(object sender, EventArgs e)
        {
            foreach (Enemy p in enemies)
            {
               // p.x = 50;
              //  foreach (Missile m in missiles)
              //  {
               //    if (p.planetRec.IntersectsWith(m.missileRec))
               //     {
                //        p.y = -20;// relocate planet to the top of the form
                //        p.x = 20;//rotation messses these things up
                 //       missiles.Remove(m);
                 //      break;
                 //   }
                 //  } I wont delete this code as it is where the shoot detection event is placed it worked for 1 plane detection but not 360 rotation

            }

            //this.Invalidate();
        }

        private void explosive1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            //get the graphics used to paint on the Form control
            g = e.Graphics;
            //Draw the spaceship
            character.drawSpaceship(g);
            foreach (Missile m in missiles)  // try ordering the commands more
            {
                m.drawMissile(g);
                m.moveMissile(g);
            }






        }
    }
}

