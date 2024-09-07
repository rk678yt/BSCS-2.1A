using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordGuessApplication
{
    public partial class String : Form
    {
        //The correct word, and the word but hidden by question marks
        string correctword = "Computer";
        string hiddenword = "C??????r";
        public String()
        {
            InitializeComponent();
        }

        private void MysteryWord_Click(object sender, EventArgs e)
        {
            //Upon starting this application, the hidden word is shown first
            MysteryWord.Text = hiddenword;
        }

        private void GuessButton_Click(object sender, EventArgs e)
        {
            //The correct answer is in the string correctword
            string correctanswer = correctword;

            //string names is what's inputted from the text
            string names = InputText.Text;

            //Initializing stringbuilder
            StringBuilder list = new StringBuilder(names);

            //If the word guessed is blank
            if (names == "")
            {
            }

            //If the word guessed is incorrect
            else if (names != correctanswer)
            {
                WrongGuessesList.Items.Add(list);
                MessageBox.Show(names + " is incorrect.\nTry again.");
            }

            //If the word guessed is correct
            else if (names == correctanswer)
            {
                MysteryWord.Text = correctword;
                MessageBox.Show("Good job!\nyou guessed the word!");
                MessageBox.Show("Click OK to reset the word guessing game.");
                WrongGuessesList.Items.Clear();
                MysteryWord.Text = hiddenword;
            }

            //For clearing textbox
            InputText.Clear();
        }

        private void InputText_TextChanged(object sender, EventArgs e)
        {
        }

        private void WrongGuessesList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //For clearing the wrong guesses
            WrongGuessesList.Items.Clear();
        }
    }
}
