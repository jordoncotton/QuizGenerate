using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGenerate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Question
        {
            private readonly string Ask;
        }

        public class Answer
        {
            private readonly string Give;
        }

        public class Quiz
        {
           //
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
    }
}
