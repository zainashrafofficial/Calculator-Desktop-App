using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //ClearButton_Click(Btn_AC, EventArgs.Empty);

            //Setting Cursor at Start, therefore, using Constructor of form
            TextBox.SelectionStart = TextBox.Text.Length;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        // Declaring Variables
        float resultValue = 0;
        string currentOperation = "";
        bool isOperationPerformed = false;


        // Common Event(customly created Event and then assigning each button this event) this event is for all the numbers, integers from 0 to 9.
        void NumberButton_Click(object sender, EventArgs e)
        {
            if ((TextBox.Text == "0") || (isOperationPerformed))
                TextBox.Clear();

            isOperationPerformed = false;

            // Button Ambiguouity Removing(By Including its reference)
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            TextBox.Text += button.Text;
        }

        //Common Event for all the operations such as "+, -, *, /, %"
        // This event is customly created and assigned to all these operational buttons.
        void OperationButton_Click(object sender, EventArgs e)
        {
            // Button Ambiguouity Removing
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;

            if (resultValue != 0)
            {
                Btn_equal.PerformClick();
                TextBox.Text = resultValue + " " + button.Text + " ";
                currentOperation = button.Text;
                isOperationPerformed = true;
            }
            else
            {
                currentOperation = button.Text;
                resultValue = float.Parse(TextBox.Text);
                TextBox.Text = TextBox.Text + " " + button.Text + " ";
                isOperationPerformed = true;
            }
        }

        // It is also custom created event, and assigning it to Equal Button. It uses switch statements according to the operation button clicked by user. That case will work whihc user enters.
        void EqualButton_Click(object sender, EventArgs e)
        {
            switch (currentOperation)
            {
                case "+":
                    TextBox.Text = (resultValue + float.Parse(TextBox.Text)).ToString();
                    break;
                case "-":
                    TextBox.Text = (resultValue - float.Parse(TextBox.Text)).ToString();
                    break;
                case "x":
                    TextBox.Text = (resultValue * float.Parse(TextBox.Text)).ToString();
                    break;
                case "÷":
                    TextBox.Text = (resultValue / float.Parse(TextBox.Text)).ToString();
                    break;
                case "%":
                    TextBox.Text = (resultValue % float.Parse(TextBox.Text)).ToString();
                    break;
                case "x²":
                    TextBox.Text = (resultValue * float.Parse(TextBox.Text)).ToString();
                    break;
            }

            resultValue = float.Parse(TextBox.Text);

            // Current Operation is null such that previous operation is being done. 
            currentOperation = "";
        }

        // Clear Button Functionality, making everything zero and null (AC Button ). It is also a customly created event which is then assigned to AC Button.
        private void ClearButton_Click(object sender, EventArgs e)
        {
            TextBox.Text = "0";
            resultValue = 0;
            currentOperation = "";
            isOperationPerformed = false;
        }

        // Dot Button Functionality ( For Floating Point Numbers )
        void DotButton_Click(object sender, EventArgs e)
        {
            // Check if the current text does not contain a dot and an operation was not performed .
            if (!TextBox.Text.Contains(".") && !isOperationPerformed)
            {
                if (TextBox.Text == string.Empty)
                {
                    // If the textbox is empty and dot is pressed, it will start with "0.".
                    TextBox.Text += "0.";
                }
                else
                {
                    // Append dot to the previus existing number.
                    TextBox.Text += ".";
                }
            }
            else if (isOperationPerformed)
            {
                // If an operation was performed, start a new number with "0."
                TextBox.Text = "0.";
                isOperationPerformed = false;
            }
        }

        // Custom Created Event such that it is clearing last character enter by user such that he can remove last character entered by mistake. this event is applied on button of "C"
        private void Btn_C_Click(object sender, EventArgs e)
        {
            if (TextBox.Text.Length > 0)
            {
                TextBox.Text = TextBox.Text.Remove(TextBox.Text.Length - 1);
            }
        }



    }
}
