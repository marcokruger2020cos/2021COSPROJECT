﻿using System.Drawing;



namespace _2021COSPROJECT
{
    class Character
    {
        public int x, y, width, height;//variables for the rectangle
        public Image character;//variable for the spaceship's image
        public Rectangle characterrec;//variable for a rectangle to place our image in

        //Create a constructor (initialises the values of the fields)
        public Character()
        {
            x = 200;
            y = 500;
            width = 53;
            height = 29;
            character = Image.FromFile("Character1.png");
            characterrec = new Rectangle(x, y, width, height);
        }

        public void drawcharacter(Graphics g)
        {

            g.DrawImage(character, characterrec);//This image gets drawn

        }

        public void Movecharacter(int mouseX)
        {
            characterrec.X = mouseX - (characterrec.Width / 2); //Move with the mouse
        }

    }
}
