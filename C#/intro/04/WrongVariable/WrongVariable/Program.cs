﻿using System;

namespace WrongVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            int appleCount = 12;
            int pearCount;

            Console.WriteLine(appleCount);
            Console.WriteLine(pearCount); // 변수에 값을 넣지 않고 사용해서 오류!!
            10 = appleCount; // = 왼쪽에는 변수만 올 수 있어서 오류!
        }
    }
}
