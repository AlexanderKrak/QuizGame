using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;


namespace QuizGame
{
    public partial class StartScreen : Form
    {
        int questionNumber = 1;
        int correctAnswer;
        int score;
        int totalQuestions = 3;

        

        private void GenerateQuestion()
        {
            switch(questionNumber) 
            {
                case 1:
                    questionLabel.Text = "Who was the first US President?";

                    answerButtonOne.Text = "George Washington";
                    answerButtonTwo.Text = "Abraham Lincoln";
                    answerButtonThree.Text = "Ulysses S. Grant";
                    answerButtonFour.Text = "Theodore Roosevelt";

                    correctAnswer = 1; 
                    break;

                case 2:
                    questionLabel.Text = "When does columbus discover america?";

                    answerButtonOne.Text = "1514";
                    answerButtonTwo.Text = "1493";
                    answerButtonThree.Text = "1492";
                    answerButtonFour.Text = "1444";

                    correctAnswer = 3;
                    break;

                case 3:
                    questionLabel.Text = "What is the capital city of Hungary?";

                    answerButtonOne.Text = "Wien";
                    answerButtonTwo.Text = "London";
                    answerButtonThree.Text = "Bukarest";
                    answerButtonFour.Text = "Budapest";

                    correctAnswer = 4;
                    break;


            }
        }

        public StartScreen()
        {
            InitializeComponent();
            GenerateQuestion();


        }

        private void checkAnswer(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int buttonTag = Convert.ToInt32(button.Tag);
            if(buttonTag == correctAnswer)
            {
                score++;
            }

            if(totalQuestions == questionNumber)
            {
                MessageBox.Show("Nice play");
            }
            else
            {
                questionNumber++;
                GenerateQuestion();
            }
        }
    }
}
