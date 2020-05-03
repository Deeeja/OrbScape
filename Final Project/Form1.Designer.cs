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
            this.Btn_attack = new System.Windows.Forms.Button();
            this.Btn_rightTurn = new System.Windows.Forms.Button();
            this.Btn_move = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.Btn_map = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.Character = new System.Windows.Forms.PictureBox();
            this.Background = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Character)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_leftTurn
            // 
            this.Btn_leftTurn.Font = new System.Drawing.Font("Viner Hand ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_leftTurn.Location = new System.Drawing.Point(27, 532);
            this.Btn_leftTurn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_leftTurn.Name = "Btn_leftTurn";
            this.Btn_leftTurn.Size = new System.Drawing.Size(165, 94);
            this.Btn_leftTurn.TabIndex = 0;
            this.Btn_leftTurn.Text = "Turn Left";
            this.Btn_leftTurn.UseVisualStyleBackColor = true;
            this.Btn_leftTurn.Click += new System.EventHandler(this.Btn_leftTurn_Click);
            // 
            // Btn_inventory
            // 
            this.Btn_inventory.Font = new System.Drawing.Font("Viner Hand ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_inventory.Location = new System.Drawing.Point(27, 649);
            this.Btn_inventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_inventory.Name = "Btn_inventory";
            this.Btn_inventory.Size = new System.Drawing.Size(165, 94);
            this.Btn_inventory.TabIndex = 1;
            this.Btn_inventory.Text = "Inventory";
            this.Btn_inventory.UseVisualStyleBackColor = true;
            // 
            // Btn_attack
            // 
            this.Btn_attack.Font = new System.Drawing.Font("Viner Hand ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_attack.Location = new System.Drawing.Point(581, 532);
            this.Btn_attack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_attack.Name = "Btn_attack";
            this.Btn_attack.Size = new System.Drawing.Size(165, 94);
            this.Btn_attack.TabIndex = 2;
            this.Btn_attack.Text = "Attack";
            this.Btn_attack.UseVisualStyleBackColor = true;
            // 
            // Btn_rightTurn
            // 
            this.Btn_rightTurn.Font = new System.Drawing.Font("Viner Hand ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_rightTurn.Location = new System.Drawing.Point(396, 532);
            this.Btn_rightTurn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_rightTurn.Name = "Btn_rightTurn";
            this.Btn_rightTurn.Size = new System.Drawing.Size(165, 94);
            this.Btn_rightTurn.TabIndex = 3;
            this.Btn_rightTurn.Text = "Turn Right";
            this.Btn_rightTurn.UseVisualStyleBackColor = true;
            this.Btn_rightTurn.Click += new System.EventHandler(this.Btn_rightTurn_Click);
            // 
            // Btn_move
            // 
            this.Btn_move.Font = new System.Drawing.Font("Viner Hand ITC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_move.Location = new System.Drawing.Point(211, 532);
            this.Btn_move.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_move.Name = "Btn_move";
            this.Btn_move.Size = new System.Drawing.Size(165, 94);
            this.Btn_move.TabIndex = 4;
            this.Btn_move.Tag = "";
            this.Btn_move.Text = "Move";
            this.Btn_move.UseVisualStyleBackColor = true;
            this.Btn_move.Click += new System.EventHandler(this.Btn_move_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(581, 649);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(165, 94);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(396, 649);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(165, 94);
            this.button7.TabIndex = 6;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // Btn_map
            // 
            this.Btn_map.Font = new System.Drawing.Font("Viner Hand ITC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_map.Location = new System.Drawing.Point(211, 649);
            this.Btn_map.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_map.Name = "Btn_map";
            this.Btn_map.Size = new System.Drawing.Size(165, 94);
            this.Btn_map.TabIndex = 7;
            this.Btn_map.Text = "Map";
            this.Btn_map.UseVisualStyleBackColor = true;
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.SystemColors.Window;
            this.textBox.Font = new System.Drawing.Font("Viner Hand ITC", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(27, 357);
            this.textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(720, 160);
            this.textBox.TabIndex = 8;
            this.textBox.Text = "You are facing south.(1, 3)";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(777, 763);
            this.Controls.Add(this.Character);
            this.Controls.Add(this.Background);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.Btn_map);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.Btn_move);
            this.Controls.Add(this.Btn_rightTurn);
            this.Controls.Add(this.Btn_attack);
            this.Controls.Add(this.Btn_inventory);
            this.Controls.Add(this.Btn_leftTurn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Character)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_leftTurn;
        private System.Windows.Forms.Button Btn_inventory;
        private System.Windows.Forms.Button Btn_attack;
        private System.Windows.Forms.Button Btn_rightTurn;
        private System.Windows.Forms.Button Btn_move;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button Btn_map;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.PictureBox Background;
        private System.Windows.Forms.PictureBox Character;
    }
}

