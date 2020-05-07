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
    public partial class Riddle : Form
    {
        public int answer;
        Form1 form;
        public Riddle(Form1 form)
        {
            InitializeComponent();
            this.form = form;
            answer = 0;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            answer = (int)numericUpDown1.Value;
            this.DialogResult = DialogResult.OK;
        }
    }
}
