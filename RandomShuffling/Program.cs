using System;

namespace RandomShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SEED = 0;
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            Console.WriteLine("Before shuffling: ");
            Console.WriteLine($"[{string.Join(", ", numbers)}]");

            Random random = new Random(SEED);

            for(int i = numbers.Length - 1; i > 0; i--)     //뒤에서 앞으로 반복문을 도는 방법(첫번째 숫자는 방문하지 않는다.)
            {
                int j = random.Next(0, i);                  // 0 ~ i 사이의 난수를 생성한다.(당연히 i는 포함이 아님)
                
                int temp = numbers[j];          //
                numbers[j] = numbers[i];        //
                numbers[i] = temp;              //배열 속에서 두 요소 교환하는 방법, 임시 지역변수를 활용한 식이다.
            }

            Console.WriteLine("After shuffling: ");
            Console.WriteLine($"[{string.Join(", ", numbers)}]");

        }
    }
}
