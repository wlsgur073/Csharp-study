﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] passCode = { 6, 2, 1, 9, 4, 7 };
            int[] userInput = new int[6];

            while (index <=5)
            {
                int index = 0;
                Console.Write(index + 1);
                Console.WriteLine("번째 숫자를 입력하세요.");
                userInput[index] = int.Parse(Console.ReadLine());
                index = index + 1;

                if (userInput[0] == passCode[0] && userInput[1] == passCode[1] && userInput[2] == passCode[2] && userInput[3] == passCode[3] && userInput[4] == passCode[4] && userInput[5] == passCode[5])
                {
                    Console.WriteLine("문이 열렸습니다.");
                    break;
                }
            }
        }
    }
}
