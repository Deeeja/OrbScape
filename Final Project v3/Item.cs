using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Item
    {
        private string name;
        private string description;
        private int id;
        public Image img;

        public string Name { get { return name; } set { name = value; } }
        public string Description { get { return description; } set { description = value; } }

        public int ID { get { return id; }}

        public Image Img 
        { 
            get
            {
                return Img;
            }
        }

        public Item(string name, string description, int id, Image img)
        {
            this.name = name;
            this.description = description;
            this.id = id;
            this.img = img;
        }
    }
}
