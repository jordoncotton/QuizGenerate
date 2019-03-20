using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuizGenerate
{
    public partial class Form1 : Form
    {
        private object answer1;
        private bool Value;

        public Action<EventArgs> OK { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        public class Question
        {
            public string QuestionText { get; set; } 
            public string[] Choices;
            public Question(string v)
            {
                
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
                OK = OnClick;
                Console.ReadKey();
                Console.Read();
            }

            if (answer1 == DialogResult.Cancel)
            {
                DialogResult = Properties.Resources.Error;
                DialogResult++;
            }
        }

        private static void Quiz(string[] args)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
              
        }

        private void RadioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

            if (answer1 != radioButton1)
            {
                return;
            }
        }

        private void RadioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (answer1 != radioButton2)
            {
                return;
            }
        }

        private void RadioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (answer1 == radioButton3)
            {
                return;
            }
        }

        private void RadioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            if (answer1 != radioButton4)
            {
                 return;
            }
        }
        //Create question objects that represents the strcuture of the program.
        private void QuestionText(object sender, EventArgs e)
        { 
            Console.Write(value: Value);
            int answer2 = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            String message1 = (answer2 != 4) ? "Incorrect" : "Correct";
            Console.WriteLine(message1);

            Question question = new Question("What year is 2002?");
            Console.WriteLine(question.Answer);

            Question question2 = question;
        }
    }
}
