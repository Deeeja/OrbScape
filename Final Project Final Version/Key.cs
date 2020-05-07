using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Final_Project
{
     class Key : Item
    {
        Story story;

        public Key(string name, string description, int id, Image img, Story story) : base(name, description, id, img)
        {
            this.story = story;
        }

        public void Open()
        {
            if(ID == 0)
            {
                story.Door[0] = 1;
            }
            else if( ID == 1 )
            {
                story.Door[1] = 1;
                story.Door[2] = 1;
                story.Door[6] = 1;
            }
            else if (ID == 2)
            {
                story.Door[3] = 1;
            }
            else if (ID == 3)
            {
                story.Door[4] = 1;
            }
            else if (ID == 4)
            {
                story.Door[5] = 1;
            }
        }


    }
}
