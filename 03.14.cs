// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("Hello, World!");

Console.WriteLine("숫자 입력: ");
int input =int.Parse(Console.ReadLine());


if (input % 2 == 0)
{
    Console.WriteLine("짝수입니다!");
}

if (input % 2 ==1)
{
    Console.WriteLine("홀수입니다!");
}
*/
/*
//코드 3-2; 중괄호 사용 방식
// 중괄호 사용방식1
if (true)
{

}
*/

/*
// 오전과 오후 구분(1)

Console.WriteLine(DateTime.Now.Year);
Console.WriteLine(DateTime.Now.Month);
Console.WriteLine(DateTime.Now.Day);
Console.WriteLine(DateTime.Now.Hour);
Console.WriteLine(DateTime.Now.Minute);
Console.WriteLine(DateTime.Now.Second);

if (DateTime.Now.Hour < 12)
{
    Console.WriteLine("오전입니다.");
}

if (12 <= DateTime.Now.Hour)
{
    Console.WriteLine("오후입니다.");
}
*/

/*
// 홀수 짝수 구분(2)
Console.WriteLine("숫자 입력: ");
int input = int.Parse(Console.ReadLine());

if (input % 2 == 0)
{
    Console.WriteLine("짝수입니다.");
}
else
{
    Console.WriteLine("홀수입니다.");
}
*/

/*
// 오전과 오후 구분(2)
if (DateTime.Now.Hour < 12)
{
    Console.WriteLine("오전입니다!");
}
else
{
    Console.WriteLine("오후입니다.");
}
*/

/*
//중첩 조건문 활용
if (DateTime.Now.Hour < 11)
{
    Console.WriteLine("아침 먹을 시간입니다.");
}
else
{
    if(DateTime.Now.Hour < 15)
    {
        Console.WriteLine("점심 먹을 시간입니다.");
    }
    else
    {
        Console.WriteLine("저녁 먹을 시간입니다.");
    }
}
*/

/*
// if else if 조건문 활용
if (DateTime.Now.Hour < 11)
{
    Console.WriteLine("아침먹을 시간입니다.");
}
else if(DateTime.Now.Hour < 15)
{
    Console.WriteLine("점심먹을 시간입니다.");
}
else
{
    Console.WriteLine("저녁먹을 시간입니다.");
}
*/

/*
//switch 조건문 활용

//변수를 선언합니다.
Console.WriteLine("숫자를 입력하세요: ");
int input = int.Parse(Console.ReadLine());

// 조건문
switch (input % 2)
{
    case 0:
        Console.WriteLine("짝수입니다.");
        break;
    case 1:
        Console.WriteLine("홀수입니다.");
        break;
}
*/

/*
//break 키워드를 사용하지 않는 switch 조건문

//변수를 선언합니다.
Console.WriteLine("이번 달은 몇 월인가요: ");
int input = int.Parse(Console.ReadLine()); 

//조건문
switch (input)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("겨울입니다.");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("봄입니다.");
        break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine("여름입니다.");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("가을입니다.");
        break;
    default:
        Console.WriteLine("대체 어떤 행성에 살고 계신가요?");
        break;
}
*/

/*
// 삼항연산자 : 두 개의 표현식 중 참을 출력
int number = 52273;
Console.WriteLine(number % 2 == 0 ? true : false);
Console.WriteLine(number % 2 == 0 ? "짝수" : "홀수");

string input = Console.ReadLine();
int number2 = int.Parse(input);

Console.WriteLine(number2 > 0 ? "자연수입니다." : "자연수가 아닙니다." );
*/

















