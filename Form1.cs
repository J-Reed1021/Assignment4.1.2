namespace Assignment4._1._2
{
    public partial class Form1 : Form
    {
        double firstNumber = 0;
        string Operation = "";

        public Form1()
        {
            InitializeComponent();
        }

        public void Add()
        {
            firstNumber = Convert.ToDouble(ResultTextBox.Text);
            ResultTextBox.Text = "0";
            Operation = "+";
        }

        public void Subtract()
        {
            firstNumber = Convert.ToDouble(ResultTextBox.Text);
            ResultTextBox.Text = "0";
            Operation = "-";
        }
     
        public void Multiply()
        {
            firstNumber = Convert.ToDouble(ResultTextBox.Text);
            ResultTextBox.Text = "0";
            Operation = "*";
        }

        public void Divide() 
        {
            firstNumber = Convert.ToDouble(ResultTextBox.Text);
            ResultTextBox.Text = "0";
            Operation = "/";
        }
     

        private void Onebutton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "1";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + "1";
            }
        }

        private void Equalsbutton_Click(object sender, EventArgs e)
        {
            double secondNumber = Convert.ToDouble(ResultTextBox.Text);
            double result = 0;

            if (Operation == "+")
            {
                result = (firstNumber + secondNumber);
                ResultTextBox.Text = Convert.ToString(result);
                firstNumber = result;
            }
            if (Operation == "-")
            {
                result = (firstNumber - secondNumber);
                ResultTextBox.Text = Convert.ToString(result);
                firstNumber = result;
            }
            if (Operation == "*")
            {
                result = (firstNumber * secondNumber);
                ResultTextBox.Text = Convert.ToString(result);
                firstNumber = result;
            }
            if (Operation == "/")
            {
                if (secondNumber == 0)
                {
                    ResultTextBox.Text = "Cannot divide by zero";
                }
                else
                {
                    result = (firstNumber / secondNumber);
                    ResultTextBox.Text = Convert.ToString(result);
                    firstNumber = result;
                }
            }
        }
                   
        

        private void Decimalbutton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = ".";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + ".";
            }

        }

        private void Twobutton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "2";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + "2";
            }

        }

        private void Threebutton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "3";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + "3";
            }
        }

        private void Fourbutton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "4";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + "4";
            }
        }

        private void Fivebutton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "5";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + "5";
            }
        }

        private void Sixbutton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "6";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + "6";
            }
        }

        private void Sevenbutton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "7";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + "7";
            }
        }

        private void Eightbutton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "8";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + "8";
            }
        }

        private void Ninebutton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "9";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + "9";
            }
        }

        private void Zerobutton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "0";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + "0";
            }
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "0";
            }
            else
            {
                ResultTextBox.Text = "0";
            }
        }

        private void ResultTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void Addbutton_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void Subtractbutton_Click(object sender, EventArgs e)
        {
            Subtract();
        }

        private void Multiplybutton_Click(object sender, EventArgs e)
        {
            Multiply();
        }

        private void Dividebutton_Click(object sender, EventArgs e)
        {
            Divide();
        }

    }
}
