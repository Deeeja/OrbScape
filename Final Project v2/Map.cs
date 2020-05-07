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
        private Image[,] area;
        private Story story;
        private Form1 form;

        public Image[,] Area { get { return area; } }
        public Map(Story story, Form1 form)
        {
            this.story = story;
            area = new Image[4,9];
            this.form = form;
            FillMap();
        }

        private void FillMap()
        {
            area[0, 0] = Properties.Resources.Orb2Room;
            area[0, 3] = Properties.Resources.BaseLeft;
            area[0, 6] = Properties.Resources.Orb4Room;
            area[2, 3] = Properties.Resources.Orb1Room;
            area[1, 0] = Properties.Resources.Room10;
            area[1, 1] = Properties.Resources.Room11;
            area[1, 2] = Properties.Resources.Room12;
            area[1, 3] = Properties.Resources.Base;
            area[1, 4] = Properties.Resources.Room14;
            area[1, 5] = Properties.Resources.Room15;
            area[1, 6] = Properties.Resources.Room16;
            area[1, 7] = Properties.Resources.Room17;
            area[1, 8] = Properties.Resources.Room18;
            area[2, 0] = Properties.Resources.Room20;
            area[2, 8] = Properties.Resources.Maze;
            area[3, 0] = Properties.Resources.BossRoom;
            area[3, 8] = Properties.Resources.Orb3Room;           
        }

        /// <summary>
        /// Moves the character to the next area by returning the coordinates of the new location
        /// </summary>
        /// <param name="xy"></param>
        /// <param name="dir"></param>
        public Point Move(Point xy, int dir)
        {
            if (story.CheckDoor(xy, dir))
            {
                form.TxtBox.Text = "";
                if (dir == 1)
                {
                    if (xy.X == 1)
                    {
                        if (xy.Y > 0)
                        {
                            xy.Y--;
                        }
                    }
                }
                else if (dir == 3)
                {
                    if (xy.X == 1)
                    {
                        if (xy.Y < 8)
                        {
                            xy.Y++;
                        }
                    }
                }
                else if (dir == 2)
                {
                    if (xy.Y == 0)
                    {
                        if (xy.X < 3)
                        {
                            xy.X++;
                        }
                    }
                    else if (xy.Y == 3)
                    {
                        if (xy.X < 2)
                        {
                            xy.X++;
                        }
                    }
                    else if (xy.Y == 6)
                    {
                        if (xy.X < 1)
                        {
                            xy.X++;
                        }
                    }
                    else if (xy.Y == 8)
                    {
                        if (xy.X < 3)
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
                    }
                    else if (xy.Y == 8)
                    {
                        if (xy.X > 1)
                        {
                            xy.X--;
                        }
                    }
                }
            }
            return xy;
        }
    }
}
