﻿using System;
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
        Story story;
        Map map;
        private string currentText;

        public ListBox Backpack 
        { 
            get
            {
                return backpack;
            }
            set
            {
                backpack = value;
            }
        }

        public TextBox TxtBox
        {
            get
            {
                return textBox;
            }
            set
            {
                textBox = value;
            }
        }
        public Form1()
        {
            InitializeComponent();
            north = false;
            east = false;
            south = true;
            west = false;
            xy = new Point(1, 3);
            currentText = textBox.Text;
            story = new Story(this);
            map = new Map(story, this);
            story.Map = map;
        }

        private void Btn_leftTurn_Click(object sender, EventArgs e)
        {
            TxtBox.Text = "";
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
            Update_PB();
        }

        private void Update_PB()
        {
            Background.Image = map.Area[xy.X, xy.Y];
            if (north)
            {
                Character.Image = Properties.Resources.North;

            }
            else if (west)
            {
                Character.Image = Properties.Resources.West;
            }
            else if (east)
            {
                Character.Image = Properties.Resources.East;
            }
            else if (south)
            {
                Character.Image = Properties.Resources.South;
            }

        }


        private void Btn_rightTurn_Click(object sender, EventArgs e)
        {
            TxtBox.Text = "";
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
            int dir = GetDirection();
            xy = map.Move(xy, dir);
            Update_PB();
        }

        private int GetDirection()
        {
            int dir = 1;
            if (east)
                dir = 2;
            else if (south)
                dir = 3;
            else if (west)
                dir = 4;
            return dir;
        }

        private void Btn_interact_Click(object sender, EventArgs e)
        {
            int dir = GetDirection();
            story.Interact(xy, dir);
            Update_PB();
        }

        private void Btn_inventory_Click(object sender, EventArgs e)
        {
            if (!Backpack.Visible)
            {
                Backpack.Visible = true;
                bckpckImg.Visible = true;
                Background.Visible = false;
                Btn_interact.Visible = false;
                Btn_leftTurn.Visible = false;
                Btn_rightTurn.Visible = false;
                Btn_move.Visible = false;
                Btn_map.Visible = false;
                bckpckImg.BringToFront();
                currentText = TxtBox.Text;
                Btn_inventory.Text = "Exit";
                if(story.Inventory[0].ID == 999)
                {
                    TxtBox.Text = "Your inventory is empty";
                }
            }
            else
            {
                Backpack.Visible = false;
                bckpckImg.Visible = false;
                Background.Visible = true;
                Btn_interact.Visible = true;
                Btn_leftTurn.Visible = true;
                Btn_rightTurn.Visible = true;
                Btn_move.Visible = true;
                Btn_map.Visible = true;
                Btn_inventory.Text = "Inventory";
                TxtBox.Text = currentText;
            }

        }

        private void backpack_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = Backpack.SelectedIndex;
            TxtBox.Text = story.Inventory[i].Description;
            bckpckImg.Image = story.Inventory[i].img;
            bckpckImg.Refresh();
        }
    }
}
