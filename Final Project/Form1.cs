using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        bool north;
        bool east;
        bool south;
        bool west;
        Point xy;
        Map map;

        public Form1()
        {
            InitializeComponent();
            north = false;
            east = false;
            south = true;
            west = false;
            xy = new Point(1, 3);
            map = new Map();
        }

        private void Btn_leftTurn_Click(object sender, EventArgs e)
        {
            if (north)
            {
                north = false;
                west = true;
               
            }
            else if (west)
            {
                west = false;
                south = true;
            }
            else if(south)
            {
                south = false;
                east = true;
            }
            else
            {
                east = false;
                north = true;
            }
            this.Update_PB();
            Background.Refresh();
        }

        private void Update_PB()
        {
            Background.Image = (Image) map.map[xy.X, xy.Y];
            string dir = "";
            if(north)
            {
                Character.Image = Properties.Resources.North;
                dir = "north";
                
            }else if(west)
            {
                Character.Image = Properties.Resources.West;
                dir = "west";
            }
            else if (east)
            {
                Character.Image = Properties.Resources.East;
                dir = "east";
            }
            else if (south)
            {
                Character.Image = Properties.Resources.South;
                dir = "south";
            }
            textBox.Text = "You are facing " + dir + "." + "(" + xy.X + ", " + xy.Y + ")" ;
            Background.Refresh();
        }
        
        private void Btn_rightTurn_Click(object sender, EventArgs e)
        {
            if (north)
            {
                north = false;
                east = true;

            }
            else if (east)
            {
                east = false;
                south = true;
            }
            else if (south)
            {
                south = false;
                west = true;
            }
            else
            {
                west = false;
                north = true;
            }
            Update_PB();
        }

        private void Btn_move_Click(object sender, EventArgs e)
        {
            int dir = 1;
            if (east)
                dir = 2;
            else if (south)
                dir = 3;
            else if (west)
                dir = 4;
            xy = map.Move(xy, dir);
            Update_PB();
        }
    }
}
