namespace Calculator
{
    public class CalculatorModel
    {
        public CalculatorModel()
        {
            
        }

        public object Calculate(int operand1, int operand2, char operation)
        {
            switch (operation)
            {
                case '+':
                    return CalculatePlus(operand1, operand2);
                case '-':
                    return CalculateMinus(operand1, operand2);
                case '*':
                    return CalculateMultiply(operand1, operand2);
                case '/':
                    return CalculateDivide(operand1, operand2);
            }
            return null;
        }

        private int CalculatePlus(int operand1, int operand2)
        {
            int result = operand1 + operand2;
            return result;
        }

        private int CalculateMinus(int operand1, int operand2)
        {
            int result = operand1 - operand2;
            return result;
        }

        private int CalculateMultiply(int operand1, int operand2)
        {
            int result = operand1 * operand2;
            return result;
        }

        private double CalculateDivide(int operand1, int operand2)
        {
            double result = (double)operand1 / (double)operand2;
            return result;
        }
    }
}
