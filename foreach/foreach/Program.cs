using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace @foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mainmenu();
            Calendar();
        }
        private static void EndOrRes()
        {
            try
            {
                Console.WriteLine("다른 달(월)을 보시겠습니까? Y or N");
                string o = Console.ReadLine();
                Console.Write('>');
                if (o == "y" || o == "Y")
                {
                    Mainmenu();
                    Calendar();
                }
                else if (o == "n" || o == "N")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("다시 입력해 주세요.");
                    EndOrRes();
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
        }
        private static void Mainmenu()
        {
            Console.WriteLine("2024년 달력입니다. 원하는 달을 입력하시면 달력이 출력됩니다.");
            Console.Write('>');
        }
        private static void Calendar()
        {
            try
            {                
                string cal = Console.ReadLine();
                Console.WriteLine();

                int Cal = int.Parse(cal);

                switch (Cal)
                {
                    case 1:
                        Calendar01();
                        EndOrRes();
                        break;
                    case 2:
                        Calendar02();
                        EndOrRes();
                        break;
                    case 3:
                        Calendar03();
                        EndOrRes();
                        break;
                    case 4:
                        Calendar04();
                        EndOrRes();
                        break;
                    case 5:
                        Calendar05();
                        EndOrRes();
                        break;
                    case 6:
                        Calendar06();
                        EndOrRes();
                        break;
                    case 7:
                        Calendar07();
                        EndOrRes();
                        break;
                    case 8:
                        Calendar08();
                        EndOrRes();
                        break;
                    case 9:
                        Calendar09();
                        EndOrRes();
                        break;
                    case 10:
                        Calendar10();
                        EndOrRes();
                        break;
                    case 11:
                        Calendar11();
                        EndOrRes();
                        break;
                    case 12:
                        Calendar12();
                        EndOrRes();
                        break;
                    default:
                        Console.WriteLine("정확한 월로 다시 입력해주세요.");
                        Mainmenu();
                        Calendar();
                        break;
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("1~ 12까지의 [숫자만] 입력해주세요!!");
                Console.WriteLine();
                Console.Error.WriteLine("오류:" + ex.Message);
                Console.WriteLine();
                Console.WriteLine("정확한 월로 다시 입력해주세요.");
                Console.WriteLine();
                Mainmenu();
                Calendar();

            }
        }

        private static void Calendar01()
        {
            Console.WriteLine("2024년 1월");
            string[] week = { "일 ", "월 ", "화 ", "수 ", "목 ", "금 ", "토" };
            
            foreach (string i in week)
            {
                if (i == "일 ")
                {
                    // 콘솔에서 일요일 부분을 빨간색으로 바꿔줌
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == "토")
                {
                    // 파란색으로
                    Console.ForegroundColor = ConsoleColor.Blue;
                }

                Console.Write(i);
                Console.ResetColor();
            }
            Console.WriteLine();

            string[] a1 = new string[7];
            a1[0] = "  ";
            a1[1] = " 1";
            a1[2] = " 2";
            a1[3] = " 3";
            a1[4] = " 4";
            a1[5] = " 5";
            a1[6] = " 6";
            foreach (string i in a1)
            {
                if (i == " 1")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                if (i == " 6")
                {
                    // 파란색
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            string[] a2 = new string[7];
            a2[0] = " 7";
            a2[1] = " 8";
            a2[2] = " 9";
            a2[3] = "10";
            a2[4] = "11";
            a2[5] = "12";
            a2[6] = "13";
            foreach (string i in a2)
            {
                if (i == " 7")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                if (i == "13")
                {
                    // 파란색
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            int[] a3 = new int[7];
            a3[0] = 14;
            a3[1] = 15;
            a3[2] = 16;
            a3[3] = 17;
            a3[4] = 18;
            a3[5] = 19;
            a3[6] = 20;
            foreach (int i in a3)
            {
                if (i == 14)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                if (i == 20)
                {
                    // 파란색
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            int[] a4 = new int[7];
            a4[0] = 21;
            a4[1] = 22;
            a4[2] = 23;
            a4[3] = 24;
            a4[4] = 25;
            a4[5] = 26;
            a4[6] = 27;
            foreach (int i in a4)
            {
                if (i == 21)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                if (i == 27)
                {
                    // 파란색
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            string[] a5 = new string[7];
            a5[0] = "28";
            a5[1] = "29";
            a5[2] = "30";
            a5[3] = "31";
            a5[4] = "  ";
            a5[5] = "  ";
            a5[6] = "  ";
            foreach (string i in a5)
            {
                if (i == "28")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }              
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write ("공휴일 : ");
            Console.WriteLine("1/1 신정");
            Console.WriteLine();
        }

        private static void Calendar02()
        {
            Console.WriteLine("2024년 2월");
            string[] week = { "일 ", "월 ", "화 ", "수 ", "목 ", "금 ", "토" };

            foreach (string i in week)
            {
                if (i == "일 ")
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == "토")
                {
                    // 파란색
                    Console.ForegroundColor = ConsoleColor.Blue;
                }

                Console.Write(i);
                Console.ResetColor();
            }
            Console.WriteLine();

            string[] a1 = new string[7];
            a1[0] = "  ";
            a1[1] = "  ";
            a1[2] = "  ";
            a1[3] = "  ";
            a1[4] = " 1";
            a1[5] = " 2";
            a1[6] = " 3";
            foreach (string i in a1)
            {
                if (i == "")
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == " 3")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            string[] a2 = new string[7];
            a2[0] = " 4";
            a2[1] = " 5";
            a2[2] = " 6";
            a2[3] = " 7";
            a2[4] = " 8";
            a2[5] = " 9";
            a2[6] = "10";
            foreach (string i in a2)
            {
                if (i == " 4" || i == " 9" || i == "10")
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            int[] a3 = new int[7];
            a3[0] = 11;
            a3[1] = 12;
            a3[2] = 13;
            a3[3] = 14;
            a3[4] = 15;
            a3[5] = 16;
            a3[6] = 17;
            foreach (int i in a3)
            {
                if (i == 12 || i == 11)
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == 17)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            int[] a4 = new int[7];
            a4[0] = 18;
            a4[1] = 19;
            a4[2] = 20;
            a4[3] = 21;
            a4[4] = 22;
            a4[5] = 23;
            a4[6] = 24;
            foreach (int i in a4)
            {
                if (i == 18)
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == 24)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            string[] a5 = new string[7];
            a5[0] = "25";
            a5[1] = "26";
            a5[2] = "27";
            a5[3] = "28";
            a5[4] = "29";
            a5[5] = "  ";
            a5[6] = "  ";
            foreach (string i in a5)
            {
                if (i == "25")
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == "")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("공휴일 : ");
            Console.WriteLine("2/10 설날, 2/9 ~ 2/12 설 연휴");
            Console.WriteLine();
        }

        private static void Calendar03()
        {
            Console.WriteLine("2024년 3월");
            string[] week = { "일 ", "월 ", "화 ", "수 ", "목 ", "금 ", "토" };

            foreach (string i in week)
            {
                if (i == "일 ")
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == "토")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i);
                Console.ResetColor();
            }
            Console.WriteLine();

            string[] a1 = new string[7];
            a1[0] = "  ";
            a1[1] = "  ";
            a1[2] = "  ";
            a1[3] = "  ";
            a1[4] = "  ";
            a1[5] = " 1";
            a1[6] = " 2";
            foreach (string i in a1)
            {
                if (i == " 1")
                {                   
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == " 2")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            string[] a2 = new string[7];
            a2[0] = " 3";
            a2[1] = " 4";
            a2[2] = " 5";
            a2[3] = " 6";
            a2[4] = " 7";
            a2[5] = " 8";
            a2[6] = " 9";
            foreach (string i in a2)
            {
                if (i == " 3")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == " 9")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
                Console.WriteLine();

            int[] a3 = new int[7];
            a3[0] = 10;
            a3[1] = 11;
            a3[2] = 12;
            a3[3] = 13;
            a3[4] = 14;
            a3[5] = 15;
            a3[6] = 16;
            foreach (int i in a3)
            {
                if (i == 10)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == 16)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            int[] a4 = new int[7];
            a4[0] = 17;
            a4[1] = 18;
            a4[2] = 19;
            a4[3] = 20;
            a4[4] = 21;
            a4[5] = 22;
            a4[6] = 23;
            foreach (int i in a4)
            {
                if (i == 17)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == 23)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            string[] a5 = new string[7];
            a5[0] = "24";
            a5[1] = "25";
            a5[2] = "26";
            a5[3] = "27";
            a5[4] = "28";
            a5[5] = "29";
            a5[6] = "30";
            foreach (string i in a5)
            {
                if (i == "24")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == "30")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            string[] a6 = new string[7];
            a6[0] = "31";
            a6[1] = "  ";
            a6[2] = "  ";
            a6[3] = "  ";
            a6[4] = "  ";
            a6[5] = "  ";
            a6[6] = "  ";
            foreach (string i in a6)
            {
                if (i == "31")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == "")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("공휴일 : ");
            Console.WriteLine("3/1 삼일절");
            Console.WriteLine();
        }

        private static void Calendar04()
        {
            Console.WriteLine("2024년 4월");
            string[] week = { "일 ", "월 ", "화 ", "수 ", "목 ", "금 ", "토" };

            foreach (string i in week)
            {
                if (i == "일 ")
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == "토")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i);
                Console.ResetColor();
            }
            Console.WriteLine();

            string[] a1 = new string[7];
            a1[0] = "  ";
            a1[1] = " 1";
            a1[2] = " 2";
            a1[3] = " 3";
            a1[4] = " 4";
            a1[5] = " 5";
            a1[6] = " 6";
            foreach (string i in a1)
            {
                if (i == "")
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == " 6")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            string[] a2 = new string[7];
            a2[0] = " 7";
            a2[1] = " 8";
            a2[2] = " 9";
            a2[3] = "10";
            a2[4] = "11";
            a2[5] = "12";
            a2[6] = "13";
            foreach (string i in a2)
            {
                if (i == " 7" || i == "10")
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == "13")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            int[] a3 = new int[7];
            a3[0] = 14;
            a3[1] = 15;
            a3[2] = 16;
            a3[3] = 17;
            a3[4] = 18;
            a3[5] = 19;
            a3[6] = 20;
            foreach (int i in a3)
            {
                if (i == 14)
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == 20)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            int[] a4 = new int[7];
            a4[0] = 21;
            a4[1] = 22;
            a4[2] = 23;
            a4[3] = 24;
            a4[4] = 25;
            a4[5] = 26;
            a4[6] = 27;
            foreach (int i in a4)
            {
                if (i == 21)
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == 27)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            string[] a5 = new string[7];
            a5[0] = "28";
            a5[1] = "29";
            a5[2] = "30";
            a5[3] = "  ";
            a5[4] = "  ";
            a5[5] = "  ";
            a5[6] = "  ";
            foreach (string i in a5)
            {
                if (i == "28")
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == "")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("공휴일 : ");
            Console.WriteLine("4/10 22대 국회의원 선거");
            Console.WriteLine();
        }

        private static void Calendar05()
        {
            Console.WriteLine("2024년 5월");
            string[] week = { "일 ", "월 ", "화 ", "수 ", "목 ", "금 ", "토" };

            foreach (string i in week)
            {
                if (i == "일 ")
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == "토")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i);
                Console.ResetColor();
            }
            Console.WriteLine();

            string[] a1 = new string[7];
            a1[0] = "  ";
            a1[1] = "  ";
            a1[2] = "  ";
            a1[3] = " 1";
            a1[4] = " 2";
            a1[5] = " 3";
            a1[6] = " 4";
            foreach (string i in a1)
            {
                if (i == "")
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == " 4")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            string[] a2 = new string[7];
            a2[0] = " 5";
            a2[1] = " 6";
            a2[2] = " 7";
            a2[3] = " 8";
            a2[4] = " 9";
            a2[5] = "10";
            a2[6] = "11";
            foreach (string i in a2)
            {
                if (i == " 5" || i == " 6")
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == "11")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            int[] a3 = new int[7];
            a3[0] = 12;
            a3[1] = 13;
            a3[2] = 14;
            a3[3] = 15;
            a3[4] = 16;
            a3[5] = 17;
            a3[6] = 18;
            foreach (int i in a3)
            {
                if (i == 12 || i == 15)
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == 18)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            int[] a4 = new int[7];
            a4[0] = 19;
            a4[1] = 20;
            a4[2] = 21;
            a4[3] = 22;
            a4[4] = 23;
            a4[5] = 24;
            a4[6] = 25;
            foreach (int i in a4)
            {
                if (i == 19)
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == 25)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            string[] a5 = new string[7];
            a5[0] = "26";
            a5[1] = "27";
            a5[2] = "28";
            a5[3] = "29";
            a5[4] = "30";
            a5[5] = "31";
            a5[6] = "  ";
            foreach (string i in a5)
            {
                if (i == "26")
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == " ")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("공휴일 : ");
            Console.WriteLine("5/6 어린이날 대체 휴일, 5/15 부처님 오신날");
            Console.WriteLine();
        }

        private static void Calendar06()
        {
            Console.WriteLine("2024년 6월");
            string[] week = { "일 ", "월 ", "화 ", "수 ", "목 ", "금 ", "토" };

            foreach (string i in week)
            {
                if (i == "일 ")
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == "토")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i);
                Console.ResetColor();
            }
            Console.WriteLine();

            string[] a1 = new string[7];
            a1[0] = "  ";
            a1[1] = "  ";
            a1[2] = "  ";
            a1[3] = "  ";
            a1[4] = "  ";
            a1[5] = "  ";
            a1[6] = " 1";
            foreach (string i in a1)
            {
                if (i == "")
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == " 1")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            string[] a2 = new string[7];
            a2[0] = " 2";
            a2[1] = " 3";
            a2[2] = " 4";
            a2[3] = " 5";
            a2[4] = " 6";
            a2[5] = " 7";
            a2[6] = " 8";
            foreach (string i in a2)
            {
                if (i == " 2" || i == " 6")
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == " 8")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            string[] a3 = new string[7];
            a3[0] = " 9";
            a3[1] = "10";
            a3[2] = "11";
            a3[3] = "12";
            a3[4] = "13";
            a3[5] = "14";
            a3[6] = "15";
            foreach (string i in a3)
            {
                if (i == " 9")
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == " 15")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            int[] a4 = new int[7];
            a4[0] = 16;
            a4[1] = 17;
            a4[2] = 18;
            a4[3] = 19;
            a4[4] = 20;
            a4[5] = 21;
            a4[6] = 22;
            foreach (int i in a4)
            {
                if (i == 16)
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == 22)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }               
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            string[] a5 = new string[7];
            a5[0] = "23";
            a5[1] = "24";
            a5[2] = "25";
            a5[3] = "26";
            a5[4] = "27";
            a5[5] = "28";
            a5[6] = "29";
            foreach (string i in a5)
            {
                if (i == "23")
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == "29")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            string[] a6 = new string[7];
            a6[0] = "30";
            a6[1] = "  ";
            a6[2] = "  ";
            a6[3] = "  ";
            a6[4] = "  ";
            a6[5] = "  ";
            a6[6] = "  ";
            foreach (string i in a6)
            {
                if (i == "30")
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == " ")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("공휴일 : ");
            Console.WriteLine("6/6 현충일");
            Console.WriteLine();
        }

        private static void Calendar07()
        {
            Console.WriteLine("2024년 7월");
            string[] week = { "일 ", "월 ", "화 ", "수 ", "목 ", "금 ", "토" };

            foreach (string i in week)
            {
                if (i == "일 ")
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == "토")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i);
                Console.ResetColor();
            }
            Console.WriteLine();

            string[] a1 = new string[7];
            a1[0] = "  ";
            a1[1] = " 1";
            a1[2] = " 2";
            a1[3] = " 3";
            a1[4] = " 4";
            a1[5] = " 5";
            a1[6] = " 6";
            foreach (string i in a1)
            {
                if (i == "")
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == " 6")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            string[] a2 = new string[7];
            a2[0] = " 7";
            a2[1] = " 8";
            a2[2] = " 9";
            a2[3] = "10";
            a2[4] = "11";
            a2[5] = "12";
            a2[6] = "13";
            foreach (string i in a2)
            {
                if (i == " 7")
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == "13")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            string[] a3 = new string[7];
            a3[0] = "14";
            a3[1] = "15";
            a3[2] = "16";
            a3[3] = "17";
            a3[4] = "18";
            a3[5] = "19";
            a3[6] = "20";
            foreach (string i in a3)
            {
                if (i == "14")
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == "20")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            int[] a4 = new int[7];
            a4[0] = 21;
            a4[1] = 22;
            a4[2] = 23;
            a4[3] = 24;
            a4[4] = 25;
            a4[5] = 26;
            a4[6] = 27;
            foreach (int i in a4)
            {
                if (i == 21)
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == 27)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            string[] a5 = new string[7];
            a5[0] = "28";
            a5[1] = "29";
            a5[2] = "30";
            a5[3] = "31";
            a5[4] = "  ";
            a5[5] = "  ";
            a5[6] = "  ";
            foreach (string i in a5)
            {
                if (i == "28")
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == " ")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();

            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("공휴일 : ");
            Console.WriteLine("없음");
            Console.WriteLine();

            //string[] a6 = new string[7];
            //a6[0] = "  ";
            //a6[1] = "  ";
            //a6[2] = "  ";
            //a6[3] = "  ";
            //a6[4] = "  ";
            //a6[5] = "  ";
            //a6[6] = "  ";
            //foreach (string i in a6)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();
        }

        private static void Calendar08()
        {
            Console.WriteLine("2024년 8월");
            string[] week = { "일 ", "월 ", "화 ", "수 ", "목 ", "금 ", "토" };

            foreach (string i in week)
            {
                if (i == "일 ")
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == "토")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i);
                Console.ResetColor();
            }
            Console.WriteLine();

            string[] a1 = new string[7];
            a1[0] = "  ";
            a1[1] = "  ";
            a1[2] = "  ";
            a1[3] = "  ";
            a1[4] = " 1";
            a1[5] = " 2";
            a1[6] = " 3";
            foreach (string i in a1)
            {
                if (i == "")
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == " 3")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            string[] a2 = new string[7];
            a2[0] = " 4";
            a2[1] = " 5";
            a2[2] = " 6";
            a2[3] = " 7";
            a2[4] = " 8";
            a2[5] = " 9";
            a2[6] = "10";
            foreach (string i in a2)
            {
                if (i == " 4")
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == "10")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            string[] a3 = new string[7];
            a3[0] = "11";
            a3[1] = "12";
            a3[2] = "13";
            a3[3] = "14";
            a3[4] = "15";
            a3[5] = "16";
            a3[6] = "17";
            foreach (string i in a3)
            {
                if (i == "11" || i == "15")
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == "17")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            int[] a4 = new int[7];
            a4[0] = 18;
            a4[1] = 19;
            a4[2] = 20;
            a4[3] = 21;
            a4[4] = 22;
            a4[5] = 23;
            a4[6] = 24;
            foreach (int i in a4)
            {
                if (i == 18)
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == 24)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            string[] a5 = new string[7];
            a5[0] = "25";
            a5[1] = "26";
            a5[2] = "27";
            a5[3] = "28";
            a5[4] = "29";
            a5[5] = "30";
            a5[6] = "31";
            foreach (string i in a5)
            {
                if (i == "25")
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == "31")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            string[] a6 = new string[7];
            a6[0] = "  ";
            a6[1] = "  ";
            a6[2] = "  ";
            a6[3] = "  ";
            a6[4] = "  ";
            a6[5] = "  ";
            a6[6] = "  ";
            foreach (string i in a6)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("공휴일 : ");
            Console.WriteLine("8/15 광복절");
            Console.WriteLine();
        }

        private static void Calendar09()
        {
            Console.WriteLine("2024년 9월");
            string[] week = { "일 ", "월 ", "화 ", "수 ", "목 ", "금 ", "토" };

            foreach (string i in week)
            {
                if (i == "일 ")
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == "토")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i);
                Console.ResetColor();
            }
                Console.WriteLine();

            string[] a1 = new string[7];
            a1[0] = " 1";
            a1[1] = " 2";
            a1[2] = " 3";
            a1[3] = " 4";
            a1[4] = " 5";
            a1[5] = " 6";
            a1[6] = " 7";
            foreach (string i in a1)
            {
                if (i == " 1")
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == " 7")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            string[] a2 = new string[7];
            a2[0] = " 8";
            a2[1] = " 9";
            a2[2] = "10";
            a2[3] = "11";
            a2[4] = "12";
            a2[5] = "13";
            a2[6] = "14";
            foreach (string i in a2)
            {
                if (i == " 8")
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == "14")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            string[] a3 = new string[7];
            a3[0] = "15";
            a3[1] = "16";
            a3[2] = "17";
            a3[3] = "18";
            a3[4] = "19";
            a3[5] = "20";
            a3[6] = "21";
            foreach (string i in a3)
            {
                if (i == "15" || i == "16" || i == "17" || i == "18")
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == "21")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            int[] a4 = new int[7];
            a4[0] = 22;
            a4[1] = 23;
            a4[2] = 24;
            a4[3] = 25;
            a4[4] = 26;
            a4[5] = 27;
            a4[6] = 28;
            foreach (int i in a4)
            {
                if (i == 22)
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == 28)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            string[] a5 = new string[7];
            a5[0] = "29";
            a5[1] = "30";
            a5[2] = "  ";
            a5[3] = "  ";
            a5[4] = "  ";
            a5[5] = "  ";
            a5[6] = "  ";
            foreach (string i in a5)
            {
                if (i == "29")
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == "")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            string[] a6 = new string[7];
            a6[0] = "  ";
            a6[1] = "  ";
            a6[2] = "  ";
            a6[3] = "  ";
            a6[4] = "  ";
            a6[5] = "  ";
            a6[6] = "  ";
            foreach (string i in a6)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("공휴일 : ");
            Console.WriteLine("9/16 ~ 9/18 추석");
            Console.WriteLine();
        }

        private static void Calendar10()
        {
            Console.WriteLine("2024년 10월");
            string[] week = { "일 ", "월 ", "화 ", "수 ", "목 ", "금 ", "토" };

            foreach (string i in week)
            {
                    if (i == "일 ")
                    {   // 빨간색                 
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    if (i == "토")
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    Console.Write(i);
                    Console.ResetColor();
                }

            Console.WriteLine();

            string[] a1 = new string[7];
            a1[0] = "  ";
            a1[1] = "  ";
            a1[2] = " 1";
            a1[3] = " 2";
            a1[4] = " 3";
            a1[5] = " 4";
            a1[6] = " 5";
            foreach (string i in a1)
            {
                if (i == " 3")
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == " 5")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            string[] a2 = new string[7];
            a2[0] = " 6";
            a2[1] = " 7";
            a2[2] = " 8";
            a2[3] = " 9";
            a2[4] = "10";
            a2[5] = "11";
            a2[6] = "12";
            foreach (string i in a2)
            {
                if (i == " 6" || i == " 9")
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == "12")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            string[] a3 = new string[7];
            a3[0] = "13";
            a3[1] = "14";
            a3[2] = "15";
            a3[3] = "16";
            a3[4] = "17";
            a3[5] = "18";
            a3[6] = "19";
            foreach (string i in a3)
            {
                if (i == "13")
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == "19")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            int[] a4 = new int[7];
            a4[0] = 20;
            a4[1] = 21;
            a4[2] = 22;
            a4[3] = 23;
            a4[4] = 24;
            a4[5] = 25;
            a4[6] = 26;
            foreach (int i in a4)
            {
                if (i == 20)
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == 26)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            string[] a5 = new string[7];
            a5[0] = "27";
            a5[1] = "28";
            a5[2] = "29";
            a5[3] = "30";
            a5[4] = "31";
            a5[5] = "  ";
            a5[6] = "  ";
            foreach (string i in a5)
            {
                if (i == "27")
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == "")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            string[] a6 = new string[7];
            a6[0] = "  ";
            a6[1] = "  ";
            a6[2] = "  ";
            a6[3] = "  ";
            a6[4] = "  ";
            a6[5] = "  ";
            a6[6] = "  ";
            foreach (string i in a6)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("공휴일 : ");
            Console.WriteLine("10/3 개천절, 10/9 한글날");
            Console.WriteLine();
        }

        private static void Calendar11()
        {
            Console.WriteLine("2024년 11월");
            string[] week = { "일 ", "월 ", "화 ", "수 ", "목 ", "금 ", "토" };

            foreach (string i in week)
            {
                if (i == "일 ")
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == "토")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i);
                Console.ResetColor();
            }
            Console.WriteLine();

            string[] a1 = new string[7];
            a1[0] = "  ";
            a1[1] = "  ";
            a1[2] = "  ";
            a1[3] = "  ";
            a1[4] = "  ";
            a1[5] = " 1";
            a1[6] = " 2";
            foreach (string i in a1)
            {
                if (i == "")
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == " 2")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            string[] a2 = new string[7];
            a2[0] = " 3";
            a2[1] = " 4";
            a2[2] = " 5";
            a2[3] = " 6";
            a2[4] = " 7";
            a2[5] = " 8";
            a2[6] = " 9";
            foreach (string i in a2)
            {
                if (i == " 3")
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == " 9")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            string[] a3 = new string[7];
            a3[0] = "10";
            a3[1] = "11";
            a3[2] = "12";
            a3[3] = "13";
            a3[4] = "14";
            a3[5] = "15";
            a3[6] = "16";
            foreach (string i in a3)
            {
                if (i == "10")
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == "16")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            int[] a4 = new int[7];
            a4[0] = 17;
            a4[1] = 18;
            a4[2] = 19;
            a4[3] = 20;
            a4[4] = 21;
            a4[5] = 22;
            a4[6] = 23;
            foreach (int i in a4)
            {
                if (i == 17)
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == 23)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            string[] a5 = new string[7];
            a5[0] = "24";
            a5[1] = "25";
            a5[2] = "26";
            a5[3] = "27";
            a5[4] = "28";
            a5[5] = "29";
            a5[6] = "30";
            foreach (string i in a5)
            {
                if (i == "24")
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == "30")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            string[] a6 = new string[7];
            a6[0] = "  ";
            a6[1] = "  ";
            a6[2] = "  ";
            a6[3] = "  ";
            a6[4] = "  ";
            a6[5] = "  ";
            a6[6] = "  ";
            foreach (string i in a6)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("공휴일 : ");
            Console.WriteLine("없음");
            Console.WriteLine();
        }

        private static void Calendar12()
        {
            Console.WriteLine("2024년 12월");
            string[] week = { "일 ", "월 ", "화 ", "수 ", "목 ", "금 ", "토" };

            foreach (string i in week)
            {
                if (i == "일 ")
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == "토")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i);
                Console.ResetColor();
            }
            Console.WriteLine();

            string[] a1 = new string[7];
            a1[0] = " 1";
            a1[1] = " 2";
            a1[2] = " 3";
            a1[3] = " 4";
            a1[4] = " 5";
            a1[5] = " 6";
            a1[6] = " 7";
            foreach (string i in a1)
            {
                if (i == " 1")
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == " 7")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            string[] a2 = new string[7];
            a2[0] = " 8";
            a2[1] = " 9";
            a2[2] = "10";
            a2[3] = "11";
            a2[4] = "12";
            a2[5] = "13";
            a2[6] = "14";
            foreach (string i in a2)
            {
                if (i == " 8")
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == "14")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            string[] a3 = new string[7];
            a3[0] = "15";
            a3[1] = "16";
            a3[2] = "17";
            a3[3] = "18";
            a3[4] = "19";
            a3[5] = "20";
            a3[6] = "21";
            foreach (string i in a3)
            {
                if (i == "15")
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == "21")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            int[] a4 = new int[7];
            a4[0] = 22;
            a4[1] = 23;
            a4[2] = 24;
            a4[3] = 25;
            a4[4] = 26;
            a4[5] = 27;
            a4[6] = 28;
            foreach (int i in a4)
            {
                if (i == 22 || i == 25)
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == 28)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            string[] a5 = new string[7];
            a5[0] = "29";
            a5[1] = "30";
            a5[2] = "31";
            a5[3] = "  ";
            a5[4] = "  ";
            a5[5] = "  ";
            a5[6] = "  ";
            foreach (string i in a5)
            {
                if (i == "29")
                {   // 빨간색                 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == "")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            string[] a6 = new string[7];
            a6[0] = "  ";
            a6[1] = "  ";
            a6[2] = "  ";
            a6[3] = "  ";
            a6[4] = "  ";
            a6[5] = "  ";
            a6[6] = "  ";
            foreach (string i in a6)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("공휴일 : ");
            Console.WriteLine("12/25 성탄절");
            Console.WriteLine();
        }
    }

}
