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

namespace CalculatorApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Title = "Tyrell's Calculator"; //Changes the Window title
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen; //Starts window in center of screen
        }


        private void buttonAddition_Click(object sender, RoutedEventArgs e)
        {
            double input1 = convertNum1();
            double input2 = convertNum2();
            double result = input1 + input2;

            AnswerReturn.Text = Convert.ToString(result);
        }

        private void buttonSubtract_Click(object sender, RoutedEventArgs e)
        {
            double input1 = convertNum1();
            double input2 = convertNum2();
            double result = input1 - input2;

            AnswerReturn.Text = Convert.ToString(result);
        }

        private void buttonMultiply_Click(object sender, RoutedEventArgs e)
        {
            double input1 = convertNum1();
            double input2 = convertNum2();
            double result = input1 * input2;

            AnswerReturn.Text = Convert.ToString(result);
        }

        private void buttonDivide_Click(object sender, RoutedEventArgs e)
        {
            double input1 = convertNum1();
            double input2 = convertNum2();

            if (input2 != 0) //prevent divide by zero
            {
                double result = input1 / input2;
                AnswerReturn.Text = Convert.ToString(result);
             }

            else
            {
                AnswerReturn.Text = ("Cannot divide by zero");
            }

         }

        private double convertNum1()
        {
            double Num1output;
            try //try line of code
            {
                Num1output = Convert.ToDouble(Textbox1.Text);
            }
            catch(Exception) //if code breaks then stop and do this
            {
                Num1output = 0.0;
                Textbox1.Text = Convert.ToString("Error: " + Num1output);
            }
            return Num1output;
        }

        private double convertNum2()
        {
            double Num2output;
            try //try line of code
            {
                Num2output = Convert.ToDouble(Textbox2.Text);
            }
            catch (Exception) //if code breaks then stop and do this
            {
                Num2output = 0.0;
                Textbox2.Text = Convert.ToString("Error: " + Num2output);
            }
            return Num2output;
        }
    }
}
