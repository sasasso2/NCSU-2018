/* App name: arithmeticIsCool.org
App purpose: this app calculates different mathmatical equations and sequences
 App developers: Samantha Alexa Sassorossi and Charlotte Roberts on 3/20/2018 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Major_Project_2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        int start, end;

        private void exitbutton_Click(object sender, EventArgs e)
        {
            //Alexa completed this button

            // Exit Confirmation
            DialogResult dialog = MessageBox.Show("Are you sure you want to exit?", this.Text,
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //If answer is yes, close the app
            if (dialog == DialogResult.Yes)
                this.Close();
        }

        private void starttextBox_TextChanged(object sender, EventArgs e)
        {
            resultlistBox.Items.Clear();
        }

        private void endtextBox_TextChanged(object sender, EventArgs e)
        {
            resultlistBox.Items.Clear();
        }

        private void starttextBox_Click(object sender, EventArgs e)
        {
            starttextBox.SelectAll();
        }

        private void endtextBox_Click(object sender, EventArgs e)
        {
            endtextBox.SelectAll();
        }

        private void starttextBox_Validating(object sender, CancelEventArgs e)
        {
            //Alexa completed this 

            //validate input
            int value = 0;
            int.TryParse(starttextBox.Text, out value);
            if (value == 0)
            {
                MessageBox.Show("Please enter an integer", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                starttextBox.Focus();
                starttextBox.SelectAll();
                e.Cancel = true;
            }
        }

        private void endtextBox_Validating(object sender, CancelEventArgs e)
        {
            //Alexa completed this

            //clear listbox
            resultlistBox.Items.Clear();

            //validate input
            int value = 0;
            int.TryParse(endtextBox.Text, out value);
            if (value == 0)
            {
                MessageBox.Show("Please enter an integer", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                endtextBox.Focus();
                endtextBox.SelectAll();
                e.Cancel = true;
            }
        }

        private void starttextBox_Enter(object sender, EventArgs e)
        {
            starttextBox.SelectAll();
        }

        private void endtextBox_Enter(object sender, EventArgs e)
        {
            endtextBox.SelectAll();
        }

        private void countbutton_Click(object sender, EventArgs e)
        {
            //Alexa completed this button

            //clear listbox
            resultlistBox.Items.Clear();

            int counter, counttt = 0;

            int.TryParse(starttextBox.Text, out start);
            int.TryParse(endtextBox.Text, out end);

            for (counter = start; counter <= end; counter++)
            {
                counttt++; 
            }
            resultlistBox.Items.Add("Count of values between " + start.ToString("N0") + " and " + end.ToString("N0") + ": " + counttt.ToString("N0"));
        }

        private void exponentionbutton_Click(object sender, EventArgs e)
        {
            //Alexa completed this button

            //clear listbox
            resultlistBox.Items.Clear();

            int.TryParse(starttextBox.Text, out start);
            int.TryParse(endtextBox.Text, out end);
            int exponent = 0;

            //learned how to do this from this website https://stackoverflow.com/questions/3034604/is-there-an-exponent-operator-in-c
            exponent = (int)Math.Pow(start, end);

            resultlistBox.Items.Add(start.ToString("N0") + " raised to the power of " + end.ToString("N0") + " : " + exponent.ToString("N0"));
        }

        private void factorialbutton_Click(object sender, EventArgs e)
        {
            //Alexa completed this button

            //clear listbox
            resultlistBox.Items.Clear();

            //declare variable
            int factorial = 1;
            //grab data
            int.TryParse(starttextBox.Text, out start);

            //for loop
            for (int x = start; x > 0; x--)
            {
                //calculate loop
                factorial = (factorial * x);
            }
            //display output
            resultlistBox.Items.Add(start.ToString("N0") + "!" + " = " + factorial.ToString("N0"));

        }

        private void multiplicationTablebutton_Click(object sender, EventArgs e)
        {
            //Alexa completed this button

            //clear listbox
            resultlistBox.Items.Clear();

            int.TryParse(starttextBox.Text, out start);
            int product = 0;

            if (start > 12)
                MessageBox.Show("Please choose a number less than or equal to 12");
            else
            {
                //create loop
                for (int x = 1; x <= 12; x++)
                {
                    product = start * x;
                    resultlistBox.Items.Add(x.ToString("N0") + " * " + start.ToString("N0") + " = " + product.ToString("N0"));
                }
            }
        }

        private void pythagoreanTheormbutton_Click(object sender, EventArgs e)
        {
            //Alexa completed this button

            //clear listbox
            resultlistBox.Items.Clear();

            var a2 = "a\xB2";
            var b2 = "b\xB2";
            var c2 = "c\xB2";

            int.TryParse(starttextBox.Text, out start);
            int.TryParse(endtextBox.Text, out end);

            double a = (double)start;
            double b = (double)end;

            if ((start <= 0) && (end <= 0))
                MessageBox.Show("Please choose a number greater than 0");
            
            else
            {
                double asquared = a * a;
                double bsqaured = b * b;
                double csquared = asquared + bsqaured;
                double c = Math.Sqrt(csquared);
                double ab = asquared + bsqaured;

                resultlistBox.Items.Add(a2 + " + " + b2 + " = " + c2);
                resultlistBox.Items.Add(asquared + " + " + bsqaured + " = " + c2);
                resultlistBox.Items.Add(ab.ToString("N2") + " = " + c2);
                resultlistBox.Items.Add(c.ToString("N2") + " = c");

            }

        }

        private void sumOfSquaresbutton_Click(object sender, EventArgs e)
        {
            //Alexa completed this button

            //clear listbox
            resultlistBox.Items.Clear();

            //declare variables
            int sumNumbers = 0, sumSquares = 0, counter = 0, square = 0;
            int.TryParse(starttextBox.Text, out start);
            int.TryParse(endtextBox.Text, out end);

            if ((start == 0) && (end == 0))
                MessageBox.Show("Both inputs can not be 0");
            if (start > end)
                MessageBox.Show("The start number must be less than the end number");
            else
            {
                for (counter = start; counter <= end; counter++)
                {
                    square = counter * counter;
                    resultlistBox.Items.Add("The number is: " + counter.ToString("N0") + " and its square is: " +
square.ToString("N0"));
                    sumNumbers +=  counter;
                    sumSquares +=  square;
                }
                resultlistBox.Items.Add("");
                resultlistBox.Items.Add("Sum of numbers: " + sumNumbers.ToString("N0") + " Sum of squares: " + sumSquares.ToString("N0"));
            }

        }

        private void absoluteValuebutton_Click(object sender, EventArgs e)
        {
            //Alexa completed this button

            //clear listbox
            resultlistBox.Items.Clear();

            int abStart, abEnd;

            int.TryParse(starttextBox.Text, out start);
            int.TryParse(endtextBox.Text, out end);

            abStart = Math.Abs(start);
            abEnd = Math.Abs(end);

            resultlistBox.Items.Add("The absolute value of " + start.ToString("N0") + " : " + abStart.ToString("N0"));
            resultlistBox.Items.Add("The absolute value of " + end.ToString("N0") + " : " + abEnd.ToString("N0"));
        }
    }
}
