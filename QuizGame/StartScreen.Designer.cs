namespace QuizGame
{
    partial class StartScreen
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
            this.questionLabel = new System.Windows.Forms.Label();
            this.answerButtonOne = new System.Windows.Forms.Button();
            this.answerButtonTwo = new System.Windows.Forms.Button();
            this.answerButtonThree = new System.Windows.Forms.Button();
            this.answerButtonFour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.questionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.questionLabel.Location = new System.Drawing.Point(12, 167);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(497, 76);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answerButtonOne
            // 
            this.answerButtonOne.Location = new System.Drawing.Point(12, 263);
            this.answerButtonOne.Name = "answerButtonOne";
            this.answerButtonOne.Size = new System.Drawing.Size(175, 57);
            this.answerButtonOne.TabIndex = 1;
            this.answerButtonOne.Tag = "1";
            this.answerButtonOne.Text = "button1";
            this.answerButtonOne.UseVisualStyleBackColor = true;
            this.answerButtonOne.Click += new System.EventHandler(this.checkAnswer);
            // 
            // answerButtonTwo
            // 
            this.answerButtonTwo.Location = new System.Drawing.Point(334, 263);
            this.answerButtonTwo.Name = "answerButtonTwo";
            this.answerButtonTwo.Size = new System.Drawing.Size(175, 57);
            this.answerButtonTwo.TabIndex = 2;
            this.answerButtonTwo.Tag = "2";
            this.answerButtonTwo.Text = "button2";
            this.answerButtonTwo.UseVisualStyleBackColor = true;
            this.answerButtonTwo.Click += new System.EventHandler(this.checkAnswer);
            // 
            // answerButtonThree
            // 
            this.answerButtonThree.Location = new System.Drawing.Point(12, 343);
            this.answerButtonThree.Name = "answerButtonThree";
            this.answerButtonThree.Size = new System.Drawing.Size(175, 57);
            this.answerButtonThree.TabIndex = 3;
            this.answerButtonThree.Tag = "3";
            this.answerButtonThree.Text = "button3";
            this.answerButtonThree.UseVisualStyleBackColor = true;
            this.answerButtonThree.Click += new System.EventHandler(this.checkAnswer);
            // 
            // answerButtonFour
            // 
            this.answerButtonFour.Location = new System.Drawing.Point(334, 343);
            this.answerButtonFour.Name = "answerButtonFour";
            this.answerButtonFour.Size = new System.Drawing.Size(175, 57);
            this.answerButtonFour.TabIndex = 4;
            this.answerButtonFour.Tag = "4";
            this.answerButtonFour.Text = "button4";
            this.answerButtonFour.UseVisualStyleBackColor = true;
            this.answerButtonFour.Click += new System.EventHandler(this.checkAnswer);
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.answerButtonFour);
            this.Controls.Add(this.answerButtonThree);
            this.Controls.Add(this.answerButtonTwo);
            this.Controls.Add(this.answerButtonOne);
            this.Controls.Add(this.questionLabel);
            this.Name = "StartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Who wants to be a millionaire";
            this.ResumeLayout(false);

        }

        #endregion

        private Label questionLabel;
        private Button answerButtonOne;
        private Button answerButtonTwo;
        private Button answerButtonThree;
        private Button answerButtonFour;
    }
}