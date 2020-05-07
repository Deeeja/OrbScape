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
    public partial class MapForm : Form
    {
        #region PictureBox Properties
        public PictureBox PB00 
        { 
            get
            {
                return pb00;
            }
            set
            {
                pb00 = value;
            }
        }
        public PictureBox PB10
        {
            get
            {
                return pb10;
            }
            set
            {
                pb10 = value;
            }
        }
        public PictureBox PB20
        {
            get
            {
                return pb20;
            }
            set
            {
                pb20 = value;
            }
        }
        public PictureBox PB30
        {
            get
            {
                return pb30;
            }
            set
            {
                pb30 = value;
            }
        }
        public PictureBox PB11
        {
            get
            {
                return pb11;
            }
            set
            {
                pb11 = value;
            }
        }
        public PictureBox PB12
        {
            get
            {
                return pb12;
            }
            set
            {
                pb12 = value;
            }
        }
        public PictureBox PB13
        {
            get
            {
                return pb13;
            }
            set
            {
                pb13 = value;
            }
        }
        public PictureBox PB03
        {
            get
            {
                return pb03;
            }
            set
            {
                pb03 = value;
            }
        }
        public PictureBox PB23
        {
            get
            {
                return pb23;
            }
            set
            {
                pb23 = value;
            }
        }
        public PictureBox PB14
        {
            get
            {
                return pb14;
            }
            set
            {
                pb14 = value;
            }
        }
        public PictureBox PB24
        {
            get
            {
                return pb24;
            }
            set
            {
                pb24 = value;
            }
        }
        public PictureBox PB15
        {
            get
            {
                return pb15;
            }
            set
            {
                pb15 = value;
            }
        }
        public PictureBox PB16
        {
            get
            {
                return pb16;
            }
            set
            {
                pb16 = value;
            }
        }
        public PictureBox PB06
        {
            get
            {
                return pb06;
            }
            set
            {
                pb06 = value;
            }
        }
        public PictureBox PB17
        {
            get
            {
                return pb17;
            }
            set
            {
                pb17 = value;
            }
        }
        public PictureBox PB18
        {
            get
            {
                return pb18;
            }
            set
            {
                pb18 = value;
            }
        }
        public PictureBox PB28
        {
            get
            {
                return pb28;
            }
            set
            {
                pb28 = value;
            }
        }
        public PictureBox PB38
        {
            get
            {
                return pb38;
            }
            set
            {
                pb38 = value;
            }
        }
        #endregion
        public MapForm()
        {
            InitializeComponent();
        }

        private void MapForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
