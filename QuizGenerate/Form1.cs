using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QuizGenerate
{
    public partial class Form1 : Form
    {
        private object answer1;
        public int QuestionCorrect { get; set; }
        public Action<EventArgs> OK { get; private set; }

        public Form1()
        {
            button1 = new Button();
            button1.Click += Submit;
            InitializeComponent();
            initializequiz();
        }

        public class Question
        {
            public string QuestionText { get; set; } 
            public string question;
            public string[] answers;
            public bool isCorrect;
            public string inputAnswer;
            private int correctIndex;
            private string questionType;
            public static string multipleChoice = "MC";
            public List<Answer> Choices;

            public Question(string q, string[] answersList, string typeOfQuestion, int correctAnswer)
            {
                question = q;
                questionType = typeOfQuestion;
                if (questionType == multipleChoice)
                {
                    answers = new string[4];
                }

                for (int i = 0; i < answersList.Length; i++)
                {
                    this.answers[i] = answersList[i];
                }

                int correctIndex = correctAnswer;

                List<Answer> answers = new List<Answer>();
            }
            public int Answer { get; set; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void Submit(object sender, EventArgs e)
        {
            button1.BackColor = Color.Aqua;

            DialogResult answer1 = MessageBox.Show("What year is 2002?", "Question 1",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (answer1 == DialogResult.OK)
            {
                
                DialogResult = Properties.Resources.correctly;
                DialogResult++;
            }

            if (answer1 == DialogResult.Cancel)
            {
                DialogResult = Properties.Resources.Error;
                DialogResult++;
            }

            
        }

        

        public class Quiz
        {
            List<Question> questions = new List<Question>();
        }

        public class Answer
        {
            public string give;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
              
        }

        private void RadioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

           
        }

        private void RadioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
           
        }

        private void RadioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            
        }

        private void RadioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            
        }
        //Create question objects that represents the strcuture of the program.
        private void QuestionText(object sender, EventArgs e)
        { 
          
        }

        private void initializequiz()
        {
            //create test
            new Question("What is 1 + 1 ?", new string[] { "1", "2", "3", "4" }, Question.multipleChoice, 1);
            new Question("What year is 2002 ?", new string[] { "0202", "2002", "2020", "2200" }, Question.multipleChoice, 1);
        }

    }
}
