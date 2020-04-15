using System;

namespace MaximumProblem
{
    class Maximum
    {
        private int number1;
        private int number2;
        private int number3;

        public int FindMaximum(int number1, int number2, int number3)
        {
            this.number1 = number1;
            this.number2 = number2;
            this.number3 = number3;

            if (number1 > number2 && number1 > number3)
                return number1;
            else if (number2 > number1 && number2 > number3)
                return number2;
            else
                return number3;
        }
    }
}
