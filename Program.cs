// See https://aka.ms/new-console-template for more information


/*
class Program
{
    class Product
    {
        public static int counter = 0;
        public int id;
        public string name;
        public int price;

        public Product(string name, int price)
        {
            Product.counter = counter + 1;
            this.id = counter;
            this.name = name;
            this.price = price;
        }
    }

    static void Main(string[] args)
    {
        Product productA = new Product("감자", 2000);
        Product productB = new Product("고구마", 3000);

        Console.WriteLine(productA.id + ":" + productA.name);
        Console.WriteLine(productB.id + ":" + productB.name);
        Console.WriteLine(Product.counter + "개 생성되었습니다.");
    }
}
*/


/*
// 기본 예제 6-7 소멸자 생성과 사용
class Program
{
    class Product
    {
        public string name;
        public int price;

        public Product(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        ~Product()
        {
            Console.WriteLine(this.name + "의 소멸자 호출");
        }
    }

    static void Main(string[] args)
    {
        Product product = new Product("과자", 1000);
    }
}
*/


// 기본 예제 6-8 일반적인 속성

class Program
{
    class Box
    {
        private int width;
        public int Width
        {
            get { return width;}
            set
            {
                if (value > 0) { width = value; }
                else { Console.WriteLine("너비는 자연수를 입력해주세요"); }
            }
        }

        private int height;
        public int Height
        {
            get { return height; }
            set
            {
                if (value > 0) { height = value; }
                else { Console.WriteLine("높이는 자연수를 입력해주세요"); }
            }
        }

        public Box(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Area()
        {
            return this.width * this.height;
        }

    }

    static void Main(string[] args)
    {
        Box box = new Box(-10, -20);

        box.Width = -200;
        box.Height = -100;
    }
}
