using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScientificCalculator
{
    public partial class FrmCalculator : Form
    {
        double FirstNumber;
        string Operation;
        public FrmCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (txtText.Text == "0" && txtText.Text != null)
            {
                txtText.Text = "1";
                txtContent.Text = "1";
            }
            else
            {
                txtText.Text = txtText.Text + "1";
                txtContent.Text = txtContent.Text + "1";
            }  
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (txtText.Text == "0" && txtText.Text != null)
            {
                txtText.Text = "2";
                txtContent.Text = "2";
            }
            else
            {
                txtText.Text = txtText.Text + "2";
                txtContent.Text = txtContent.Text + "2";
            }  
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (txtText.Text == "0" && txtText.Text != null)
            {
                txtText.Text = "3";
                txtContent.Text = "3";
            }
            else
            {
                txtText.Text = txtText.Text + "3";
                txtContent.Text = txtContent.Text + "3";
            }  
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (txtText.Text == "0" && txtText.Text != null)
            {
                txtText.Text = "4";
                txtContent.Text = "4";
            }
            else
            {
                txtText.Text = txtText.Text + "4";
                txtContent.Text = txtContent.Text + "4";
            }  
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (txtText.Text == "0" && txtText.Text != null)
            {
                txtText.Text = "5";
                txtContent.Text = "5";
            }
            else
            {
                txtText.Text = txtText.Text + "5";
                txtContent.Text = txtContent.Text + "5";
            }  
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (txtText.Text == "0" && txtText.Text != null)
            {
                txtText.Text = "6";
                txtContent.Text = "6";
            }
            else
            {
                txtText.Text = txtText.Text + "6";
                txtContent.Text = txtContent.Text + "6";
            }  
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (txtText.Text == "0" && txtText.Text != null)
            {
                txtText.Text = "7";
                txtContent.Text = "7";
            }
            else
            {
                txtText.Text = txtText.Text + "7";
                txtContent.Text = txtContent.Text + "7";
            }  
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (txtText.Text == "0" && txtText.Text != null)
            {
                txtText.Text = "8";
                txtContent.Text = "8";
            }
            else
            {
                txtText.Text = txtText.Text + "8";
                txtContent.Text = txtContent.Text + "8";
            }  
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (txtText.Text == "0" && txtText.Text != null)
            {
                txtText.Text = "9";
                txtContent.Text = "9";
            }
            else
            {
                txtText.Text = txtText.Text + "9";
                txtContent.Text = txtContent.Text + "9";
            }  
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtText.Text = txtText.Text + "0";
            txtContent.Text = txtContent.Text + "0";
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            txtText.Text = txtText.Text + ".";
            txtContent.Text = txtContent.Text + ".";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtText.Text);
            txtText.Text = "";
            txtContent.Text = txtContent.Text + "/";
            Operation = "/";  
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtText.Text);
            txtText.Text = "";
            txtContent.Text = txtContent.Text + "x";
            Operation = "*";  
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtText.Text);
            txtText.Text = "";
            txtContent.Text = txtContent.Text + "-";
            Operation = "-";  
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtText.Text);
            txtText.Text = "";
            txtContent.Text = txtContent.Text + "+";
            Operation = "+";  
        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            txtText.Text = "";
            txtContent.Text = "";
        }
        private void btnC_Click(object sender, EventArgs e)
        {
            if (txtText.Text.Length > 0)
            {
                txtText.Text = txtText.Text.Substring(0, txtText.Text.Length - 1);
            }
            if (txtContent.Text.Length > 0)
            {
                txtContent.Text = txtContent.Text.Substring(0, txtContent.Text.Length - 1);
            }
        }

        private void btnsin_Click(object sender, EventArgs e)
        {
            txtText.Text = "";
            txtContent.Text = "sin(";
            Operation = "sin";  
        }

        private void btncos_Click(object sender, EventArgs e)
        {
            txtText.Text = "";
            txtContent.Text = "cos(";
            Operation = "cos";  
        }

        private void btntan_Click(object sender, EventArgs e)
        {
            txtText.Text = "";
            txtContent.Text = "tan(";
            Operation = "tan";
        }
        private void btnLog_Click(object sender, EventArgs e)
        {
            txtText.Text = "";
            txtContent.Text = "log(";
            Operation = "log";
        }
        private void btnExp_Click(object sender, EventArgs e)
        {
            txtText.Text = "";
            txtContent.Text = "exp(";
            Operation = "exp";
        }
        private void btnMod_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtText.Text);
            txtText.Text = "";
            txtContent.Text = txtContent.Text + "%";
            Operation = "mod";
        }
        private void btnx2_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtText.Text);
            txtContent.Text = txtContent.Text + "^2";
            Operation = "square";
        }
        private void btnxy_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtText.Text);
            txtText.Text = "";
            txtContent.Text = txtContent.Text + "^";
            Operation = "power";
        }
        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            txtText.Text = "";
            txtContent.Text = "√";
            Operation = "SquareRoot";
        }
        private void btnNfact_Click(object sender, EventArgs e)
        {
            txtText.Text = "";
            txtContent.Text = "factorial(";
            Operation = "fact";
        }
        private void btnTenX_Click(object sender, EventArgs e)
        {
            txtText.Text = "";
            txtContent.Text = "10^";
            Operation = "TenPower";
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            double SecondNumber;  
            double Result;  
  
            SecondNumber = Convert.ToDouble(txtText.Text);  
  
            if (Operation == "+")  
            {  
                Result = (FirstNumber + SecondNumber);  
                txtText.Text = Convert.ToString(Result);
                FirstNumber = Result;  
            }  
            if (Operation == "-")  
            {  
                Result = (FirstNumber - SecondNumber);  
                txtText.Text = Convert.ToString(Result);  
                FirstNumber = Result;  
            }  
            if (Operation == "*")  
            {  
                Result = (FirstNumber * SecondNumber);  
                txtText.Text = Convert.ToString(Result);  
                FirstNumber = Result;  
            }  
            if (Operation == "/")  
            {  
                if (SecondNumber == 0)  
                {  
                    txtText.Text = "Cannot divide by zero";  
  
                }  
                else  
                {  
                    Result = (FirstNumber / SecondNumber);  
                    txtText.Text = Convert.ToString(Result);  
                    FirstNumber = Result;  
                }  
            }
            if (Operation == "sin")
            {
                double degree = SecondNumber;
                double radians = degree * Math.PI / 180;
                Result = Math.Sin(radians);
                txtText.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "cos")
            {
                double degree = SecondNumber;
                double radians = degree * Math.PI / 180;
                Result = Math.Cos(radians);
                txtText.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "tan")
            {
                double degree = SecondNumber;
                double radians = degree * Math.PI / 180;
                Result = Math.Tan(radians);
                txtText.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "log")
            {
                double number = SecondNumber;
                Result = Math.Log(number);
                txtText.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "exp")
            {
                double number = SecondNumber;
                Result = Math.Exp(number);
                txtText.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "mod")
            {
                Result = Math.IEEERemainder(FirstNumber, SecondNumber);
                txtText.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "square")
            {
                
                Result = FirstNumber * FirstNumber;
                txtText.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "power")
            {
                Result = Math.Pow(FirstNumber, SecondNumber);
                txtText.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "fact")
            {
                int result = 1;

                if (SecondNumber == 0 || SecondNumber == 1)
                {
                    result = 1;
                }
                else
                {
                    for (int i = 2; i <= SecondNumber; i++)
                    {
                        result *= i;
                    }
                }
                txtText.Text = result.ToString();
                FirstNumber = result;
            }
            if (Operation == "TenPower")
            {
                Result = Math.Pow(10, SecondNumber);
                txtText.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
    }
}