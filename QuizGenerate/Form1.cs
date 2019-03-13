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

        public class  Question
        {
            private readonly string Ask;
            
            Question ask = new Question();
        }

        

        public class Answer
        {
            private readonly string Give;

            Answer give = new Answer();
        }

        public class Quiz
        {
            Question: List<Question>
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

        private static void Main(string[] args)
        {

        }
    }

}
