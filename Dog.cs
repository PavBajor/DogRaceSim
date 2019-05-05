using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp9
{
    public class Dog
    {

        public int startingPosition;
        public int racetrackLength;
        public PictureBox mypictureBox = null;
        public int location = 0;
        public Random randomizer;

        public Dog(int start, int racetrack, int loc, PictureBox picture)
        {
            this.startingPosition = start;
            this.racetrackLength = racetrack;
            this.location = loc;
            this.mypictureBox = picture;
        }
        public bool Run()
        {
            randomizer = new Random();
            int move = randomizer.Next(1, 5);
            MoveMyPictureBox(move);

            location += move;
            
            if (location >= racetrackLength - startingPosition)
            {
                return true;
            }
            else
                return false;
        }

        public void TakeTheStartingPosition()
        {
            MoveMyPictureBox(-location);
            location = 0;
        }

        public void MoveMyPictureBox(int distance)
        {
            Point position = mypictureBox.Location;
            position.X += distance;
            mypictureBox.Location = position;

        }
    }
}
