using System.Drawing;


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
            width = 35;//This size may change depending on how fast the firing solution works.
            height = 35; 
            enemyImage = Properties.Resources.enemy1;
            enemyRec = new Rectangle(x, y, width, height);
        }

        // Methods for the Planet class
        public void Draw(Graphics g)
        {
            enemyRec = new Rectangle(x, y, width, height);
           

            g.DrawImage(enemyImage, enemyRec);
        }
        public void Moveenemy(Graphics g)
        {
         
            y += 2;
            enemyRec.Location = new Point(x, y);

        }


    }
}