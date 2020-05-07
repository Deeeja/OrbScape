using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Story
    {
        private Item[] inventory;
        private int[] door;
        private Map map;
        private Form1 form;
        private bool maze;
        public int dialogState;
        #region Properties
        public bool Maze 
        { 
            get
            {
                return maze;
            }
            set
            {
                maze = value;
            }
        }
        public Item[] Inventory 
        { 
            get
            {
                return inventory;
            }
            set
            {
                inventory = value;
            }
        }

        public int[] Door
        {
            get
            {
                return door;
            }
            set
            {
                door = value;
            }
        }
        public Map Map
        {
            get
            {
                return map;
            }
            set 
            {
                map = value;
            }
        }
        #endregion
        public Story(Form1 form)
        {
            this.form = form;
            inventory = new Item[10];
            door = new int[6] { 0, 0, 0, 0, 0, 0};
            dialogState = 0;
            FillWithDefault();
        }

        private void FillWithDefault()
        {
            for(int i = 0; i < 10; i++)
            {
                Item it = new Item("", "", 999, Properties.Resources.key);
                Inventory[i] = it;
            }
        }

        public void Interact(Point xy, int dir)
        {
            if(xy.X == 0)
            {
                if(xy.Y == 0)
                {
                    //OBTAINING ORB 2
                    if(dir == 4)
                    {
                        if (!Array.Exists(Inventory, element => element.ID == 2))
                        {
                            Key orb2 = new Key("Orb of the Cosmos", "One of the Four Orbs of Destiny. This orb represents the universe and all her wonders.", 2, Properties.Resources.orb_purple,this);
                            orb2.Open();
                            AddToInventory(orb2);
                            map.Area[0, 0] = Properties.Resources.Orb2Room2;
                            form.TxtBox.Text = "You've obtained an Orb of Destiny!";
                        }
                        else
                        {
                            form.TxtBox.Text = "Nothing interesting happens.";
                        }
                    }
                    else
                    {
                        form.TxtBox.Text = "Nothing interesting happens.";
                    }
                }
                else if(xy.Y == 3)
                {
                    //TALKING TO WISE OLD MAN 1
                    if(dir == 4)
                    {
                        /*if(!Array.Exists(Inventory, element => element.ID == 0))
                        {

                            Key key = new Key("Shiny Key", "This key opens the door to the Old Man's Treasure Vault.", 0, Properties.Resources.key, this);
                            key.Open();
                            AddToInventory(key);
                            form.TxtBox.Text = "You've obtained a Shiny Key!"; 
                        }*/
                        Dialog(xy);
                    }
                    else
                    {
                        form.TxtBox.Text = "Nothing interesting happens.";
                    }
                }
                else if(xy.Y == 6)
                {
                    //OBTAINING ORB 4
                    if (dir == 4)
                    {
                        if (!Array.Exists(Inventory, element => element.ID == 4))
                        {
                            Key orb4 = new Key("Orb of the Abyss", "One of the Four Orbs of Destiny. This orb represents the void and all its evils.", 4, Properties.Resources.orb_black, this);
                            orb4.Open();
                            AddToInventory(orb4);
                            map.Area[0, 6] = Properties.Resources.Orb4Room2;
                            form.TxtBox.Text = "You've obtained an Orb of Destiny!";
                        }
                        else
                        {
                            form.TxtBox.Text = "Nothing interesting happens.";
                        }
                    }
                    else
                    {
                        form.TxtBox.Text = "Nothing interesting happens.";
                    }
                }
                else
                {
                    form.TxtBox.Text = "Nothing interesting happens.";
                }
            }
            else if(xy.X == 2)
            {
                if(xy.Y == 3)
                {
                    //OBTAINING ORB 1
                    if (dir == 2)
                    {
                        if(!Array.Exists(Inventory, element => element.ID == 1))
                        {
                            Key orb1 = new Key("Orb of the Sea", "One of the Four Orbs of Destiny. This orb represents the ocean and all her mysteries.", 1, Properties.Resources.orb_blue, this);
                            orb1.Open();
                            AddToInventory(orb1);
                            map.Area[2, 3] = Properties.Resources.Orb1Room2;
                            form.TxtBox.Text = "You've obtained an Orb of Destiny!";
                        }
                        else
                        {
                            form.TxtBox.Text = "Nothing interesting happens.";
                        }
                    }
                    else
                    {
                        form.TxtBox.Text = "Nothing interesting happens.";
                    }
                }
                else
                {
                    form.TxtBox.Text = "Nothing interesting happens.";
                }
            }
            else if(xy.X == 3)
            {
                if(xy.Y == 8)
                {
                    //OBTAINING ORB 3
                    if (dir == 4)
                    {
                        if(!Array.Exists(Inventory, element => element.ID == 3))
                        {
                            Key orb3 = new Key("Orb of the Sky", "One of the Four Orbs of Destiny. This orb represents the atmosphere and all its intrigue.", 3, Properties.Resources.orb_sky, this);
                            orb3.Open();
                            AddToInventory(orb3);
                            map.Area[3, 8] = Properties.Resources.Orb3Room2;
                            form.TxtBox.Text = "You've obtained an Orb of Destiny!";
                        }
                        else
                        {
                            form.TxtBox.Text = "Nothing interesting happens.";
                        }
                    }
                    else
                    {
                        form.TxtBox.Text = "Nothing interesting happens.";
                    }
                }
                else if(xy.Y == 0)
                {
                    if(dir == 2)
                    {
                        form.TxtBox.Text = "You killed him!";
                    }
                    else
                    {
                        form.TxtBox.Text = "Nothing interesting happens.";
                    }
                }
                else
                {
                    form.TxtBox.Text = "Nothing interesting happens.";
                }
            }
            else
            {
                form.TxtBox.Text = "Nothing interesting happens.";
            }
        }

        public void AddToInventory(Item item)
        {
            int i;
            for (i = 0; Inventory[i].ID != 999; i++) ;
            Inventory[i] = item;
            form.Backpack.Items.Add(item.Name);
        }

        public bool CheckDoor(Point xy, int dir)
        {
            bool open = true;
            if(xy.X == 1)
            {
                if(xy.Y == 3)
                {
                    if(dir == 2)
                    {
                        if (Door[0] == 0)
                        {
                            open = false;
                            form.TxtBox.Text = "The door is locked. Perhaps a key will open it.";
                        }
                    }else if(dir == 1)
                    {
                        if (Door[1] == 0)
                        {
                            open = false;
                            form.TxtBox.Text = "A magical force keeps this door from opening.";
                            if(Door[0] == 1)
                            {
                                form.TxtBox.Text += " This door will open when you obtain one Orb of Destiny.";
                            }
                        }
                    }
                }else if(xy.Y == 0)
                {
                    if(dir == 4)
                    {
                        if (Door[2] == 0)
                        {
                            open = false;
                            form.TxtBox.Text = "A magical force keeps this door from opening.";
                            if (Door[0] == 1)
                            {
                                form.TxtBox.Text += " This door will open when you obtain one Orb of Destiny.";
                            }
                        }
                    }
                    else if(dir == 2)
                    {
                        if (Door[5] == 0)
                        {
                            open = false;
                            form.TxtBox.Text = "A magical force keeps this door from opening.";
                            form.TxtBox.Text += " This door will open when you obtain all four Orbs of Destiny.";
                        }
                    }
                }else if(xy.Y == 4)
                {
                    if (dir == 3)
                    {
                        if (Door[3] == 0)
                        {
                            open = false;
                            form.TxtBox.Text = "A magical force keeps this door from opening.";
                            if (Door[0] == 1)
                            {
                                form.TxtBox.Text += " This door will open when you obtain two Orbs of Destiny.";
                            }
                        }
                    }
                }else if(xy.Y == 6)
                {
                    if(dir == 4)
                    {
                        if (Door[4] == 0)
                        {
                            open = false;
                            form.TxtBox.Text = "A magical force keeps this door from opening.";
                            form.TxtBox.Text += " This door will open when you obtain three Orbs of Destiny.";
                        }
                    }              
                }
            }
            form.TxtBox.Refresh();
            return open;
        }

        public void Dialog(Point xy)
        {
            if (xy.X == 0 && xy.Y == 3)
            {
                if (!Array.Exists(Inventory, element => element.ID == 0) || dialogState >= 10)
                {
                    if (dialogState == 0)
                    {
                        form.DialogSetting(0);
                        form.TxtBox.Text = "\"Well hello young adventurer! My name is Arthur! I wish I could talk more, but I'm really quite busy!\"";
                        dialogState++;
                    }else if (dialogState == 1)
                    {
                        form.TxtBox.Text = "\"What's that? You would like to help me? I'm not sure if you are capable!\"";
                        dialogState++;
                    }else if(dialogState == 2)
                    {
                        form.TxtBox.Text = "\"On the other hand... perhaps you might just be the person for the job...\"";
                        dialogState++;
                    }else if(dialogState == 3)
                    {
                        form.TxtBox.Text = "\"You see young adventurer, the fate of the very world is at stake! The evil wizard Meelzgar is about to unleash havoc on the world!\"";
                        dialogState++;
                    }else if(dialogState == 4)
                    {
                        form.TxtBox.Text = "\"As we speak, he is channelling a spell that has enough power to possess the minds of every human on Orbscape!\"";
                        dialogState++;
                    }
                    else if (dialogState == 5)
                    {
                        form.TxtBox.Text = "\"However, a spell of this magnitude leaves Meelzgar very vulnerable! Just disrupting his concentration is enough for the spell to destroy him!\"";
                        dialogState++;
                    }else if(dialogState == 6)
                    {
                        form.TxtBox.Text = "\"To keep this from happening, Meelzgar locked himself in his chambers with a very powerful spell! A spell that can only be broken with the Orbs of Destiny!\"";
                        dialogState++;
                    }else if(dialogState == 7)
                    {
                        form.TxtBox.Text = "\"What are the Orbs of Destiny? Well, they are four objects of extreme power. Collecting all four of them might be enough to open the door to his chambers!\"";
                        dialogState++;
                    }else if(dialogState == 8)
                    {
                        form.TxtBox.Text = "\"I've managed to find one Orb, but it's up to you to find the rest! Here, take this key to my treasure vault! The first orb is in there!\"";
                        dialogState++;
                    }else if(dialogState == 9)
                    {
                        form.TxtBox.Font = new System.Drawing.Font("Viner Hand ITC", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        Key key = new Key("Shiny Key", "This key opens the door to the Old Man's Treasure Vault.", 0, Properties.Resources.key, this);
                        key.Open();
                        AddToInventory(key);
                        form.TxtBox.Text = "You've obtained a Shiny Key!";
                        dialogState++;
                    }else if(dialogState == 10)
                    {
                        form.TxtBox.Font = new System.Drawing.Font("Trebuchet MS", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        form.TxtBox.Text = "\"Good luck adventurer! The fate of the world is on your shoulders!\"";
                        dialogState++;
                    }else if(dialogState == 11)
                    {
                        form.DialogSetting(1);
                        dialogState = 0;
                    }
                }
                else
                { 
                    if(dialogState == 0)
                    {
                        form.DialogSetting(0);
                        form.TxtBox.Text = "\"Please adventurer, make haste! Meelzgar grows closer to world domination with each passing second!\"";
                        dialogState++;
                    }else if(dialogState == 1)
                    {
                        form.DialogSetting(1);
                        dialogState = 0;
                    }
                }
            }
        }
    }
}
