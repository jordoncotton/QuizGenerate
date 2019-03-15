using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static QuizGenerate.Form1;

namespace QuizGenerate
{
    public partial class Form1 : Form
    {
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

        struct Answer
        {
            //public string AnswerBox;

            //public string[] question;

            //public int quiz;
        }
    
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Generate(object sender, EventArgs e)
        {
            button1.BackColor = Color.Aqua;
        }

        private void CheckedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        { 

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
    }     
}
