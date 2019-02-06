using System;

namespace CommandPattern

{
    /// <summary>
    /// The 'Receiver' class
    /// </summary>
    class Calculator
    {
        private int _result = 0;

        public void Operation(char @operator, int operand)
        {
            switch (@operator)
            {
                case '+':
                    _result += operand;
                    break;

                case '-':
                    _result -= operand;
                    break;

                case '*':
                    _result *= operand;
                    break;

                case '/':
                    _result /= operand;
                    break;

            }
            Console.WriteLine($"Current value = {_result,3} (following { @operator} {operand})");
        }
    }
}
