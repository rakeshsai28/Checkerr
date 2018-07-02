using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic_Interfaces;

namespace Logic
{
    public class Calculator
    {
        private IBinaryOperation binary_pending_operation = null;
        private IUnaryOperation unary_pending_operation = null;
        private bool is_num_entered = false;
        private bool is_decimal_entered = false;
        private bool is_equals_entered = false;
        private double lhs = 0;
        private double rhs = 0;
        public string result = "0";

        public string Equals()
        {
            is_equals_entered = true;
            if (binary_pending_operation != null)
            {
                if (is_num_entered)
                {
                    lhs = rhs; is_num_entered = false;
                    return result;
                }
                result = binary_pending_operation.Perform_binary_calculation(Convert.ToDouble(result), lhs).ToString();
                return result;
            }
            else
            {
                if (!result.Contains(".")) { is_decimal_entered = false; }
                return result;
            }
        }

        public string Clear_entered()
        {
            lhs = 0;
            rhs = 0;
            result = "0";
            is_num_entered = false;
            is_decimal_entered = false;
            binary_pending_operation = null;
            unary_pending_operation = null;
            return result;
        }


        public string Number_entered(double value)
        {
            is_num_entered = true;
            if (is_equals_entered) { Clear_entered(); is_equals_entered = false; }
            if (binary_pending_operation != null)
            {
                rhs = value;
                if ((binary_pending_operation.GetType().ToString() == "Logic.Division") && rhs == 0)
                { Clear_entered(); return "Divide by Zero Error"; }
                result = binary_pending_operation.Perform_binary_calculation(Convert.ToDouble(result), rhs).ToString();
                return rhs.ToString();
            }
            else { lhs = value; result = lhs.ToString(); return lhs.ToString(); }
        }

        public string Addition_entered()
        {

            is_num_entered = false;
            unary_pending_operation = null;
            binary_pending_operation = new Addition();
            return result;
        }

        public string Subtraction_entered()
        {
            is_num_entered = false;
            unary_pending_operation = null;
            binary_pending_operation = new Subtraction();
            return result;
        }
        public string Decimal_point_Click(string Display)
        {
            if (is_decimal_entered)
                return Display;
            is_decimal_entered = true;
            return Display + ".";
        }

        public string Multiplication_entered()
        {
            is_num_entered = false;
            unary_pending_operation = null;
            binary_pending_operation = new Multiplication();
            return result;
        }

        public string Division_entered()
        {
            is_num_entered = false;
            unary_pending_operation = null;
            binary_pending_operation = new Division();
            return result;
        }

        public string Change_Sign_Click(double value)
        {
            value = -value;
            result = value.ToString();
            return value.ToString();
        }

        public string Reciprocal_entered()
        {
            is_num_entered = false;
            binary_pending_operation = null;
            unary_pending_operation = new Reciprocal();
            if (Convert.ToDouble(result) == 0.0) { Clear_entered(); return "Divide by Zero Error"; }
            lhs = unary_pending_operation.Perform_unary_calculation(Convert.ToDouble(result));
            result = lhs.ToString();
            return lhs.ToString();

        }

        public string Square_root_entered()
        {
            is_num_entered = false;
            binary_pending_operation = null;
            unary_pending_operation = new Square_root();
            if (Convert.ToDouble(result) < 0.0) { Clear_entered(); return "Invalid Input"; }
            lhs = unary_pending_operation.Perform_unary_calculation(Convert.ToDouble(result));
            result = lhs.ToString();
            return lhs.ToString();

        }

    }

    public class Addition : Logic_Interfaces.IBinaryOperation
    {
        public double Perform_binary_calculation(double lhs, double rhs)
        {
            return lhs + rhs;
        }
    }

    public class Subtraction : Logic_Interfaces.IBinaryOperation
    {
        public double Perform_binary_calculation(double lhs, double rhs)
        {
            return lhs - rhs;
        }
    }

    public class Multiplication : Logic_Interfaces.IBinaryOperation
    {
        public double Perform_binary_calculation(double lhs, double rhs)
        {
            return lhs * rhs;
        }
    }

    public class Division : Logic_Interfaces.IBinaryOperation
    {
        public double Perform_binary_calculation(double lhs, double rhs)
        {
            return lhs / rhs;
        }
    }

    public class Reciprocal : Logic_Interfaces.IUnaryOperation
    {
        public double Perform_unary_calculation(double lhs)
        {
            return 1 / lhs;
        }
    }

    public class Square_root : Logic_Interfaces.IUnaryOperation
    {
        public double Perform_unary_calculation(double lhs)
        {
            return Math.Sqrt(lhs);
        }
    }
}

