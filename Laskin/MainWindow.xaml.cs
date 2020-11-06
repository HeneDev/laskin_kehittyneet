using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Laskin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Double result = 0;
        Double tempResult = 0;
        String operation = "";
        bool enter_value = false;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void changeLabelText(Double result, Double tempResult)
        {
            lblDisplay.Text = System.Convert.ToString(result) + " " + operation + " ";
            lblDisplay.Text += tempResult.ToString() + " " + " = ";
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if ((txtDisplay.Text == "0"))
            {
                txtDisplay.Text = "";
            }

            txtDisplay.Text = txtDisplay.Text + "0";
            enter_value = true;
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if ((txtDisplay.Text == "0"))
            {
                txtDisplay.Text = "";
            }

            txtDisplay.Text = txtDisplay.Text + "1";
            enter_value = true;
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if ((txtDisplay.Text == "0"))
            {
                txtDisplay.Text = "";
            }

            txtDisplay.Text = txtDisplay.Text + "2";
            enter_value = true;
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if ((txtDisplay.Text == "0"))
            {
                txtDisplay.Text = "";
            }

            txtDisplay.Text = txtDisplay.Text + "3";
            enter_value = true;
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if ((txtDisplay.Text == "0"))
            {
                txtDisplay.Text = "";
            }

            txtDisplay.Text = txtDisplay.Text + "4";
            enter_value = true;
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if ((txtDisplay.Text == "0"))
            {
                txtDisplay.Text = "";
            }

            txtDisplay.Text = txtDisplay.Text + "5";
            enter_value = true;
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if ((txtDisplay.Text == "0"))
            {
                txtDisplay.Text = "";
            }

            txtDisplay.Text = txtDisplay.Text + "6";
            enter_value = true;
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "";
            }

            txtDisplay.Text = txtDisplay.Text + "7";
            enter_value = true;
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "";
            }

            txtDisplay.Text = txtDisplay.Text + "8";
            enter_value = true;
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "";
            }

            txtDisplay.Text = txtDisplay.Text + "9";
            enter_value = true;
        }

        private void btnClearEntry_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = "0";
            result = 0;
            lblDisplay.Text = "";
        }

        private void btnBackspace_Click(object sender, RoutedEventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }

            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            result = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = "0";
            lblDisplay.Text = System.Convert.ToString(result) + " " + operation + " ";
            enter_value = false;
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            result = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = "0";
            lblDisplay.Text = System.Convert.ToString(result) + " " + operation + " ";
            enter_value = false;
        }

        private void btnTimes_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            result = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = "0";
            lblDisplay.Text = System.Convert.ToString(result) + " " + operation + " ";
            enter_value = false;
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            result = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = "0";
            lblDisplay.Text = System.Convert.ToString(result) + " " + operation + " ";
            enter_value = false;
        }

        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            switch(operation)
            {
                case "+":
                    if (enter_value)
                    {
                        tempResult = Double.Parse(txtDisplay.Text);
                    }
                    changeLabelText(result, tempResult);
                    result += tempResult;
                    txtDisplay.Text = result.ToString();
                    enter_value = false;
                    break;

                case "-":
                    if (enter_value)
                    {
                        tempResult = Double.Parse(txtDisplay.Text);
                    }
                    changeLabelText(result, tempResult);
                    result -= tempResult;
                    txtDisplay.Text = result.ToString();
                    enter_value = false;
                    break;

                case "*":
                    if (enter_value)
                    {
                        tempResult = Double.Parse(txtDisplay.Text);
                    }
                    changeLabelText(result, tempResult);
                    result *= tempResult;
                    txtDisplay.Text = result.ToString();
                    enter_value = false;
                    break;

                case "/":
                    if (enter_value)
                    {
                        tempResult = Double.Parse(txtDisplay.Text);
                    }
                    changeLabelText(result, tempResult);
                    result /= tempResult;
                    txtDisplay.Text = result.ToString();
                    enter_value = false;
                    break;

                case "Mod":
                    if (enter_value)
                    {
                        tempResult = Double.Parse(txtDisplay.Text);
                    }
                    changeLabelText(result, tempResult);
                    result %= tempResult;
                    txtDisplay.Text = result.ToString();
                    enter_value = false;
                    break;

                case "Exp":
                    double i = Double.Parse(txtDisplay.Text);
                    double j = result;
                    txtDisplay.Text = Math.Exp(i * Math.Log(j * 4)).ToString();
                    break;
            }
        }

        private void btnComma_Click(object sender, RoutedEventArgs e)
        {
            if ((txtDisplay.Text == "0"))
            {
                txtDisplay.Text = "";
            }

            txtDisplay.Text = txtDisplay.Text + ",";
        }

        private void btnPosNeg_Click(object sender, RoutedEventArgs e)
        {
            result = Double.Parse(txtDisplay.Text);
            result *= -1;
            txtDisplay.Text = System.Convert.ToString(result);
        }

        private void btnModulus_Click(object sender, RoutedEventArgs e)
        {
            operation = "Mod";
            result = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = "0";
            lblDisplay.Text = System.Convert.ToString(result) + " " + operation + " ";
            enter_value = false;
        }

        private void btn1x_Click(object sender, RoutedEventArgs e)
        {
            double x;
            x = Convert.ToDouble(1.0 / Convert.ToDouble(txtDisplay.Text));
            txtDisplay.Text = System.Convert.ToString(x);
        }

        private void btnPower_Click(object sender, RoutedEventArgs e)
        {
            operation = "^ 2";
            result = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = (Math.Pow(result, 2)).ToString();
            lblDisplay.Text = System.Convert.ToString(result) + " " + operation + " ";
            result = Math.Pow(Double.Parse(txtDisplay.Text), 2);
            enter_value = false;

        }

        private void btnSqrt_Click(object sender, RoutedEventArgs e)
        {
            double sqrt = Double.Parse(txtDisplay.Text);
            sqrt = Math.Sqrt(sqrt);
            txtDisplay.Text = System.Convert.ToString(sqrt);
            lblDisplay.Text = System.Convert.ToString(result) + " " + operation + " ";
            enter_value = false;
        }

        private void MenuStandardClick(object sender, RoutedEventArgs e)
        {
            this.Width = 330;
            this.txtDisplay.Width = 310;
            this.lblDisplay.Width = 310;
        }

        private void MenuScientificClick(object sender, RoutedEventArgs e)
        {
            this.Width = 680;
            this.txtDisplay.Width = 670;
            this.lblDisplay.Width = 670;
        }

        private void MenuTemperatureClick(object sender, RoutedEventArgs e)
        {

        }

        private void MenuExitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
