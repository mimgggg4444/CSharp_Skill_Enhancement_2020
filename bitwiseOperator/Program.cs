using System;

namespace bitwiseOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int op1 = 12;
            int op2 = 9;

            int andResult1 = op1 & op2;
            Console.WriteLine(andResult1);

            int orResult2 = op1 | op2;
            int xorResult3 = op1 ^ op2;
            int notResult4 = ~op1;

            //bitShiftOperator
            int leftShiftResult1 = op1 << 1;
            int leftShiftResult2 = op2 << 2;

            int rightShiftReuslt1 = op1 >> 3;
            int rightShiftReuslt2 = op1 >> 4;
            Console.WriteLine(rightShiftReuslt2);

            //assignmentOperator

            int num1 = 10;
            num1 /= 2;
            num1 += 14;
            num1 *= 2;
            num1 -= 20;

            num1 <<= 2;
            num1 >>= 3;
            Console.WriteLine(num1);

        }
    }
}
