using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Final_Project
{
    class Character
    {
        Form1 form;
        Map map;
        Story story;
        string charName;

        string[] lines;
        public Character(Form1 form, Map map, Story story)
        {
            this.form = form;
            this.map = map;
            this.story = story;
            lines = new string[26];
        }

        /// <summary>
        /// Either creates a character if the username doesnt already exist or loads the character with given username
        /// </summary>
        /// <param name="charName"> username of character </param>
        public void CreateCharacter(string charName)
        {
            this.charName = charName;
            string filePath;
            filePath = @"..\..\Characters\" + charName + ".txt";
            if (File.Exists(filePath))
            {
                lines = File.ReadAllLines(filePath);
                LoadCharacter();
            }else
            {
                lines[0] = charName;
                for (int i = 1; i < 26; i++)
                    lines[i] = "0";
            }
        }

        /// <summary>
        /// Loads the characters inventory and current position
        /// </summary>
        private void LoadCharacter()
        {

            LoadMap();
            int x = int.Parse(lines[17]);
            int y = int.Parse(lines[18]);
            form.XY = new System.Drawing.Point(x, y);
            if (int.Parse(lines[19]) == 1)
            {
                Key key = new Key("Shiny Key", "This key opens the door to the Old Man's Treasure Vault.", 0, Properties.Resources.key, story);
                key.Open();
                story.AddToInventory(key);
            }
            if (int.Parse(lines[20]) == 1)
            {
                Key orb1 = new Key("Orb of the Sea", "One of the Four Orbs of Destiny. This orb represents the ocean and all her mysteries.", 1, Properties.Resources.orb_blue, story);
                orb1.Open();
                story.AddToInventory(orb1);
            }
            if (int.Parse(lines[21]) == 1)
            {
                Key orb2 = new Key("Orb of the Cosmos", "One of the Four Orbs of Destiny. This orb represents the universe and all her wonders.", 2, Properties.Resources.orb_purple, story);
                orb2.Open();
                story.AddToInventory(orb2);
            }
            if (int.Parse(lines[22]) == 1)
            {
                Key orb3 = new Key("Orb of the Sky", "One of the Four Orbs of Destiny. This orb represents the atmosphere and all its intrigue.", 3, Properties.Resources.orb_sky, story);
                orb3.Open();
                story.AddToInventory(orb3);
            }
            if (int.Parse(lines[23]) == 1)
            {
                Key orb4 = new Key("Orb of the Abyss", "One of the Four Orbs of Destiny. This orb represents the void and all its evils.", 4, Properties.Resources.orb_black, story);
                orb4.Open();
                story.AddToInventory(orb4);
            }
            if (int.Parse(lines[25]) == 1)
            {
                Item torch = new Item("Torch", "This torch's blazing flame will melt any ice.", 5, Properties.Resources.Torch);
                story.AddToInventory(torch);
            }
            form.Update_PB();

        }

        /// <summary>
        /// Loads the map of a saved character
        /// </summary>
        private void LoadMap()
        {
            if (int.Parse(lines[1]) > 0)
            {
                map.mapForm.PB00.Visible = true;
            }
            if (int.Parse(lines[2]) > 0)
            {
                map.mapForm.PB10.Visible = true;
            }
            if (int.Parse(lines[3]) > 0)
            {
                map.mapForm.PB20.Visible = true;
            }
            if (int.Parse(lines[4]) > 0)
            {
                map.mapForm.PB30.Visible = true;
            }
            if (int.Parse(lines[5]) > 0)
            {
                map.mapForm.PB11.Visible = true;
            }
            if (int.Parse(lines[6]) > 0)
            {
                map.mapForm.PB12.Visible = true;
            }
            if (int.Parse(lines[7]) > 0)
            {
                map.mapForm.PB03.Visible = true;
            }
            if (int.Parse(lines[8]) > 0)
            {
                map.mapForm.PB23.Visible = true;
            }
            if (int.Parse(lines[9]) > 0)
            {
                map.mapForm.PB14.Visible = true;
            }
            if (int.Parse(lines[10]) > 0)
            {
                map.mapForm.PB15.Visible = true;
            }
            if (int.Parse(lines[11]) > 0)
            {
                map.mapForm.PB06.Visible = true;
            }
            if (int.Parse(lines[12]) > 0)
            {
                map.mapForm.PB16.Visible = true;
            }
            if (int.Parse(lines[13]) > 0)
            {
                map.mapForm.PB17.Visible = true;
            }
            if (int.Parse(lines[14]) > 0)
            {
                map.mapForm.PB18.Visible = true;
            }
            if (int.Parse(lines[15]) > 0)
            {
                map.mapForm.PB28.Visible = true;
            }
            if (int.Parse(lines[16]) > 0)
            {
                map.mapForm.PB38.Visible = true;
            }if(int.Parse(lines[24]) > 0 )
            {
                map.mapForm.PB24.Visible = true;
            }


            if (int.Parse(lines[1]) == 2)
            {
                map.mapForm.PB00.Image = Properties.Resources.Orb2Room;
            }
            if (int.Parse(lines[2]) == 2)
            {
                map.mapForm.PB10.Image = Properties.Resources.Room10;
            }
            if (int.Parse(lines[3]) == 2)
            {
                map.mapForm.PB20.Image = Properties.Resources.Room20;
            }
            if (int.Parse(lines[4]) == 2)
            {
                map.mapForm.PB30.Image = Properties.Resources.BossRoom;
            }
            if (int.Parse(lines[5]) == 2)
            {
                map.mapForm.PB11.Image = Properties.Resources.Room11; 
            }
            if (int.Parse(lines[6]) == 2)
            {
                map.mapForm.PB12.Image = Properties.Resources.Room12;
            }
            if (int.Parse(lines[7]) == 2)
            {
                map.mapForm.PB03.Image = Properties.Resources.BaseLeft;
            }
            if (int.Parse(lines[8]) == 2)
            {
                map.mapForm.PB23.Image = Properties.Resources.Orb1Room;
            }
            if (int.Parse(lines[9]) == 2)
            {
                map.mapForm.PB14.Image = Properties.Resources.Room14;
            }
            if (int.Parse(lines[10]) == 2)
            {
                map.mapForm.PB15.Image = Properties.Resources.Room15;
            }
            if (int.Parse(lines[11]) == 2)
            {
                map.mapForm.PB06.Image = Properties.Resources.Orb4Room;
            }
            if (int.Parse(lines[12]) == 2)
            {
                map.mapForm.PB16.Image = Properties.Resources.Room16;
            }
            if (int.Parse(lines[13]) == 2)
            {
                map.mapForm.PB17.Image = Properties.Resources.Room17;
            }
            if (int.Parse(lines[14]) == 2)
            {
                map.mapForm.PB18.Image = Properties.Resources.Room18;
            }
            if (int.Parse(lines[15]) == 2)
            {
                map.mapForm.PB28.Image = Properties.Resources.MazeMap;
            }
            if (int.Parse(lines[16]) == 2)
            {
                map.mapForm.PB38.Image = Properties.Resources.Orb3Room;
            }
            if (int.Parse(lines[24]) == 2)
            {
                map.mapForm.PB24.Image = Properties.Resources.TorchRoom;
            }

            if (int.Parse(lines[20]) == 1)
                map.Area[2, 3] = Properties.Resources.Orb1Room2;
            if (int.Parse(lines[21]) == 1)
                map.Area[0, 0] = Properties.Resources.Orb2Room2;
            if (int.Parse(lines[22]) == 1)
                map.Area[3, 8] = Properties.Resources.Orb3Room2;
            if (int.Parse(lines[23]) == 1)
                map.Area[0, 6] = Properties.Resources.Orb4Room2;
            if (int.Parse(lines[25]) == 1)
                map.Area[2, 4] = Properties.Resources.Orb1Room2; 
        }

        /// <summary>
        /// Called when the Form is closed to save character to a text file
        /// </summary>
        public void SaveCharacter()
        {
            if (int.Parse(this.lines[1]) < map.MapSetting[0, 0])
                lines[1] = map.MapSetting[0, 0].ToString();
            if (int.Parse(this.lines[2]) < map.MapSetting[1, 0])
                lines[2] = map.MapSetting[1, 0].ToString();
            if (int.Parse(this.lines[3]) < map.MapSetting[2, 0])
                lines[3] = map.MapSetting[2, 0].ToString();
            if (int.Parse(this.lines[4]) < map.MapSetting[3, 0])
                lines[4] = map.MapSetting[3, 0].ToString();
            if (int.Parse(this.lines[5]) < map.MapSetting[1, 1])
                lines[5] = map.MapSetting[1, 1].ToString();
            if (int.Parse(this.lines[6]) < map.MapSetting[1, 2])
                lines[6] = map.MapSetting[1, 2].ToString();
            if (int.Parse(this.lines[7]) < map.MapSetting[0, 3])
                lines[7] = map.MapSetting[0, 3].ToString();
            if (int.Parse(this.lines[8]) < map.MapSetting[2, 3])
                lines[8] = map.MapSetting[2, 3].ToString();
            if (int.Parse(this.lines[9]) < map.MapSetting[1, 4])
                lines[9] = map.MapSetting[1, 4].ToString();
            if (int.Parse(this.lines[10]) < map.MapSetting[1, 5])
                lines[10] = map.MapSetting[1, 5].ToString();
            if (int.Parse(this.lines[11]) < map.MapSetting[0, 6])
                lines[11] = map.MapSetting[0, 6].ToString();
            if (int.Parse(this.lines[12]) < map.MapSetting[1, 6])
                lines[12] = map.MapSetting[1, 6].ToString();
            if (int.Parse(this.lines[13]) < map.MapSetting[1, 7])
                lines[13] = map.MapSetting[1, 7].ToString();
            if (int.Parse(this.lines[14]) < map.MapSetting[1, 8])
                lines[14] = map.MapSetting[1, 8].ToString();
            if (int.Parse(this.lines[15]) < map.MapSetting[2, 8])
                lines[15] = map.MapSetting[2, 8].ToString();
            if (int.Parse(this.lines[16]) < map.MapSetting[3, 8])
                lines[16] = map.MapSetting[3, 8].ToString();
            if (int.Parse(this.lines[24]) < map.MapSetting[2, 4])
                lines[24] = map.MapSetting[2, 4].ToString();
            lines[17] = form.XY.X.ToString();
            lines[18] = form.XY.Y.ToString();
            if(form.XY.X == 2 && form.XY.Y == 8)
            {
                lines[17] = "1";
            }
            if (Array.Exists(story.Inventory, element => element.ID == 0))
                lines[19] = "1";
            if (Array.Exists(story.Inventory, element => element.ID == 1))
                lines[20] = "1";
            if (Array.Exists(story.Inventory, element => element.ID == 2))
                lines[21] = "1";
            if (Array.Exists(story.Inventory, element => element.ID == 3))
                lines[22] = "1";
            if (Array.Exists(story.Inventory, element => element.ID == 4))
                lines[23] = "1";
            if (Array.Exists(story.Inventory, element => element.ID == 5))
                lines[25] = "1";
            string filePath = @"..\..\Characters\" + charName + ".txt";
            File.WriteAllLines(filePath, lines);
        }
    }
}
