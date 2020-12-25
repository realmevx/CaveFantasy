using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CaveFantasy
{
    class Map : Player
    {
        public int minX;
        public int maxX;
        public int minY;
        public int maxY;
        public int minZ;
        public int maxZ;
    
        public Map()
        {

        }

        public Map(int minX, int maxX, int minY, int maxY, int minZ, int maxZ)
        {
            this.minX = minX;
            this.maxX = maxX;
            this.minY = minY;
            this.maxY = maxY;
            this.minZ = minZ;
            this.maxZ = maxZ;
        }

        public int MinX
        {
            get { return minX; }
            set { minX = value; }
        }

        public int MaxX
        {
            get { return maxX; }
            set { maxX = value; }
        }

        public int MinY
        {
            get { return minY; }
            set { minY = value; }
        }

        public int MaxY
        {
            get { return maxY; }
            set { maxY = value; }
        }

        public int MinZ
        {
            get { return minZ; }
            set { minZ = value; }
        }

        public int MaxZ
        {
            get { return maxZ; }
            set { maxZ = value; }
        }
    }

}
