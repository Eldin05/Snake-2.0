namespace Snake
{
    public partial class Form1 : Form
    {

        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();
        

        int maxWidth;
        int maxHeight;

        int score;
        int highScore;

        Random rand = new Random();

        bool goLeft, goRight, goDown, goUp;


        public Form1()
        {
            InitializeComponent();

            new Settings();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left && Settings.directions != "right")
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right && Settings.directions != "left")
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Up && Settings.directions != "down")
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down && Settings.directions != "up")
            {
                goDown = true;
            }



        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }

        private void StartGame(object sender, EventArgs e)
        {
            RestartGame();
        }



        private void GameTimerEvent(object sender, EventArgs e)
        {


            if (goLeft)
            {
                Settings.directions = "left";
            }
            if (goRight)
            {
                Settings.directions = "right";
            }
            if (goDown)
            {
                Settings.directions = "down";
            }
            if (goUp)
            {
                Settings.directions = "up";
            }


            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {

                    switch (Settings.directions)
                    {
                        case "left":
                            Snake[i].X--;
                            break;
                        case "right":
                            Snake[i].X++;
                            break;
                        case "down":
                            Snake[i].Y++;
                            break;
                        case "up":
                            Snake[i].Y--;
                            break;
                    }




                    if (Snake[i].X == food.X && Snake[i].Y == food.Y)
                    {
                        EatFood();
                    }

                    for (int j = 1; j < Snake.Count; j++)
                    {

                        if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {
                            GameOver();
                        }

                    }

                    if (Snake[i].X < 0)                        // Zusammenstoßen mit den Rändern = Gameover
                    {
                        GameOver();
                    }
                    if (Snake[i].X > maxWidth)
                    {
                        GameOver();
                    }
                    if (Snake[i].Y < 0)
                    {
                        GameOver();
                    }
                    if (Snake[i].Y > maxHeight)
                    {
                        GameOver();
                    }

                }
                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
            picCanvas.Invalidate();
        }

        private void UpdatePictureBoxGraphics(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            Brush snakeColour;

            for (int i = 0; i < Snake.Count; i++)
            {
                if (i == 0)
                {
                    snakeColour = Brushes.Black;
                }


                else
                {
                    snakeColour = Brushes.DarkBlue;
                }

                canvas.FillEllipse(snakeColour, new Rectangle
                    (
                    Snake[i].X * Settings.Width,
                    Snake[i].Y * Settings.Height,
                    Settings.Width, Settings.Height
                    ));
            }

            


            canvas.FillEllipse(Brushes.Red, new Rectangle
            (
            food.X * Settings.Width,
            food.Y * Settings.Height,
            Settings.Width, Settings.Height
            ));
        }


        // Geschwindigkeiten ändern und Button Farbe

        private void slow_Click(object sender, EventArgs e)
        {
            gameTimer.Interval = 120;                                              //   Geschwindigkeit wird 120 (Langsam)
 

            slow.BackColor = Color.LightGreen;                                     //   SLOW Button wird Grün

            normal.BackColor = Color.White;                                        //   NORMAL und FAST Button wird Weiß
            fast.BackColor = Color.White;                                          //
        }

        private void normal_Click(object sender, EventArgs e)
        {
            gameTimer.Interval = 80;                                                //  Geschwindigkeit wird 80 (Mittel)


            normal.BackColor = Color.LightGreen;                                    //  Button wird Grün

            slow.BackColor = Color.White;                                           //  SLOW und FAST Button wird Weiß
            fast.BackColor= Color.White;                                            //  
        }

        private void fast_Click(object sender, EventArgs e)
        {
            gameTimer.Interval = 35;                                                //  Geschwindigkeit wird 35 (Schnell)


            fast.BackColor = Color.LightGreen;                                      //  FAST Button wird Grün

            slow.BackColor = Color.White;                                           //  SLOW und NORMAL Button wird Weiß
            normal.BackColor = Color.White;                                         //
        }

        
        // Snake in andere Farben ändern per Button
        

        private void green_Click(object sender, EventArgs e)
        {
            
                green.BackColor = Color.LightGreen;                                 // Button Farben

                red.BackColor = Color.White;                                        //
                blue.BackColor = Color.White;                                       //
            
        }

        private void red_Click(object sender, EventArgs e)
        {
           
            red.BackColor = Color.LightGreen;                                       // Button Farben

            green.BackColor = Color.White;                                          //
            blue.BackColor = Color.White;                                           //
        }

        private void blue_Click(object sender, EventArgs e)
        {
            
            blue.BackColor = Color.LightGreen;                                      // Button Farben
                
            red.BackColor = Color.White;                                            //
            green.BackColor = Color.White;                                          //

        }

        private void RestartGame()
        {
            maxWidth = picCanvas.Width / Settings.Width - 1;
            maxHeight = picCanvas.Height / Settings.Height - 1;

            Snake.Clear();

            startButton.Enabled = false;                                            // Alle Buttons während dem Game gesperrt
            fast.Enabled = false;                                                   //
            slow.Enabled = false;                                                   //
            normal.Enabled = false;                                                 //
            snakecolor.Enabled = false;
            green.Enabled = false;
            blue.Enabled = false;
            red.Enabled = false;

            score = 0;
            txtScore.Text = "Score: " + score;

            Circle head = new Circle { X = 15, Y = 17 };
            Snake.Add(head);

            for (int i = 0; i < 15; i++)
            {
                Circle body = new Circle();
                Snake.Add(body);
            }

            food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };

            gameTimer.Start();

        }

        private void EatFood()
        {
            score += 1;

            txtScore.Text = "Score: " + score;

            Circle body = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };

            Snake.Add(body);

            food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };
            
        }

        private void GameOver()
        {
            gameTimer.Stop();
            startButton.Enabled = true;                                                             //  Nach Gameover können alle Buttons angeklickt werden
            fast.Enabled = true;                                                                    //
            slow.Enabled = true;                                                                    //
            normal.Enabled = true;                                                                  //
            snakecolor.Enabled = false;
            blue.Enabled = true;
            red.Enabled = true;
            green.Enabled = true;

            if (score > highScore)
            {
                highScore = score;

                txtHighScore.Text = "High Score: " + Environment.NewLine + highScore;
                txtHighScore.ForeColor = Color.Maroon;
                txtHighScore.TextAlign = ContentAlignment.MiddleCenter;
            }
        }
    }

}