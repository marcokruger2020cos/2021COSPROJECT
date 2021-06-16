using System;
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
        Spaceship spaceship = new Spaceship(); //create an instance of the Spaceship Class called spaceship
        bool turnLeft, turnRight;
        //declare a list  missiles from the Missile class
        List<Missile> missiles = new List<Missile>();
        List<Planet> planets = new List<Planet>();

        public Form1()
        {
            InitializeComponent();
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            spaceship.moveSpaceship(e.X, e.Y);
        }

        private void tmrSpaceship_Tick(object sender, EventArgs e)
        {
            if (turnRight)
            {
                spaceship.rotationAngle += 5;
            }
            if (turnLeft)
            {
                spaceship.rotationAngle -= 5;
            }
               
            Invalidate();
        }
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Explosive1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Be carefull not to shoot the barels " );
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
          tmrSpaceship.Stop();//Pause button
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tmrSpaceship.Start();//Start button
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            //get the graphics used to paint on the Form control
            g = e.Graphics;
            //Draw the spaceship
            spaceship.drawSpaceship(g);
            foreach (Missile m in missiles)
            {
                m.drawMissile(g);
                m.moveMissile(g);
            }
            foreach (Planet p in planets)
            {
                p.draw(g);//Draw the planet
                p.movePlanet(g);//move the planet
            }
        }

        



    }
}

