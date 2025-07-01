using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__series
{
    public class BasicArithmeticOperation
    {
        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiply(int num1, int num2)
        {
            int answer = num1 * num2;
            return answer;
        }

        public float Divide(float num1, float num2)
        {
            float answer = num1 / num2;
            return answer;
        }
    }
}
