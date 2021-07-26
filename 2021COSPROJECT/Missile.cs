using System.Drawing;


namespace _2021COSPROJECT
{
    class Missile
    {
        public int x, y, width, height;

        public Image missile;//variable for the missile's image

        public Rectangle missileRec;//variable for a rectangle to place our image in

        // in the following constructor we pass in the values of charrec which
        // gives us the position of the character which we can then use to place the
        // missile where the character is located
        public Missile(Rectangle spaceRec)
        {
            x = spaceRec.X + 37; // move missile to middle of character
            y = spaceRec.Y;      // This is motion
            width = 15;
            height = 15;
            missile = Image.FromFile("pixil-frame-0 (1).png");
            missileRec = new Rectangle(x, y, width, height);
        }

        public void draw(Graphics g)
        {
            y -= 30;//speed of bullet
            missileRec = new Rectangle(x, y, width, height);
            g.DrawImage(missile, missileRec);


        }

    }
}
