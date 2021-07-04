using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace _2021COSPROJECT
{
    class Enemy
    {
        public int x, y, width, height;//variables for the rectangle
        public Image enemyImage;//variable for the planet's image
        public Rectangle enemyRec;//variable for a rectangle to place our image in
                                  //Create a constructor (initialises the values of the fields)
        public Enemy(int displacement)
        {
            x = displacement;
            y = 5;
            width = 35;
            height = 35;
            enemyImage = Properties.Resources.enemy1;
            enemyRec = new Rectangle(x, y, width, height);
        }

        // Methods for the Planet class
        public void draw(Graphics g)
        {
            enemyRec = new Rectangle(x, y, width, height);

            g.DrawImage(enemyImage, enemyRec);
        }
        public void moveenemy(Graphics g)
        {
            y += 2;
            enemyRec.Location = new Point(x, y);

        }


    }
}