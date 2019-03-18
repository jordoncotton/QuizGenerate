using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static QuizGenerate.Form1;

namespace QuizGenerate
{
    public partial class Form1 : Form
    {
        private string result;

        public Form1()
        {
            InitializeComponent();
        }

        struct Question
        {
            public string QuestionText;

            public string[] Choices;

            public int Answer;
        }
    
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Submit(object sender, EventArgs e)
        {
            button1.BackColor = Color.Aqua;

            int result = 0;
            int a = 1; 

            DialogResult answer1 = MessageBox.Show("What year is 2002?", "Question 1", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(answer1 == DialogResult.Yes)
            {
                
            }

        }

        private static void Quiz(string[] args)
        {
            var questions = new List<Question>();

            using(var quizFileReader = new System.IO.StreamReader("questions.txt"))
            {
                string line;
                Question question;

                while ((line = quizFileReader.ReadLine()) != null)
                {
                    if (line.Length == 0)
                    {
                        continue;
                    }

                    question = new Question()
                    {
                        QuestionText = line,
                        Choices = new string[]
                        {
                            quizFileReader.ReadLine(),
                            quizFileReader.ReadLine(),
                            quizFileReader.ReadLine(),
                            quizFileReader.ReadLine()
                        }
                    };

                    question.Answer = -1;

#pragma warning disable CS0162 // Unreachable code detected
                    for (int i = 0; i < 4; i ++)
#pragma warning restore CS0162 // Unreachable code detected
                    {
                        if (question.Choices[i].StartsWith("!"))

                        question.Choices[i] = question.Choices[i].Substring(1);
                        question.Answer = 1;
                        break;
                    }
                    if(question.Answer == -1)
                    {
                        throw new InvalidOperationException("No correct answer" + question.QuestionText);
                    }
                    questions.Add(question);
                }
            } 
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }     
}
