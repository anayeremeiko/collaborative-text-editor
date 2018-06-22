namespace Client
{
    partial class Text_Editor
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.rightAButton = new System.Windows.Forms.Button();
            this.centerAButton = new System.Windows.Forms.Button();
            this.leftAButton = new System.Windows.Forms.Button();
            this.underlineButton = new System.Windows.Forms.Button();
            this.italicButton = new System.Windows.Forms.Button();
            this.boldButton = new System.Windows.Forms.Button();
            this.smallerButton = new System.Windows.Forms.Button();
            this.largerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 50);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 388);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox1_KeyPress);
            // 
            // rightAButton
            // 
            this.rightAButton.Image = global::ThisISAClient.Properties.Resources.RightAlign16;
            this.rightAButton.Location = new System.Drawing.Point(568, 12);
            this.rightAButton.Name = "rightAButton";
            this.rightAButton.Size = new System.Drawing.Size(32, 32);
            this.rightAButton.TabIndex = 6;
            this.rightAButton.UseVisualStyleBackColor = true;
            this.rightAButton.Click += new System.EventHandler(this.rightAButton_Click);
            // 
            // centerAButton
            // 
            this.centerAButton.Image = global::ThisISAClient.Properties.Resources.CenterAlign16;
            this.centerAButton.Location = new System.Drawing.Point(530, 12);
            this.centerAButton.Name = "centerAButton";
            this.centerAButton.Size = new System.Drawing.Size(32, 32);
            this.centerAButton.TabIndex = 5;
            this.centerAButton.UseVisualStyleBackColor = true;
            this.centerAButton.Click += new System.EventHandler(this.centerAButton_Click);
            // 
            // leftAButton
            // 
            this.leftAButton.Image = global::ThisISAClient.Properties.Resources.LeftAlign16;
            this.leftAButton.Location = new System.Drawing.Point(492, 12);
            this.leftAButton.Name = "leftAButton";
            this.leftAButton.Size = new System.Drawing.Size(32, 32);
            this.leftAButton.TabIndex = 4;
            this.leftAButton.UseVisualStyleBackColor = true;
            this.leftAButton.Click += new System.EventHandler(this.leftAButton_Click);
            // 
            // underlineButton
            // 
            this.underlineButton.Image = global::ThisISAClient.Properties.Resources.Underline16;
            this.underlineButton.Location = new System.Drawing.Point(404, 12);
            this.underlineButton.Name = "underlineButton";
            this.underlineButton.Size = new System.Drawing.Size(32, 32);
            this.underlineButton.TabIndex = 3;
            this.underlineButton.UseVisualStyleBackColor = true;
            this.underlineButton.Click += new System.EventHandler(this.underlineButton_Click);
            // 
            // italicButton
            // 
            this.italicButton.Image = global::ThisISAClient.Properties.Resources.Italic16;
            this.italicButton.Location = new System.Drawing.Point(366, 12);
            this.italicButton.Name = "italicButton";
            this.italicButton.Size = new System.Drawing.Size(32, 32);
            this.italicButton.TabIndex = 2;
            this.italicButton.UseVisualStyleBackColor = true;
            this.italicButton.Click += new System.EventHandler(this.italicButton_Click);
            // 
            // boldButton
            // 
            this.boldButton.Image = global::ThisISAClient.Properties.Resources.Bold16;
            this.boldButton.Location = new System.Drawing.Point(328, 12);
            this.boldButton.Name = "boldButton";
            this.boldButton.Size = new System.Drawing.Size(32, 32);
            this.boldButton.TabIndex = 1;
            this.boldButton.UseVisualStyleBackColor = true;
            this.boldButton.Click += new System.EventHandler(this.boldButton_Click);
            // 
            // smallerButton
            // 
            this.smallerButton.Image = global::ThisISAClient.Properties.Resources.font_size_smaller_resize_resize_resize;
            this.smallerButton.Location = new System.Drawing.Point(184, 12);
            this.smallerButton.Name = "smallerButton";
            this.smallerButton.Size = new System.Drawing.Size(32, 32);
            this.smallerButton.TabIndex = 10;
            this.smallerButton.UseVisualStyleBackColor = true;
            this.smallerButton.Click += new System.EventHandler(this.smallerButton_Click);
            // 
            // largerButton
            // 
            this.largerButton.Image = global::ThisISAClient.Properties.Resources.font_size_larger_resize;
            this.largerButton.Location = new System.Drawing.Point(222, 12);
            this.largerButton.Name = "largerButton";
            this.largerButton.Size = new System.Drawing.Size(32, 32);
            this.largerButton.TabIndex = 11;
            this.largerButton.UseVisualStyleBackColor = true;
            this.largerButton.Click += new System.EventHandler(this.largerButton_Click);
            // 
            // Text_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ThisISAClient.Properties.Resources.grey_wash_wall;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.largerButton);
            this.Controls.Add(this.smallerButton);
            this.Controls.Add(this.rightAButton);
            this.Controls.Add(this.centerAButton);
            this.Controls.Add(this.leftAButton);
            this.Controls.Add(this.underlineButton);
            this.Controls.Add(this.italicButton);
            this.Controls.Add(this.boldButton);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Text_Editor";
            this.Text = "Text_Editor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button boldButton;
        private System.Windows.Forms.Button italicButton;
        private System.Windows.Forms.Button underlineButton;
        private System.Windows.Forms.Button leftAButton;
        private System.Windows.Forms.Button centerAButton;
        private System.Windows.Forms.Button rightAButton;
        private System.Windows.Forms.Button smallerButton;
        private System.Windows.Forms.Button largerButton;
    }
}