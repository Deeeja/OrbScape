namespace Final_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Btn_leftTurn = new System.Windows.Forms.Button();
            this.Btn_inventory = new System.Windows.Forms.Button();
            this.Btn_interact = new System.Windows.Forms.Button();
            this.Btn_rightTurn = new System.Windows.Forms.Button();
            this.Btn_move = new System.Windows.Forms.Button();
            this.Btn_map = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.Character = new System.Windows.Forms.PictureBox();
            this.Background = new System.Windows.Forms.PictureBox();
            this.backpack = new System.Windows.Forms.ListBox();
            this.bckpckImg = new System.Windows.Forms.PictureBox();
            this.nameLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Character)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bckpckImg)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_leftTurn
            // 
            this.Btn_leftTurn.Font = new System.Drawing.Font("Viner Hand ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_leftTurn.Location = new System.Drawing.Point(27, 532);
            this.Btn_leftTurn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_leftTurn.Name = "Btn_leftTurn";
            this.Btn_leftTurn.Size = new System.Drawing.Size(210, 94);
            this.Btn_leftTurn.TabIndex = 0;
            this.Btn_leftTurn.Text = "Turn Left";
            this.Btn_leftTurn.UseVisualStyleBackColor = true;
            this.Btn_leftTurn.Click += new System.EventHandler(this.Btn_leftTurn_Click);
            // 
            // Btn_inventory
            // 
            this.Btn_inventory.Font = new System.Drawing.Font("Viner Hand ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_inventory.Location = new System.Drawing.Point(536, 649);
            this.Btn_inventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_inventory.Name = "Btn_inventory";
            this.Btn_inventory.Size = new System.Drawing.Size(210, 94);
            this.Btn_inventory.TabIndex = 1;
            this.Btn_inventory.Text = "Inventory";
            this.Btn_inventory.UseVisualStyleBackColor = true;
            this.Btn_inventory.Click += new System.EventHandler(this.Btn_inventory_Click);
            // 
            // Btn_interact
            // 
            this.Btn_interact.Font = new System.Drawing.Font("Viner Hand ITC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_interact.Location = new System.Drawing.Point(272, 651);
            this.Btn_interact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_interact.Name = "Btn_interact";
            this.Btn_interact.Size = new System.Drawing.Size(229, 94);
            this.Btn_interact.TabIndex = 2;
            this.Btn_interact.Text = "Interact";
            this.Btn_interact.UseVisualStyleBackColor = true;
            this.Btn_interact.Click += new System.EventHandler(this.Btn_interact_Click);
            // 
            // Btn_rightTurn
            // 
            this.Btn_rightTurn.Font = new System.Drawing.Font("Viner Hand ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_rightTurn.Location = new System.Drawing.Point(536, 532);
            this.Btn_rightTurn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_rightTurn.Name = "Btn_rightTurn";
            this.Btn_rightTurn.Size = new System.Drawing.Size(210, 94);
            this.Btn_rightTurn.TabIndex = 3;
            this.Btn_rightTurn.Text = "Turn Right";
            this.Btn_rightTurn.UseVisualStyleBackColor = true;
            this.Btn_rightTurn.Click += new System.EventHandler(this.Btn_rightTurn_Click);
            // 
            // Btn_move
            // 
            this.Btn_move.Font = new System.Drawing.Font("Viner Hand ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_move.Location = new System.Drawing.Point(272, 532);
            this.Btn_move.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_move.Name = "Btn_move";
            this.Btn_move.Size = new System.Drawing.Size(229, 94);
            this.Btn_move.TabIndex = 4;
            this.Btn_move.Tag = "";
            this.Btn_move.Text = "Move";
            this.Btn_move.UseVisualStyleBackColor = true;
            this.Btn_move.Click += new System.EventHandler(this.Btn_move_Click);
            // 
            // Btn_map
            // 
            this.Btn_map.Font = new System.Drawing.Font("Viner Hand ITC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_map.Location = new System.Drawing.Point(26, 649);
            this.Btn_map.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_map.Name = "Btn_map";
            this.Btn_map.Size = new System.Drawing.Size(211, 94);
            this.Btn_map.TabIndex = 7;
            this.Btn_map.Text = "Map";
            this.Btn_map.UseVisualStyleBackColor = true;
            this.Btn_map.Click += new System.EventHandler(this.Btn_map_Click);
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.SystemColors.Window;
            this.textBox.Font = new System.Drawing.Font("Viner Hand ITC", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(27, 357);
            this.textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(720, 160);
            this.textBox.TabIndex = 8;
            this.textBox.Text = "Welcome to OrbScape!";
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Character
            // 
            this.Character.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.Character.Image = ((System.Drawing.Image)(resources.GetObject("Character.Image")));
            this.Character.Location = new System.Drawing.Point(347, 126);
            this.Character.Margin = new System.Windows.Forms.Padding(4);
            this.Character.Name = "Character";
            this.Character.Size = new System.Drawing.Size(92, 112);
            this.Character.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Character.TabIndex = 10;
            this.Character.TabStop = false;
            // 
            // Background
            // 
            this.Background.BackColor = System.Drawing.Color.Transparent;
            this.Background.Image = global::Final_Project.Properties.Resources.Base;
            this.Background.Location = new System.Drawing.Point(27, 25);
            this.Background.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(720, 316);
            this.Background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Background.TabIndex = 9;
            this.Background.TabStop = false;
            // 
            // backpack
            // 
            this.backpack.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backpack.FormattingEnabled = true;
            this.backpack.ItemHeight = 32;
            this.backpack.Location = new System.Drawing.Point(27, 25);
            this.backpack.Name = "backpack";
            this.backpack.Size = new System.Drawing.Size(719, 292);
            this.backpack.TabIndex = 11;
            this.backpack.Visible = false;
            this.backpack.SelectedIndexChanged += new System.EventHandler(this.backpack_SelectedIndexChanged);
            // 
            // bckpckImg
            // 
            this.bckpckImg.BackColor = System.Drawing.Color.Brown;
            this.bckpckImg.Location = new System.Drawing.Point(381, 25);
            this.bckpckImg.Name = "bckpckImg";
            this.bckpckImg.Size = new System.Drawing.Size(365, 292);
            this.bckpckImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bckpckImg.TabIndex = 12;
            this.bckpckImg.TabStop = false;
            this.bckpckImg.Visible = false;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(23, 3);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(97, 24);
            this.nameLbl.TabIndex = 13;
            this.nameLbl.Text = "Username";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(774, 765);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.bckpckImg);
            this.Controls.Add(this.backpack);
            this.Controls.Add(this.Character);
            this.Controls.Add(this.Background);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.Btn_map);
            this.Controls.Add(this.Btn_move);
            this.Controls.Add(this.Btn_rightTurn);
            this.Controls.Add(this.Btn_interact);
            this.Controls.Add(this.Btn_inventory);
            this.Controls.Add(this.Btn_leftTurn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(792, 812);
            this.MinimumSize = new System.Drawing.Size(792, 812);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrbScape";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Character)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bckpckImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_leftTurn;
        private System.Windows.Forms.Button Btn_inventory;
        private System.Windows.Forms.Button Btn_interact;
        private System.Windows.Forms.Button Btn_rightTurn;
        private System.Windows.Forms.Button Btn_move;
        private System.Windows.Forms.Button Btn_map;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.PictureBox Background;
        private System.Windows.Forms.PictureBox Character;
        private System.Windows.Forms.ListBox backpack;
        private System.Windows.Forms.PictureBox bckpckImg;
        private System.Windows.Forms.Label nameLbl;
    }
}

