﻿using System.Drawing.Drawing2D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;



namespace _2021COSPROJECT
{
    class Spaceship
    {
        // declare fields to use in the class
        //Just rename the classes as the example was used
        public int x, y, width, height;//variables for the rectangle
        public Image spaceship;//variable for the planet's image
        public int rotationAngle;
        public Matrix matrix;
        Point centre;
        public Rectangle spaceRec;//variable for a rectangle to place our image in
        
        
        

        //Create a constructor (initialises the values of the fields)
        public Spaceship()
        {

            x = 10;
            y = 360;
            width = 40;
            height = 40;
            rotationAngle = 0;
            spaceship = Image.FromFile("Character1.png");
            spaceRec = new Rectangle(x, y, width, height);
            
        }
        //methods
        public void drawSpaceship(Graphics g)
        {
            //find the centre point of spaceRec
            centre = new Point(spaceRec.X + width / 2, spaceRec.Y + width / 2);
            //instantiate a Matrix object called matrix
            matrix = new Matrix();
            //rotate the matrix (spaceRec) about its centre
            matrix.RotateAt(rotationAngle, centre);
            //Set the current draw location to the rotated matrix point
            g.Transform = matrix;
            //draw the spaceship
            g.DrawImage(spaceship, spaceRec);
        }
        public void moveSpaceship(int mouseX, int mouseY)
        {
            spaceRec.X = mouseX - (spaceRec.Width / 2);
            spaceRec.Y = mouseY - (spaceRec.Height / 2);
        }


    }
}
