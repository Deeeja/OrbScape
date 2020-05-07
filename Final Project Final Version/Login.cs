using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Final_Project
{
    public partial class Login : Form
    {
        string charName;

        public string CharName { get { return charName; } set { charName = value; } }

        public Login()
        {
            InitializeComponent();
            this.AcceptButton = submit;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {
                var strCheck = new Regex("^[a-zA-Z0-9_ ]*$");
                if (strCheck.IsMatch(textBox1.Text))
                {
                    CharName = textBox1.Text;
                    this.Hide();
                    Form1 form = new Form1(CharName);
                    form.Show();
                }else
                {
                    label2.Visible = true;
                }
            }       
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
