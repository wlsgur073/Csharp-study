﻿using System;

namespace StudentList
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("학생 숫자를 입력하세요.");
            int studentCount = int.Parse(Console.ReadLine());

            int[] ages = new int[studentCount];
            string[] names = new string[studentCount];
            double[] heights = new double[studentCount];

            Console.WriteLine("몇 번째 학생의 정보를 추가할까요.");
            int studentNumber = int.Parse(Console.ReadLine());

            if (studentNumber >= 0 && studentNumber <= studentCount -1)
            {
                Console.WriteLine("나이를 입력하세요.");
                ages[studentNumber] = int.Parse(Console.ReadLine());

                Console.WriteLine("이름을 입력하세요.");
                names[studentNumber] = Console.ReadLine();

                Console.WriteLine("키를 입력하세요.");
                heights[studentNumber] = double.Parse(Console.ReadLine());

                Console.WriteLine(studentNumber + "번째 학생");
                Console.WriteLine("이름: " + names[studentNumber]);
                Console.WriteLine("나이: " + ages[studentNumber]);
                Console.WriteLine("키: " + heights[studentNumber]);
            }
            else
            {
                Console.Write("0에서 ");
                Console.Write(studentCount - 1);
                Console.WriteLine("사이의 숫자를 입력하세요.");
            }
        }
    }
}
