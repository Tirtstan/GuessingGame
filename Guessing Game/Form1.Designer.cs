namespace Guessing_Game
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
            lblYourGuess = new Label();
            lblCorrect = new Label();
            cmbTopic = new ComboBox();
            btnLoad = new Button();
            btnGuess = new Button();
            btnExit = new Button();
            lblSelectTopic = new Label();
            txtHint = new TextBox();
            txtGuess = new TextBox();
            lblHint = new Label();
            lblGuess = new Label();
            SuspendLayout();
            // 
            // lblYourGuess
            // 
            lblYourGuess.AutoSize = true;
            lblYourGuess.Location = new Point(75, 218);
            lblYourGuess.Name = "lblYourGuess";
            lblYourGuess.Size = new Size(87, 15);
            lblYourGuess.TabIndex = 0;
            lblYourGuess.Text = "Your guess was";
            // 
            // lblCorrect
            // 
            lblCorrect.AutoSize = true;
            lblCorrect.Location = new Point(75, 252);
            lblCorrect.Name = "lblCorrect";
            lblCorrect.Size = new Size(119, 15);
            lblCorrect.TabIndex = 1;
            lblCorrect.Text = "The correct word was";
            // 
            // cmbTopic
            // 
            cmbTopic.FormattingEnabled = true;
            cmbTopic.Items.AddRange(new object[] { "Car Brands", "Flowers", "Countries in Europe" });
            cmbTopic.Location = new Point(202, 29);
            cmbTopic.Margin = new Padding(3, 2, 3, 2);
            cmbTopic.Name = "cmbTopic";
            cmbTopic.Size = new Size(232, 23);
            cmbTopic.TabIndex = 2;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(502, 29);
            btnLoad.Margin = new Padding(3, 2, 3, 2);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(96, 39);
            btnLoad.TabIndex = 3;
            btnLoad.Text = "LOAD WORD";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnGuess
            // 
            btnGuess.Location = new Point(502, 126);
            btnGuess.Margin = new Padding(3, 2, 3, 2);
            btnGuess.Name = "btnGuess";
            btnGuess.Size = new Size(96, 39);
            btnGuess.TabIndex = 4;
            btnGuess.Text = "GUESS";
            btnGuess.UseVisualStyleBackColor = true;
            btnGuess.Click += btnGuess_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(502, 228);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(96, 39);
            btnExit.TabIndex = 5;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblSelectTopic
            // 
            lblSelectTopic.AutoSize = true;
            lblSelectTopic.Location = new Point(75, 35);
            lblSelectTopic.Name = "lblSelectTopic";
            lblSelectTopic.Size = new Size(72, 15);
            lblSelectTopic.TabIndex = 6;
            lblSelectTopic.Text = "Select Topic:";
            // 
            // txtHint
            // 
            txtHint.Location = new Point(75, 101);
            txtHint.Margin = new Padding(3, 2, 3, 2);
            txtHint.Name = "txtHint";
            txtHint.Size = new Size(158, 23);
            txtHint.TabIndex = 7;
            // 
            // txtGuess
            // 
            txtGuess.Location = new Point(75, 155);
            txtGuess.Margin = new Padding(3, 2, 3, 2);
            txtGuess.Name = "txtGuess";
            txtGuess.Size = new Size(158, 23);
            txtGuess.TabIndex = 8;
            // 
            // lblHint
            // 
            lblHint.AutoSize = true;
            lblHint.Location = new Point(75, 84);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(34, 15);
            lblHint.TabIndex = 9;
            lblHint.Text = "HINT";
            // 
            // lblGuess
            // 
            lblGuess.AutoSize = true;
            lblGuess.Location = new Point(75, 138);
            lblGuess.Name = "lblGuess";
            lblGuess.Size = new Size(41, 15);
            lblGuess.TabIndex = 10;
            lblGuess.Text = "GUESS";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(lblGuess);
            Controls.Add(lblHint);
            Controls.Add(txtGuess);
            Controls.Add(txtHint);
            Controls.Add(lblSelectTopic);
            Controls.Add(btnExit);
            Controls.Add(btnGuess);
            Controls.Add(btnLoad);
            Controls.Add(cmbTopic);
            Controls.Add(lblCorrect);
            Controls.Add(lblYourGuess);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblYourGuess;
        private Label lblCorrect;
        private ComboBox cmbTopic;
        private Button btnLoad;
        private Button btnGuess;
        private Button btnExit;
        private Label lblSelectTopic;
        private TextBox txtHint;
        private TextBox txtGuess;
        private Label lblHint;
        private Label lblGuess;
    }
}