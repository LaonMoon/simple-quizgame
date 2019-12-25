using System;

namespace 노래_가사_퀴즈_다이얼_응용_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("'서른 즈음에'와 '나의 노래' 중 하나를 입력해 주세요.");
            string userinputtitle = Console.ReadLine();
            if (userinputtitle == "서른 즈음에")
            {
                Console.WriteLine("첫 가사를 입력해 주세요.");
                string userinput = Console.ReadLine();
                while (!(userinput == "점점 더 멀어져 간다"))
                {
                    Console.WriteLine("틀렸습니다. 다시 입력해 볼까요?");
                    userinput = Console.ReadLine();
                }
                if (userinput == "점점 더 멀어져 간다")
                {
                    Console.WriteLine("맞았습니다. 김광석 씨의 팬이군요?");
                }
            }
                if (userinputtitle == "나의 노래")
                {
                    Console.WriteLine("첫 가사를 입력해 주세요.");
                    string userinput = Console.ReadLine();
                    while (!(userinput == "자그맣고 메마른 씨앗 속에서"))
                    {
                        Console.WriteLine("틀렸습니다. 다시 입력해 볼까요?");
                        userinput = Console.ReadLine();
                    }
                    if (userinput == "자그맣고 메마른 씨앗 속에서")
                    {
                        Console.WriteLine("맞았습니다. 김광석 씨의 팬이군요?");
                    }
                }
            }
        }
    }

