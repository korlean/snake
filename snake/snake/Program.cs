﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            List<int> numList = new List<int>();
            numList.Add( 0 );
            numList.Add( 2 );
            numList.Add( 4 );

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            Console.WriteLine("\n" + x + " " + y + " " + z);
            
            Console.ReadLine();
        }
    } 
}
