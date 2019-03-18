using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuizGenerate
{
    public partial class Form1 : Form
    {
        private object answer1;
        private object YesNo;
        private DialogResult Yes;
        private DialogResult No;

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

            DialogResult answer1 = MessageBox.Show("What year is 2002?", "Question 1",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer1 == DialogResult.Yes)
            {
                DialogResult = Properties.Resources.correctly;
                DialogResult++;
            }

            if (answer1 == DialogResult.No)
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

            if (answer1 == radioButton1)
            {
                return;
            }

            if (false)
            {
              
            }
        }

        private void RadioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (answer1 == radioButton2)
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
            if (answer1 == radioButton4)
            {
                return;
            }
        }
    }
}
