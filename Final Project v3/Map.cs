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
        private int[] mazePathCor;
        private int currMaze;
        public MapForm mapForm;
        private int mazeFails;
        private int[,] mapSetting;


        public int[,] MapSetting
        {
            get
            {
                return mapSetting;
            }
            set
            {
                mapSetting = value;
            }
        }
        public int MazeFails
        {
            get
            {
                return mazeFails;
            }
            set
            {
                mazeFails = value;
            }
        }

        public Image[,] Area { get { return area; } }
        public Map(Story story, Form1 form, MapForm mapForm)
        {
            this.story = story;
            area = new Image[4,9];
            mapSetting = new int[4, 9];
            mazePathCor = new int[8] { 1, 4, 2, 3, 2, 1, 2, 4 };
            currMaze = 0;
            mazeFails = 0;
            this.mapForm = mapForm;
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
            if (!story.Maze)
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
                            if (xy.X == 1)
                            {
                                story.Maze = true;
                                xy.X++;
                            }
                            if (xy.X == 3)
                            {
                                xy.X = 1;
                                form.TxtBox.Text = "You find your way back through the maze.";
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
                        
                    }
                }
            }else
            {
               xy.X = Maze(dir);
            }
            UpdateMap(xy);
            return xy;
        }
        
        private void UpdateMap(Point xy)
        {
            if(xy.X == 0)
            {
                if(xy.Y == 0)
                {
                    MapSetting[0, 0] = 2;
                    mapForm.PB00.Image = Properties.Resources.Orb2Room;
                }else if(xy.Y == 3)
                {
                    MapSetting[0, 3] = 2;
                    mapForm.PB03.Image = Properties.Resources.BaseLeft;
                }else if(xy.Y == 6)
                {
                    MapSetting[0, 6] = 2;
                    mapForm.PB06.Image = Properties.Resources.Orb4Room;
                }
            }else if(xy.X == 1)
            {
                if (xy.Y == 0)
                {
                    if (MapSetting[0, 0] == 0)
                        MapSetting[0, 0] = 1;
                    if (MapSetting[2, 0] == 0)
                        MapSetting[2, 0] = 1;
                    MapSetting[1, 0] = 2;
                    mapForm.PB00.Visible = true;
                    mapForm.PB20.Visible = true;
                    mapForm.PB10.Image = Properties.Resources.Room10;
                }
                else if (xy.Y == 1)
                {
                    if (MapSetting[1, 0] == 0)
                        MapSetting[1, 0] = 1;
                    MapSetting[1, 1] = 2;
                    mapForm.PB10.Visible = true;
                    mapForm.PB11.Image = Properties.Resources.Room11;
                }
                else if (xy.Y == 2)
                {
                    if (MapSetting[1, 1] == 0)
                        MapSetting[1, 1] = 1;
                    MapSetting[1, 2] = 2;
                    mapForm.PB11.Visible = true;
                    mapForm.PB12.Image = Properties.Resources.Room12;
                }
                else if (xy.Y == 4)
                {
                    if (MapSetting[1, 5] == 0)
                        MapSetting[1, 5] = 1;
                    MapSetting[1, 4] = 2;
                    mapForm.PB15.Visible = true;
                    mapForm.PB14.Image = Properties.Resources.Room14;
                }
                else if (xy.Y == 5)
                {
                    if (MapSetting[1, 6] == 0)
                        MapSetting[1, 6] = 1;
                    MapSetting[1, 5] = 2;
                    mapForm.PB16.Visible = true;
                    mapForm.PB15.Image = Properties.Resources.Room15;
                }
                else if (xy.Y == 6)
                {
                    if (MapSetting[1, 7] == 0)
                        MapSetting[1, 7] = 1;
                    if (MapSetting[0, 6] == 0)
                        MapSetting[0, 6] = 1;
                    MapSetting[1, 6] = 2;
                    mapForm.PB17.Visible = true;
                    mapForm.PB06.Visible = true;
                    mapForm.PB16.Image = Properties.Resources.Room16;
                }
                else if (xy.Y == 7)
                {
                    if (MapSetting[1, 6] == 0)
                        MapSetting[1, 6] = 1;
                    MapSetting[1, 7] = 2;
                    mapForm.PB18.Visible = true;
                    mapForm.PB17.Image = Properties.Resources.Room17;
                }
                else if (xy.Y == 8)
                {
                    if (MapSetting[2, 8] == 0)
                        MapSetting[2, 8] = 1;
                    MapSetting[1, 8] = 2;
                    mapForm.PB28.Visible = true;
                    mapForm.PB18.Image = Properties.Resources.Room18;
                }
            }else if(xy.X == 2)
            {
                if(xy.Y == 0)
                {
                    if (MapSetting[3, 0] == 0)
                        MapSetting[3, 0] = 1;
                    MapSetting[2, 0] = 2;
                    mapForm.PB30.Visible = true;
                    mapForm.PB20.Image = Properties.Resources.Room20;
                }else if(xy.Y == 3)
                {
                    MapSetting[2, 3] = 2;
                    mapForm.PB23.Image = Properties.Resources.Orb1Room;
                }
                else if (xy.Y == 8)
                {
                    MapSetting[2, 8] = 2;
                    mapForm.PB28.Image = Properties.Resources.MazeMap;
                }
            }else if(xy.X == 3)
            {
                if(xy.Y == 0)
                {
                    MapSetting[3, 0] = 2;
                    mapForm.PB30.Image = Properties.Resources.BossRoom;
                }else if(xy.Y == 8)
                {
                    MapSetting[3, 8] = 2;
                    mapForm.PB38.Visible = true;
                    mapForm.PB38.Image = Properties.Resources.Orb3Room;
                }
            }
            mapForm.Refresh();
        }

        private int Maze(int dir)
        {
            if(dir == mazePathCor[currMaze])
            {
                if(currMaze == 7)
                {
                    story.Maze = false;
                    form.TxtBox.Text = "Congratulations, you solved to maze!";
                    currMaze = 0;
                    return 3;
                }
                currMaze++;
                form.TxtBox.Text = "Maze progress: " + currMaze + "/8";
                return 2;
            }
            form.TxtBox.Text = "You have chosen the incorrect path.";
            currMaze = 0;
            MazeFails++;
            story.Maze = false;
            return 1;
        }
    }
}
