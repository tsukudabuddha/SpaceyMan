using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _99_Final_Game
{
    public partial class YouLoseForm : Form
    {
        public YouLoseForm()
        {
            InitializeComponent();

        }
        
        public int score;
        private void YouLoseForm_Load(object sender, EventArgs e)
        {
            string line;
            int highScore;
            label2.Text = "Your Score: " + score.ToString();

            StreamReader inputFile;//Declares File Object
            inputFile = File.OpenText("highScores.txt");//Opens highscore File
            line = inputFile.ReadLine();//takes in text from file
            inputFile.Close();//Saves file
            highScore = int.Parse(line);
            
            
            if (score > highScore)
            {
                MessageBox.Show("High Score!");
                StreamWriter outputFile;//Declares File Object
                outputFile = File.CreateText("highScores.txt");
                outputFile.WriteLine(score.ToString());//Stores score in file
                outputFile.Close();//Saves file
                label4.Text = score.ToString();
            }
            else
            {
                label4.Text = highScore.ToString();
            }
                
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            score = 0;
            Application.Restart();
        }
    }
}
