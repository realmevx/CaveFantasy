using CaveFantasy;
using System;
using System.Collections.Generic;

namespace WorldGen
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomPos();    
        }

        public static void World()
        {
            Map world = new Map();
            world.minX = 1;
            world.maxX = 100;
            world.minY = 1;
            world.maxY = 100;
            world.minZ = 1;
            world.maxZ = 100;
        }

        //Slumpartar X, Y och Z position med ett värde mellan 1-100
        public static void RandomPos()
        {
            int min = 1;
            int max = 100;

            Random rand = new Random();
            int randomX = rand.Next(min, max);
            int randomY = rand.Next(min, max);
            int randomZ = rand.Next(min, max);

            Player player = new Player(randomX, randomY, randomZ);
            Console.WriteLine($"{player.PosX} {player.PosY} {player.PosZ}");
        }



    }
}

            //RandomPos();
            //int x;
            //int y;

            //int[] arrayX = new int[] { 0, 1 };
            //int[] arrayY = new int[] { 0, 3 };


            //for (int i = 0; i < arrayX.Length; i++)
            //{




            //}