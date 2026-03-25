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
            ((System.ComponentModel.ISupportInitialize)pictureBoxDealer1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDealer2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1Player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2Player).BeginInit();
            SuspendLayout();
            // 
            // shuffleButton
            // 
            shuffleButton.Location = new Point(669, 32);
            shuffleButton.Name = "shuffleButton";
            shuffleButton.Size = new Size(94, 29);
            shuffleButton.TabIndex = 0;
            shuffleButton.Text = "shut";
            shuffleButton.UseVisualStyleBackColor = true;
            shuffleButton.Click += button1_Click;
            // 
            // giveCards
            // 
            giveCards.Location = new Point(669, 87);
            giveCards.Name = "giveCards";
            giveCards.Size = new Size(170, 29);
            giveCards.TabIndex = 1;
            giveCards.Text = "geef kaarten";
            giveCards.UseVisualStyleBackColor = true;
            giveCards.Click += button2_Click;
            // 
            // hitButton
            // 
            hitButton.Location = new Point(669, 147);
            hitButton.Name = "hitButton";
            hitButton.Size = new Size(94, 29);
            hitButton.TabIndex = 2;
            hitButton.Text = "hit";
            hitButton.UseVisualStyleBackColor = true;
            hitButton.Click += button3_Click;
            // 
            // standButton
            // 
            standButton.Location = new Point(669, 194);
            standButton.Name = "standButton";
            standButton.Size = new Size(94, 40);
            standButton.TabIndex = 3;
            standButton.Text = "stand";
            standButton.UseVisualStyleBackColor = true;
            // 
            // pictureBoxDealer1
            // 
            pictureBoxDealer1.Location = new Point(38, 12);
            pictureBoxDealer1.Name = "pictureBoxDealer1";
            pictureBoxDealer1.Size = new Size(125, 178);
            pictureBoxDealer1.TabIndex = 4;
            pictureBoxDealer1.TabStop = false;
            pictureBoxDealer1.Click += pictureBoxDealer1_Click;
            // 
            // pictureBoxDealer2
            // 
            pictureBoxDealer2.Location = new Point(367, 12);
            pictureBoxDealer2.Name = "pictureBoxDealer2";
            pictureBoxDealer2.Size = new Size(125, 178);
            pictureBoxDealer2.TabIndex = 5;
            pictureBoxDealer2.TabStop = false;
            pictureBoxDealer2.Click += pictureBoxDealer2_Click;
            // 
            // pictureBox1Player
            // 
            pictureBox1Player.Location = new Point(52, 343);
            pictureBox1Player.Name = "pictureBox1Player";
            pictureBox1Player.Size = new Size(125, 178);
            pictureBox1Player.TabIndex = 6;
            pictureBox1Player.TabStop = false;
            pictureBox1Player.Click += pictureBox1Player_Click;
            // 
            // pictureBox2Player
            // 
            pictureBox2Player.Location = new Point(367, 343);
            pictureBox2Player.Name = "pictureBox2Player";
            pictureBox2Player.Size = new Size(125, 178);
            pictureBox2Player.TabIndex = 7;
            pictureBox2Player.TabStop = false;
            pictureBox2Player.Click += pictureBox2Player_Click;
            // 
            // shuffleLabel
            // 
            shuffleLabel.AutoSize = true;
            shuffleLabel.Location = new Point(535, 38);
            shuffleLabel.Name = "shuffleLabel";
            shuffleLabel.Size = new Size(50, 20);
            shuffleLabel.TabIndex = 8;
            shuffleLabel.Text = "label1";
            shuffleLabel.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1177, 594);
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
            ((System.ComponentModel.ISupportInitialize)pictureBoxDealer1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDealer2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1Player).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2Player).EndInit();
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
    }
}
