// See https://aka.ms/new-console-template for more information


using System;

/*
// 인스턴스 매서드 생성과 사용1
class Program
{
    class Test
    {
        public int Power(int x)
        {
            return x * x;
        }
    }

    static void Main(string[] args)
    {
        Test test = new Test();     // 
        Console.WriteLine(test.Power(10));
        Console.WriteLine(test.Power(20));
    }
}
*/


/*
// 인스턴스 매서드 생성과 사용2

class Program
{
    class Test
    {
        public int Multi(int x, int y)
        {
            return x * y;
        }
    }

    static void Main(string[] args)
    {
        Test test = new Test();
        Console.WriteLine(test.Multi(52, 273));
        Console.WriteLine(test.Multi(103, 32));

    }
}

*/

/*
// 인스턴스 메서드 생성과 사용3
class Program
{
    class Test
    {
        public void Print() // 아무것도 반환하지 않는 void
        {
            Console.WriteLine("Print()메서드가 호출되었습니다.");  // 프린트문이 출력되긴하지만 값이 반환되지는 않는다.
        }

        static void Main(string[] args)
        {
            Test test = new Test();
            test.Print();
            test.Print();
            test.Print();

        }
    }


}
*/

/*
// 기본 예제 6-2 매개변수와 반환1
class Program
{
    class Test
    {
        public int Sum(int min, int max)
        {
            int output = 0;
            for (int i = min; i <= max; i++)
            {
                output += i;
            }
            return output;
        }

        static void Main(string[] args)
        {
            Test test = new Test();
            Console.WriteLine(test.Sum(1, 100));
        }
    }
}
*/


/*
// 기본 예제 6-3 매개변수와 반환
class Program
{
    class Test
    {
        public int Multiply(int min, int max)
        {
            int output = 1;
            for (int i = min; i <= max; i++)
            {
                output *= i;
            }
            return output;
        }
    }

    static void Main(string[] args)
    {
        Test test = new Test();
        Console.WriteLine(test.Multiply(1, 10));
    }
}
*/
/*
// 기본 예제 6-4 클래스 메서드 생성과 사용
class Program
{
    class MyMath
    {
        public static int Abs(int input)
        {
            if (input < 0)
            {
                return -input;
            }
            else
            {
                return input;
            }
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine(MyMath.Abs(52));
        Console.WriteLine(MyMath.Abs(-273));
    }

}
*/

/*
// 기본 예제 6-5 메서드 오버로딩 // 오버로딩 = 같은 이름의 함수를 여러개 만드는 것 
class Program
{
    class Mymath
    {
        public static int Abs(int input)
        {
            if (input < 0) { return -input; }
            else { return input; }
        }
        public static double Abs(double input)
        {
            if (input < 0) { return -input; }
            else { return input; }
        }

        public static long Abs(long input)
        {
            if (input < 0) { return -input; }
            else { return input; }
        }

        static void Main(string[] args)
        {
            // int
            Console.WriteLine(Mymath.Abs(52));
            Console.WriteLine(Mymath.Abs(-273));

            // double
            Console.WriteLine(Mymath.Abs(52.273));
            Console.WriteLine(Mymath.Abs(-273.235));


            // long
            Console.WriteLine(Mymath.Abs(52));  // 이거 고치셈
            Console.WriteLine(Mymath.Abs(-273));
        }
    }
}
*/