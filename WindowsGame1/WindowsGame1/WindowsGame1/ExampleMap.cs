using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsGame1
{
    class ExampleMap
    {
        /// <summary>
        /// 5x5 Array
        /// </summary>
        public String[,] map;


        public ExampleMap(Random RNG)
        {
            map = new String[5,5];

            int _tmpLength;
            int _tmpRank;
            
            for (int i = 0; i < map.Rank; i++)
            {
                _tmpRank = i;
                _tmpLength = 0;
                for (int j = 0; j < map.GetLength(i); j++ )
                {
                    _tmpLength = j;
                    //map[i, j] = "Rank:"+ _tmpRank.ToString() + " LengthID:"+ _tmpLength.ToString();
                    //Console.WriteLine(map[i,j]);
                    map[i, j] = "This is the [" + _tmpRank.ToString() + "," + _tmpLength.ToString() + "]th item";
                }
            }
            /*
             * This sets things like this:
             * map[0,0] = "This is the [0,0]th Item"
             * map[0,1] = "This is the [0,1]th Item"
             * 
             * Rank and Length:
             * Rank 0, Length 3
             * Would mean:
             * Array[0,3]
             * 
             * 
             * 0 1 2 3 4 5 <<<< A 2D aray[5, 3], Rank is along the top, Lenth goes down(?)
             * 7 8 9 0 1 2 <<<< Rank 2, 3rd item is == 4
             * 2 4 1 7 4 8
             * 
             */
        }

        public Array getMap()
        {
            return map;
        }
    }
}
