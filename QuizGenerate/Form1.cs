using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QuizGenerate
{
    public partial class Form1 : Form
    {
        private object answer1;
       
        private readonly object questions;
        private readonly int i;
        public int QuestionCorrect { get; set; }
        public Action<EventArgs> OK { get; private set; }
        public string QuestionText { get; set; }
        public string[] Answers { get; set; }
        public string CorrectAnswer { get; set; }

        public Form1()
        {
            InitializeComponent();
            initializequiz();

            RadioButton RadioButton = new RadioButton();

            button1 = new Button();
            button1.Click += Submit; 
        }
        
        public class Question
        {
            public string QuestionText { get; set; }
            public string AnswerA { get; set; }
            public string AnswerB { get; set; }
            public string AnswerC { get; set; }
            public string AnswerD { get; set; }

            string[] questions = new string[]
            {
                "What is 9*10?",
                "What year is 2002?",
                "What 432 backwards?"
            };

            string[] answers = new string[]
            {
                "09, 90, 9, 0",
                "2002, 2020, 0202, 0022",
                "432, 324, 234, 423"
            };

            string[] quizAnswers = new string[]
            {
                "90, 2002, 234"
            };

            string getSelectedAnswer()
            {
                if (radioButton1.Checked)
                    return radioButton1.Text.ToString();
                if (radioButton2.Checked)
                    return radioButton2.Text.ToString();
                if (radioButton3.Checked)
                    return radioButton3.Text.ToString();
                if (radioButton4.Checked)
                    return radioButton4.Text.ToString();
                return "";
            }

            public static object Text { get; internal set; }
        }

        public class Answer
        {
            public string give;
            Answer answer = new Answer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
    
        }

        public class Quiz
        {
            List<Question> questions = new List<Question>();
        }

        private void Submit(object sender, EventArgs e)
        {
            button1.BackColor = Color.Aqua;

            if(i == 0 && radioButton1.Checked)
            {
                MessageBox.Show("Correct");
            }
            
            else
            {
                MessageBox.Show("Incorrect");
            }
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
            
        }
    }
}
