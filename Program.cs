using Microsoft.VisualBasic;
using System;

//month8 day2;new branch
namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            Random r1 = new Random();

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("==>" + r1.Next(0, 100));
            }
            
            //2
            //int num = int.Parse(Console.ReadLine());
            //bool ist = ((num - 1) & num) == 0;
            //Console.WriteLine("==>" + ist);

            //test1();
            //stu1.ShowPeopleInfo();
            //for (int i = 0; i < 10; i++)
            //{
            //    int x = GetNum();
            //    Console.WriteLine(x);
            //}

            //PI getpi1 = new PI();
            //getpi1.frist();
            //getpi1.GetPIBuyRange(10);

            //test2();

            //年份日期
            //int year = int.Parse(Console.ReadLine());
            //int days = int.Parse(Console.ReadLine());
            //Console.WriteLine("==>" + year + days);
            //Year y1 = new Year();
            //y1.GetDate(year, days);

            //排序
            //Sort s1 = new Sort();
            //s1.test();

            //qu
            Question question = new Question();
            //question.q2();
            //question.q3();
            //question.q4();
            //question.q8(1,3);
            //question.q7();

        }
        static int GetNum()
        {
            Random random = new Random();
            return random.Next(1, 10);
        }
        static void test1()
        {
            Console.WriteLine("Hello World!");
            People people1 = new People("yh", 22);
            people1.ShowPeopleInfo();

            Student stu1 = new Student("yh", 22, 2);
            stu1.ShowInfo();
        }

        static void test2()
        {
            Console.WriteLine("this is test 2==!");
            People pt1 = new People("yh11", 21);
            Student st1 = new Student("yh22", 21,1);
            ShowInfTest(pt1);
            ShowInfTest(st1);
            st1.ShowPeopleInfo(true);
        }

        static void GetCircularPI(double range)
        {

        }

        public static void ShowInfTest(People p1)
        {
            p1.ShowPeopleInfo();
        }
    }

    public class Question
    {
        
        public void q2()
        {
            bool isN;
            int num = 0;
            for(int i = 101; i < 200; i++)
            {
                isN = true;
                for(int j = 2; j < Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isN = false;
                        //continue;
                    }
                }
                if (isN)
                {
                    num++;
                    Console.WriteLine("==>" + i);
                }
            }
            Console.WriteLine("num==>" + num);
        }

        public void q3()
        {
            for(int i = 101; i < 1000; i++)
            {
                int a1, a2, a3;
                a1 = i % 10;
                a2 = i % 100 / 10;
                a3 = i / 100;
                if (a1 * a1 * a1 + a2 * a2 * a2 + a3 * a3 * a3 == i)
                {
                    Console.WriteLine("==>" + i);
                }
            }
        }

        public void q4()
        {
            int n = int.Parse(Console.ReadLine());
            int k = 2;
            Console.WriteLine("==>"+n);
            while (k <= n)
            {
                if (k == n)
                {
                    Console.WriteLine(n); break;
                }
                else if (n % k == 0)
                {
                    Console.Write(k + "*");
                    n = n / k;
                }
                else k++;
            }
        }

        public void q7()
        {
            string str1 = Console.ReadLine();
            int num = 0;
            int charnum = 0;
            int other = 0;
            int blank = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                Console.WriteLine("==>" + str1[i]);
                if (str1[i] >= 'a' && str1[i] <= 'z')
                {
                    charnum++;
                }else if(str1[i] >= '0' && str1[i] <= '9')
                {
                    num++;
                }else if(str1[i]==' ')
                {
                    blank++;
                }
                else
                {
                    other++;
                }
            }
            Console.WriteLine("==>"+num+charnum+blank+other);
        }

        public void q8(long a,int n)
        {
            long b = 0, sum = 0;
            for(int i = 0; i < n; i++)
            {
                b += a;
                sum += b;
                a *= 10;
            }
            Console.WriteLine("==>"+sum);
        }
    }



    public class Year
    {
        int[] array1 = new int[] { 1, 2, 3 };
        int[,] array2 = new int[2,12] { {31,28,31,30,31,30,31,31,30,31,30,31},
            {31,29,31,30,31,30,31,31,30,31,30,31} };

        public void GetDate(int year,int days)
        {
            int tempd = days;
            int isLeap = 0;
            isLeap = IsLeapYaer(year) ? 1 : 0;
            for(int i = 0; i < 12; i++)
            {

                if (tempd - array2[isLeap, i] > 0)
                {
                    tempd -= array2[isLeap, i];
                }
                else
                {
                    int moth = i + 1;
                    Console.WriteLine(year+"年是否为闰年"+isLeap+"==>第"+days + "天是" + moth + "月" + tempd + "日");
                    break;
                }
            }
        }

        public bool IsLeapYaer(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
        }
    }

    public class Sort
    {
        int[] array1 = new int[] { 8, 5, 2, 9, 2, 3, 2, 4, 10, 7 };
        int[] array2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public void test()
        {
            //Console.WriteLine(MaopaoSort(array1, true));
            //int[] temp = MaopaoSort(array1, false);
            //int[] temp = chooseSort(array1);
            int[] temp = InsertionSort(array1);
            foreach(int tempn in temp)
            {
                Console.WriteLine(tempn);
            }
        }

        //插入算法
        int[] InsertionSort(int[] array)
        {
            for(int i = 1; i < array.Length; i++)
            {
                for(int j = i-1; j>=0; j--)
                {
                    if (array[j] > array[j+1])
                    {
                        int tempN = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = tempN;
                    }
                }
            }
            return array;
        }

        //选择
        int[] chooseSort(int[] array)
        {
            int idex;
            for(int i = 0; i < array.Length; i++)
            {
                idex = i;
                for(int j = i+1; j < array.Length; j++)
                {
                    if (array[idex] > array[j])
                    {
                        idex = j;
                    }
                }
                int temp = array[i];
                array[i] = array[idex];
                array[idex] = temp;
            }
            return array;
        }

        //maopa
        int[] MaopaoSort(int[] arry,bool isAO)//Ascending order升序,Descending order降序
        {
            if (isAO)
            {
                for (int i = 0; i < arry.Length; i++)
                {
                    for (int j = i + 1; j < arry.Length; j++)
                    {
                        if (arry[i] > arry[j])
                        {
                            int tempN = arry[i];
                            arry[i] = arry[j];
                            arry[j] = tempN;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < arry.Length; i++)
                {
                    for (int j = i + 1; j < arry.Length; j++)
                    {
                        if (arry[i] < arry[j])
                        {
                            int tempN = arry[i];
                            arry[i] = arry[j];
                            arry[j] = tempN;
                        }
                    }
                }
            }

            return arry;
        }


    }

    public class PI
    {
        //目前计算pi值效率最快的算法
        //10次以内的收敛可以使精度超过double类型的精度

        double a = 1.0;
        double b = 1.0 / Math.Sqrt(2);
        double t = 1.0 / 4;
        double p = 1.0;

        double a_temp = 0;
        double b_temp = 0;
        double t_temp = 0;
        double p_temp = 0;

        public void frist()
        {
            Console.WriteLine("a " + a + " b " + b + " t " + t + " p " + p);
            Console.WriteLine("1111++>" + GetPI(a, b, t, p));
        }
        void ChangeNum(double a,double b,double t,double p)
        {
            Console.WriteLine("a:" + a + "\nb:" + b + "\nt:" + t + "\np：" + p);
            a_temp = (a + b) / 2;
            b_temp = (Math.Sqrt(a * b));
            t_temp = t - p * Math.Pow((a - a_temp), 2);
            p_temp = 2 * p;
            Console.WriteLine("a_" + a_temp + "\nb_" + b_temp + "\nt_" + t_temp + "\np_" + p_temp);
            this.a = a_temp;
            this.b = b_temp;
            this.t = t_temp;
            this.p = p_temp;
            //double pi = Math.Pow((a + b), 2) / (4 * t);
            //Console.WriteLine("PI===>" +GetPI(a,b,t,p));
        }
        double GetPI(double a, double b, double t, double p)
        {
            //Console.WriteLine("PI===>" + GetPI(a, b, t, p));
            return Math.Pow((a + b), 2) / (4 * t);
        }
        public void GetPIBuyRange(int range)
        {
            //Console.WriteLine("PI===>" + GetPI(a, b, t, p));
            for (int i = 0; i < range; i++)
            {
                ChangeNum(a, b, t, p);
                Console.WriteLine(i+"PI===>" + GetPI(a, b, t, p));
            }
        }
    }

    public class People
    {
        string name = "unknow";
        int age = 1;
        public People(string name,int age)
        {
            this.name = name;
            this.age = age;
        }

        virtual
        public void ShowPeopleInfo()
        {
            Console.WriteLine("name:"+name+"age:"+age);
        }
    }

}
