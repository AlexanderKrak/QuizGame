namespace QuizGame
{
    public partial class LogoScreen : Form
    {
        public LogoScreen()
        {
            InitializeComponent();
        }
        private int counter;
        private void LogoScreen_Load(object sender, EventArgs e)
        {
            counter = 0;
            LogoTimer.Interval = 700;
            LogoTimer.Enabled = true;
            this.LogoTimer.Tick += new EventHandler(this.LogoTimer_Tick);
        }

        private void LogoTimer_Tick(object sender, EventArgs e)
        {
            if (counter >= 10)
            {
                // Exit loop code.  
                LogoTimer.Enabled = false;
                counter = 0;
                this.Hide();
                StartScreen sc = new StartScreen();
                sc.Show();
            }
            else
            {
                // Run your procedure here.  
                // Increment counter.  
                counter = counter + 1;
                
            }
        }
    }
}