﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C#에서도 헬로월드를?!
            Console.WriteLine("Hello World?!");

            //오버플로우 연습
            int a = 2000000000;     // 20억
            int b = 1000000000;     // 10억
            Console.WriteLine(a + b);

            //오버플로우 연습2
            Console.WriteLine((long)a + b);
            //작은 타입이 큰 타입으로 변환되어 30억출력이 가능해짐
            Console.WriteLine(a + (long)b);
            Console.WriteLine((long)a + (long)b);

            //자료형 최소, 최대 값 출력하기
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);

            //sizeof 연산자 연습
            Console.WriteLine("int : " + sizeof(int));
            Console.WriteLine("long : " + sizeof(long));
            Console.WriteLine("float : " + sizeof(float));
            Console.WriteLine("double : " + sizeof(double));
            Console.WriteLine("char : " + sizeof(char));
            Console.WriteLine("bool : " + sizeof(bool));

        }
    }
}
