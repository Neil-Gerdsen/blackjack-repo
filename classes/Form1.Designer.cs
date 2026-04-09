namespace oopTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            shuffleButton = new Button();
            giveCards = new Button();
            hitButton = new Button();
            standButton = new Button();
            pictureBoxDealer1 = new PictureBox();
            pictureBoxDealer2 = new PictureBox();
            pictureBox1Player = new PictureBox();
            pictureBox2Player = new PictureBox();
            shuffleLabel = new Label();
            pictureBox1 = new PictureBox();
            pictureBoxDealer3 = new PictureBox();
            pictureBoxDealer4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDealer1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDealer2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1Player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2Player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDealer3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDealer4).BeginInit();
            SuspendLayout();
            // 
            // shuffleButton
            // 
            shuffleButton.Location = new Point(1116, 26);
            shuffleButton.Name = "shuffleButton";
            shuffleButton.Size = new Size(94, 29);
            shuffleButton.TabIndex = 0;
            shuffleButton.Text = "shut";
            shuffleButton.UseVisualStyleBackColor = true;
            shuffleButton.Click += button1_Click;
            // 
            // giveCards
            // 
            giveCards.Location = new Point(1116, 81);
            giveCards.Name = "giveCards";
            giveCards.Size = new Size(170, 29);
            giveCards.TabIndex = 1;
            giveCards.Text = "geef kaarten";
            giveCards.UseVisualStyleBackColor = true;
            giveCards.Click += button2_Click;
            // 
            // hitButton
            // 
            hitButton.Location = new Point(1116, 141);
            hitButton.Name = "hitButton";
            hitButton.Size = new Size(94, 29);
            hitButton.TabIndex = 2;
            hitButton.Text = "hit";
            hitButton.UseVisualStyleBackColor = true;
            hitButton.Click += button3_Click;
            // 
            // standButton
            // 
            standButton.Location = new Point(1116, 189);
            standButton.Name = "standButton";
            standButton.Size = new Size(94, 40);
            standButton.TabIndex = 3;
            standButton.Text = "stand";
            standButton.UseVisualStyleBackColor = true;
            standButton.Click += standButton_Click;
            // 
            // pictureBoxDealer1
            // 
            pictureBoxDealer1.Location = new Point(53, 12);
            pictureBoxDealer1.Name = "pictureBoxDealer1";
            pictureBoxDealer1.Size = new Size(125, 179);
            pictureBoxDealer1.TabIndex = 4;
            pictureBoxDealer1.TabStop = false;
            pictureBoxDealer1.Click += pictureBoxDealer1_Click;
            // 
            // pictureBoxDealer2
            // 
            pictureBoxDealer2.Location = new Point(206, 12);
            pictureBoxDealer2.Name = "pictureBoxDealer2";
            pictureBoxDealer2.Size = new Size(125, 179);
            pictureBoxDealer2.TabIndex = 5;
            pictureBoxDealer2.TabStop = false;
            pictureBoxDealer2.Click += pictureBoxDealer2_Click;
            // 
            // pictureBox1Player
            // 
            pictureBox1Player.Location = new Point(53, 343);
            pictureBox1Player.Name = "pictureBox1Player";
            pictureBox1Player.Size = new Size(125, 179);
            pictureBox1Player.TabIndex = 6;
            pictureBox1Player.TabStop = false;
            pictureBox1Player.Click += pictureBox1Player_Click;
            // 
            // pictureBox2Player
            // 
            pictureBox2Player.Location = new Point(206, 343);
            pictureBox2Player.Name = "pictureBox2Player";
            pictureBox2Player.Size = new Size(125, 179);
            pictureBox2Player.TabIndex = 7;
            pictureBox2Player.TabStop = false;
            pictureBox2Player.Click += pictureBox2Player_Click;
            // 
            // shuffleLabel
            // 
            shuffleLabel.AutoSize = true;
            shuffleLabel.Location = new Point(1048, 35);
            shuffleLabel.Name = "shuffleLabel";
            shuffleLabel.Size = new Size(50, 20);
            shuffleLabel.TabIndex = 8;
            shuffleLabel.Text = "label1";
            shuffleLabel.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(391, 87);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(0, 0);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBoxDealer3
            // 
            pictureBoxDealer3.Location = new Point(360, 12);
            pictureBoxDealer3.Margin = new Padding(3, 4, 3, 4);
            pictureBoxDealer3.Name = "pictureBoxDealer3";
            pictureBoxDealer3.Size = new Size(125, 179);
            pictureBoxDealer3.TabIndex = 10;
            pictureBoxDealer3.TabStop = false;
            pictureBoxDealer3.Click += pictureBoxDealer3_Click;
            // 
            // pictureBoxDealer4
            // 
            pictureBoxDealer4.Location = new Point(523, 12);
            pictureBoxDealer4.Name = "pictureBoxDealer4";
            pictureBoxDealer4.Size = new Size(125, 179);
            pictureBoxDealer4.TabIndex = 11;
            pictureBoxDealer4.TabStop = false;
            pictureBoxDealer4.Click += pictureBoxDealer4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1321, 728);
            Controls.Add(pictureBoxDealer4);
            Controls.Add(pictureBoxDealer3);
            Controls.Add(pictureBox1);
            Controls.Add(shuffleLabel);
            Controls.Add(pictureBox2Player);
            Controls.Add(pictureBox1Player);
            Controls.Add(pictureBoxDealer2);
            Controls.Add(pictureBoxDealer1);
            Controls.Add(standButton);
            Controls.Add(hitButton);
            Controls.Add(giveCards);
            Controls.Add(shuffleButton);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxDealer1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDealer2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1Player).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2Player).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDealer3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDealer4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button shuffleButton;
        private Button giveCards;
        private Button hitButton;
        private Button standButton;
        private PictureBox pictureBoxDealer1;
        private PictureBox pictureBoxDealer2;
        private PictureBox pictureBox1Player;
        private PictureBox pictureBox2Player;
        private Label shuffleLabel;
        private PictureBox pictureBox1;
        private PictureBox pictureBoxDealer3;
        private PictureBox pictureBoxDealer4;
    }
}
