using System;
using System.Collections.Generic;
using System.Text;

namespace CaveFantasy
{
    class Player
    {
        public int posX;
        public int posY;
        public int posZ;


        public Player()
        {

        }

        public Player(int posX, int posY, int posZ)
        {
            this.posX = posX;
            this.posY = posY;
            this.posZ = posZ;
        }

        public int PosX
        {
            get { return posX; }
            set { posX = value; }
        }

        public int PosY
        {
            get { return posY; }
            set { posY = value; }
        }

        public int PosZ
        {
            get { return posZ; }
            set { posZ = value; }
        }
    }
} 
