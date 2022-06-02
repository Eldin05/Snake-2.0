namespace Snake
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
            this.components = new System.ComponentModel.Container();
            this.startButton = new System.Windows.Forms.Button();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.txtHighScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.txtScore = new System.Windows.Forms.Label();
            this.slow = new System.Windows.Forms.Button();
            this.normal = new System.Windows.Forms.Button();
            this.fast = new System.Windows.Forms.Button();
            this.green = new System.Windows.Forms.Button();
            this.red = new System.Windows.Forms.Button();
            this.blue = new System.Windows.Forms.Button();
            this.snakecolor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startButton.Location = new System.Drawing.Point(617, 29);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(177, 65);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartGame);
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.picCanvas.Location = new System.Drawing.Point(21, 27);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(580, 680);
            this.picCanvas.TabIndex = 2;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdatePictureBoxGraphics);
            // 
            // txtHighScore
            // 
            this.txtHighScore.AutoSize = true;
            this.txtHighScore.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHighScore.Location = new System.Drawing.Point(731, 453);
            this.txtHighScore.Name = "txtHighScore";
            this.txtHighScore.Size = new System.Drawing.Size(236, 44);
            this.txtHighScore.TabIndex = 4;
            this.txtHighScore.Text = "High Score";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 80;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtScore.Location = new System.Drawing.Point(760, 309);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(175, 44);
            this.txtScore.TabIndex = 5;
            this.txtScore.Text = "Score: 0";
            // 
            // slow
            // 
            this.slow.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.slow.Location = new System.Drawing.Point(617, 107);
            this.slow.Name = "slow";
            this.slow.Size = new System.Drawing.Size(177, 30);
            this.slow.TabIndex = 7;
            this.slow.Text = "slow";
            this.slow.UseVisualStyleBackColor = true;
            this.slow.Click += new System.EventHandler(this.slow_Click);
            // 
            // normal
            // 
            this.normal.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.normal.Location = new System.Drawing.Point(617, 143);
            this.normal.Name = "normal";
            this.normal.Size = new System.Drawing.Size(177, 30);
            this.normal.TabIndex = 8;
            this.normal.Text = "normal";
            this.normal.UseVisualStyleBackColor = true;
            this.normal.Click += new System.EventHandler(this.normal_Click);
            // 
            // fast
            // 
            this.fast.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fast.Location = new System.Drawing.Point(617, 179);
            this.fast.Name = "fast";
            this.fast.Size = new System.Drawing.Size(177, 30);
            this.fast.TabIndex = 9;
            this.fast.Text = "Fast";
            this.fast.UseVisualStyleBackColor = true;
            this.fast.Click += new System.EventHandler(this.fast_Click);
            // 
            // green
            // 
            this.green.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.green.Location = new System.Drawing.Point(855, 107);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(177, 30);
            this.green.TabIndex = 11;
            this.green.Text = "Green";
            this.green.UseVisualStyleBackColor = true;
            this.green.Click += new System.EventHandler(this.green_Click);
            // 
            // red
            // 
            this.red.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.red.Location = new System.Drawing.Point(855, 143);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(177, 30);
            this.red.TabIndex = 12;
            this.red.Text = "Red";
            this.red.UseVisualStyleBackColor = true;
            this.red.Click += new System.EventHandler(this.red_Click);
            // 
            // blue
            // 
            this.blue.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.blue.Location = new System.Drawing.Point(855, 179);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(177, 30);
            this.blue.TabIndex = 13;
            this.blue.Text = "Blue";
            this.blue.UseVisualStyleBackColor = true;
            this.blue.Click += new System.EventHandler(this.blue_Click);
            // 
            // snakecolor
            // 
            this.snakecolor.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.snakecolor.Location = new System.Drawing.Point(855, 29);
            this.snakecolor.Name = "snakecolor";
            this.snakecolor.Size = new System.Drawing.Size(177, 65);
            this.snakecolor.TabIndex = 14;
            this.snakecolor.Text = "Snake Colour";
            this.snakecolor.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 725);
            this.Controls.Add(this.snakecolor);
            this.Controls.Add(this.blue);
            this.Controls.Add(this.red);
            this.Controls.Add(this.green);
            this.Controls.Add(this.fast);
            this.Controls.Add(this.normal);
            this.Controls.Add(this.slow);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtHighScore);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button startButton;
        private PictureBox picCanvas;
        private Label txtHighScore;
        private System.Windows.Forms.Timer gameTimer;
        private Label txtScore;
        private Button slow;
        private Button normal;
        private Button fast;
        private Button green;
        private Button red;
        private Button blue;
        private Button snakecolor;
    }
}