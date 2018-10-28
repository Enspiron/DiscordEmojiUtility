using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmojiMakerGUI
{
    public partial class Form1 : Form
    {
        static string[] convert(string str)
        {
            string[] array = new string[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                array[i] = str[i].ToString();
            }
            string[] emoji = new string[str.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != " " && array[i] != "?")
                {
                    emoji[i] = $" :regional_indicator_{array[i].ToLower()}:";
                }
                else if (array[i] == "?")
                {
                    //:question: 
                    emoji[i] = $":question: ";
                }
                else
                {
                    emoji[i] = "    ";
                }
            }
            return emoji;
        }
        static string toString(string[] array)
        {
            string sent = "";
            for (int i = 0; i < array.Length; i++)
            {
                sent += ($"{array[i]}");
            }
            return sent;
        }

        static string[] splitSentence(string sentence)
        {                 
            string[] split = new string[sentence.Split(' ').Length];
            split = sentence.Split(' ');

            return split;
        }

        static string fillSplit(string[] array, string fill)
        {
            string filled = "";
            for (int i = 0; i < array.Length - 1; i++)
            {
                filled += $"{array[i]} {fill} ";
            }
            filled += $"{array[array.Length - 1]}";
            return filled;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(custom.Checked)
            {
                label3.Show();
                label4.Show();
                customtext.Show();
                customEmoji.Show();
            }
            else
            {
                label3.Hide();
                label4.Hide();
                customEmoji.Hide();
                customtext.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = toString(convert(originalText.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(custom.Checked)
            {                
                richTextBox1.Text = fillSplit(splitSentence(originalText.Text), $":{customtext.Text}:");
            }
        }

        private void claps_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = fillSplit(splitSentence(originalText.Text), ":clap:");
        }
    }
}
