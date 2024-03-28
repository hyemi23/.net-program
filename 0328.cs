// See https://aka.ms/new-console-template for more information


/*
// 기본예제 5-1 Random 클래스를 사용한 임의의 정수 생성

Random random = new Random();   // 객체 인스턴스 생성
Console.WriteLine(random.Next(10, 100)); // 10부터 99까지의 난수 생성
Console.WriteLine(random.Next(10, 100));
Console.WriteLine(random.Next(10, 100));
*/

/*
// 기본 예제 5-2 Random 클래스를 사용한 임의의 실수 생성
Random random = new Random();
Console.WriteLine(random.NextDouble());
Console.WriteLine(random.NextDouble());
Console.WriteLine(random.NextDouble());
*/


/*
// 기본 예제 5-3 리스트 요소 추가

// 변수 선언
List<int> list = new List<int>(); 

// 리스트 요소 추가
list.Add(52);
list.Add(273);
list.Add(32);
list.Add(64);

// 반복 수행
foreach (var item in list)
{
    Console.WriteLine("Count: " + list.Count + "\titem: " + item);
}
*/

/*
// 기본 예제 5-4 리스트 오소 제거

// 변수 선언
List<int> list = new List<int>() { 52, 273, 32, 64 };

// 반복 수행
list.Remove(52);

foreach (var item in list)
{
    Console.WriteLine("Count: " + list.Count + "\titem: " + item);
}
*/

/*
// 기본 예제 5-5 Math 클래스 활용
Console.WriteLine(Math.Abs(-52273));
Console.WriteLine(Math.Ceiling(52.273));
Console.WriteLine(Math.Floor(52.273));  // 지정된 숫자보다 작거나 같은
Console.WriteLine(Math.Max(52, 273));
Console.WriteLine(Math.Min(52, 273));
Console.WriteLine(Math.Round(52.273));
*/

/*
// 기본 예제 5-6 인스턴스 변수 생성과 사용
class Program
{
    class Product  // 클래스 생성
    {
        public string name;
        public int price;
    }

    static void Main(string[] args)
    {
        Product product = new Product(); // 클래스 불러오기

        product.name = "감자";
        product.price = 2000;

        Console.WriteLine(product.name + " : " + product.price + "원");
    }
}
*/


// 기본 예제 5-7 클래스 변수 생성과 사용
class Program
{
    class MyMath
    {
        public static double PI = 3.141592; // static :  아래 객체 인스턴스 생성하는 한줄을 생성하지 않아도 됨.
    }

    static void Main(string[] args)
    {
        // MyMath mymath = new MyMath(); // 위 클래스의 static 사용으로 이 줄 생략.
        Console.WriteLine(MyMath.PI);
    }
}