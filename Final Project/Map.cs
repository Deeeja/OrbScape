using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    class Map
    {
        //Bitmap
        public Image[,] map;

        public Map()
        {
            map = new Image[4,9];
            FillMap();
        }

        private void FillMap()
        {
            map[0, 0] = Properties.Resources.Orb2Room;
            map[0, 3] = Properties.Resources.BaseLeft;
            map[0, 6] = Properties.Resources.Orb4Room;
            map[2, 3] = Properties.Resources.Orb1Room;
            map[1, 0] = Properties.Resources.Room10;
            map[1, 1] = Properties.Resources.Room11;
            map[1, 2] = Properties.Resources.Room12;
            map[1, 3] = Properties.Resources.Base;
            map[1, 4] = Properties.Resources.Room12;
            map[1, 5] = Properties.Resources.Room15;
            map[1, 6] = Properties.Resources.Room16;
            map[1, 7] = Properties.Resources.Room17;
            map[1, 8] = Properties.Resources.Room18;
            map[2, 0] = Properties.Resources.Room20;
            map[2, 8] = Properties.Resources.Maze;
            map[3, 0] = Properties.Resources.BossRoom;
            map[3, 8] = Properties.Resources.Orb3Room;           
        }

        /// <summary>
        /// Moves the character to the next area by returning the coordinates of the new location
        /// </summary>
        /// <param name="xy"></param>
        /// <param name="dir"></param>
        public Point Move(Point xy, int dir)
        {
            if(dir == 1)
            {
                if(xy.X == 1)
                {
                    if(xy.Y > 0)
                    {
                        xy.Y--;
                    }
                }
            }else if(dir == 3)
            {
                if(xy.X == 1)
                {
                    if(xy.Y < 8)
                    {
                        xy.Y++;
                    }
                }
            }else if(dir == 2)
            {
                if(xy.Y == 0)
                {
                    if(xy.X < 3)
                    {
                        xy.X++;
                    }
                }else if(xy.Y == 3)
                {
                    if(xy.X < 2)
                    {
                        xy.X++;
                    }
                }else if (xy.Y == 6)
                {
                    if (xy.X < 1)
                    {
                        xy.X++;
                    }
                }
                else if(xy.Y == 8)
                {
                    if(xy.X < 3)
                    {
                        xy.X++;
                    }
                }
            }
            else
            {
                if (xy.Y == 0)
                {
                    if (xy.X > 0)
                    {
                        xy.X--;
                    }
                }
                else if (xy.Y == 3)
                {
                    if (xy.X > 0)
                    {
                        xy.X--;
                    }
                }
                else if (xy.Y == 6)
                {
                    if (xy.X > 0)
                    {
                        xy.X--;
                    }
                }else if (xy.Y == 8)
                {
                    if (xy.X > 1)
                    {
                        xy.X--;
                    }
                }
            }

            return xy;
        }
    }
}
