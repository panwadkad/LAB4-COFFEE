namespace LAB4_COFFEE
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
            Blackcoffee = new Button();
            Chocolate = new Button();
            Latte = new Button();
            Mocha = new Button();
            coffeeDpic = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)coffeeDpic).BeginInit();
            SuspendLayout();
            // 
            // Blackcoffee
            // 
            Blackcoffee.BackColor = SystemColors.Info;
            Blackcoffee.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Blackcoffee.ForeColor = Color.DarkGreen;
            Blackcoffee.Location = new Point(12, 12);
            Blackcoffee.Name = "Blackcoffee";
            Blackcoffee.Size = new Size(263, 109);
            Blackcoffee.TabIndex = 0;
            Blackcoffee.Text = "BLACKCOFFEE";
            Blackcoffee.UseVisualStyleBackColor = false;
            Blackcoffee.Click += Blackcoffee_Click;
            // 
            // Chocolate
            // 
            Chocolate.BackColor = SystemColors.Info;
            Chocolate.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Chocolate.ForeColor = Color.FromArgb(128, 64, 0);
            Chocolate.Location = new Point(12, 318);
            Chocolate.Name = "Chocolate";
            Chocolate.Size = new Size(263, 114);
            Chocolate.TabIndex = 1;
            Chocolate.Text = "CHOCOLATE";
            Chocolate.UseVisualStyleBackColor = false;
            Chocolate.Click += Chocolate_Click;
            // 
            // Latte
            // 
            Latte.BackColor = SystemColors.Info;
            Latte.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Latte.ForeColor = Color.DeepPink;
            Latte.Location = new Point(12, 211);
            Latte.Name = "Latte";
            Latte.Size = new Size(263, 111);
            Latte.TabIndex = 2;
            Latte.Text = "LATTE";
            Latte.UseVisualStyleBackColor = false;
            Latte.Click += Latte_Click;
            // 
            // Mocha
            // 
            Mocha.BackColor = SystemColors.Info;
            Mocha.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Mocha.ForeColor = SystemColors.MenuHighlight;
            Mocha.Location = new Point(12, 117);
            Mocha.Name = "Mocha";
            Mocha.Size = new Size(263, 98);
            Mocha.TabIndex = 3;
            Mocha.Text = "MOCHA";
            Mocha.UseVisualStyleBackColor = false;
            Mocha.Click += Mocha_Click;
            // 
            // coffeeDpic
            // 
            coffeeDpic.Image = Properties.Resources.Coffee_beans;
            coffeeDpic.Location = new Point(69, 477);
            coffeeDpic.Name = "coffeeDpic";
            coffeeDpic.Size = new Size(148, 97);
            coffeeDpic.SizeMode = PictureBoxSizeMode.StretchImage;
            coffeeDpic.TabIndex = 4;
            coffeeDpic.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2023_12_22_151127;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(684, 647);
            Controls.Add(coffeeDpic);
            Controls.Add(Mocha);
            Controls.Add(Latte);
            Controls.Add(Chocolate);
            Controls.Add(Blackcoffee);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)coffeeDpic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Blackcoffee;
        private Button Chocolate;
        private Button Latte;
        private Button Mocha;
        private PictureBox coffeeDpic;
    }
}
