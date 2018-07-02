using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;

namespace Calculator_Better_Design
{
    public partial class CalculatorForm : Form
    {
        public Calculator calculator;
        public CalculatorForm()
        {
            InitializeComponent();
            calculator = new Calculator();
        }
        private bool operation_clicked = false;
        private bool operation_clicked_fordecimal = false;

        private void Digit_Click(object sender, EventArgs e)
        {
            Button digit_button = (Button)sender;
            string digit = digit_button.Tag.ToString();
            if (display.Text == "0" || (operation_clicked && !operation_clicked_fordecimal))
            {
                display.Text = calculator.Number_entered(Convert.ToDouble(digit));
            }
            else
            {
                string number = display.Text + digit;
                display.Text = calculator.Number_entered(Convert.ToDouble(number));
            }
        }

        private void Operation_Click(object sender, EventArgs e)
        {
            Button operation_button = (Button)sender;
            switch (operation_button.Tag)
            {
                case "+": display.Text = calculator.Addition_entered(); break;
                case "-": display.Text = calculator.Subtraction_entered(); break;
                case "*": display.Text = calculator.Multiplication_entered(); break;
                case "/": display.Text = calculator.Division_entered(); break;
                case "=": display.Text = display.Text = calculator.Equals(); break;
                case "reciprocal": display.Text = calculator.Reciprocal_entered(); break;
                case "square_root": display.Text = calculator.Square_root_entered(); break;
                case "clear": display.Text = calculator.Clear_entered(); break;
                case "change_sign": display.Text = calculator.Change_Sign_Click(double.Parse(display.Text)); break;
                case "decimal_point": display.Text = calculator.Decimal_point_Click(display.Text); operation_clicked_fordecimal = true; break;
                default: display.Text = "Illegal entry.  Must be a number or [+|-|*|/|reciprocal|square_root]"; break;
            }
            operation_clicked = true;
        }
    }
}
