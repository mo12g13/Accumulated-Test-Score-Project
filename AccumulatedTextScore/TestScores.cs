using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Author: Momo Johnson
 * C Sharp Project 8
 * This application calculates the total, finds the minimum, maximimum, sorted, unsorted and amount of 
 * test scores enter by the user
 * 
 * */
namespace AccumulatedTextScore
{
    public partial class TestScores : Form
    {
        
        List<int> gradeList = new List<int>();
        public TestScores()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //An action listener that add grades to the grade list when click
        private void btnAdd_Click(object sender, EventArgs e)
        {            
           try
            {
                //A validate method that validate the inputs enter by the user
                if (isValidData())
                {
                       //Parsing of the string to an integer
                    int number = Int32.Parse(txtScoreInput.Text);
                    //Adding of grades to the gradeList
                    gradeList.Add(number);
                    //Setting the total grades score using the gradeTotal method
                    lblscoreTotal.Text = gradeTotal(gradeList).ToString();
                    //Setting the average grade using the method 
                    lblAverage.Text = average(gradeList).ToString();
                    //Setting the score count using the score count method
                    lblScoreCount.Text = gradeCount(gradeList).ToString();
                    int max = gradeList.Max();
                    int min = gradeList.Min();
                    lblMaxValue.Text = "" + max;
                    lblMinValue.Text = "" + min;               
                }
            }catch(Exception)
            {
                //If an exception occur Show a message to the user
                MessageBox.Show("An Exception has occured");
            }
            //Clearing the score inputs and Setting the focus back in the text box
            txtScoreInput.Clear();
            txtScoreInput.Focus();              
           
        }
           
        // A method that checks if the user didn't enter any string
        private bool isPresent(TextBox textBox, String name)
        {
            //If the textBox is empty, show a message telling the user that the textBox
            if(textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field");
                textBox.Focus();
                textBox.Clear();
                return false;
            }
            return true;
        }
        //A method that checks if the string enter in a textBox is an integer and if is greater than zero and less or equal to 100
        private bool isInteger(TextBox textBox, String name)
        {
            int number;
            if(Int32.TryParse(textBox.Text, out number))
            {
                if(number > 0 && number <= 100)
                {
                    return true;
                }
            }
            //If the string isn't a number, show a message and ask the user to enter a number between 1-100
            MessageBox.Show(name + " must be an Integer from 1-100");
            textBox.Focus();
            textBox.Clear();
            return false;
        }
        //A method that validates the input enter by the user
        public bool isValidData()
        {
            if (!isPresent(txtScoreInput, "Score"))
                return false;
            if (!isInteger(txtScoreInput, "Score"))
                return false;
            return true;
        }
        //A Action event that display the scores enter by the user
       
        //A method that calculate the grade total from the list
        private int gradeTotal(List<int> grades)
        {
            int number=0;
            foreach (int grade in gradeList)
                number += grade;
           return number;           
        }

        //A method that counts the number grades enter by the user
        private int gradeCount(List<int> countGrades)
        {
            return countGrades.Count();
        }
        //A method that calculates the average of the grades
        private int average(List<int> grades)
        {
            int value =0;
            foreach (int number in grades)
                value += number;
            return value / grades.Count();

        }
        
        // An action event that that clears the scores enter by the user 
        private void btnClearScores_Click(object sender, EventArgs e)
        {
            //Dialog result that clears the input if the user presses the yes button
            DialogResult result = MessageBox.Show("Are you sure you want to clear the scores", "Confirmation?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                gradeList.Clear();
                lblAverage.Text = "";
                lblScoreCount.Text = "";
                lblscoreTotal.Text = "";
                txtScoreInput.Clear();
                lblMinValue.Text = "";
                lblMaxValue.Text = "";
                txtScoreInput.Focus();
                //A dialog result that takes appropriate actions if the user presses Yes, No or cancel
            }else if(result == DialogResult.Cancel)
            {   //A dialogue result that exit the form if the user presses the Yes button
                DialogResult resultYes =MessageBox.Show("Are you sure you want to cancel", "Confirmation", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resultYes == DialogResult.Yes)
                {
                    this.Close();
                }

            }
                   
        }
        // An action event that exits the form when the user clicks the exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want quit?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
           
           
           if(result == DialogResult.Yes)
            {
                this.Close();
            }
           else if(result == DialogResult.Cancel)
            {
                DialogResult result1 =MessageBox.Show("Are you sure you want to cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result1 == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            
        }
        //An event handler that display the unsorted scores when clicked
        private void btnUnscoredGrades_Click(object sender, EventArgs e)
        {
            {
                
                String grades = " ";
               
                foreach (int number in gradeList)
                {

                    grades += number + "\n";

                }
                MessageBox.Show(grades, "Unsorted Grades");

            }
            
        }

        //A method that sort the grades in the list
        private List<int> sortedList(List<int> sortedGrads)
        {
            List<int> newList = new List<int>(sortedGrads);
          
            for (int i = 0; i < newList.Count - 1; i++)
            {
                for (int j = 0; j < newList.Count - 1 - i; j++)
                {
                    if (newList[j] > newList[j + 1])
                    {
                        int temp = newList[j];
                        newList[j] = newList[j + 1];
                        newList[j + 1] = temp;
                    }
                }
            }
            return sortedGrads;
        }
        //A method that sorts the score added to the list
        private void sorrtedScores_Click(object sender, EventArgs e)
        {
            String grades = " ";
            List<int> sortedGrades = new List<int>(gradeList);
            List<int> gradeSorted = sortedList(sortedGrades);
            gradeSorted.Sort();
            foreach (int a in gradeSorted)
            {
                grades += a + "\n";
            }
            MessageBox.Show(grades, "Sorted Grades");
        }
    }
}
