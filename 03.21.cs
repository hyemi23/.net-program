// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


/*
// 159페이지
// 기본 예제 4-1 배열생성하고 요소에 접근

// 배열 생성
int[] intArray = { 52, 273, 32, 65, 103 };
// 배열 요소 변경
intArray[0] = 0;

// 요소 출력
Console.WriteLine(intArray[0]);
Console.WriteLine(intArray[1]);
Console.WriteLine(intArray[2]);
Console.WriteLine(intArray[3]);    
*/

/*
// 기본 예제 4-2 원하는 크기의 배열 생성
//배열 생성
int[] IntArray = new int[100];

Console.WriteLine(IntArray[0]);
Console.WriteLine(IntArray[99]);
*/

/*
// 기본 예제 4-3 while 반복문의 이용

// 변수 선언
int i = 0;
int[] intArray = { 52, 273, 32, 65, 103 };

// 반복문 수행
while (i < intArray.Length)
{
    // 출력
    Console.WriteLine(i + " 번째 출력: " + intArray[i]);

    // 탈출위해 변수를 더함
    i++;
}
*/

/*
// 기본 예제 4-4 do while 반복문 활용
string input;
do
{

    Console.Write("입력(exit을 입력하면 종료): ");
    input = Console.ReadLine();
}while (input != "exit");
*/

/*
// 기본 예제 4-5 for 반복문으로 덧셈

// 변수 선언
int output = 0;

// 반복 수행
for (int i = 0; i <= 100; i++)
{
    output += i;
}
Console.WriteLine(output);
*/

/*
// 기본 예제 4-6 for 반복문으로 곱셈

int output = 1;

for (int i = 1; i <= 5; i++)
{
    output *= i;
}
Console.WriteLine(output);
*/

/*
// 기본 예제 4-7 한글 전부 출력

for (int i = '가'; i <= '힣'; i++)
{
    Console.Write((char)i);
}
*/

/*
// 기본 예제 4-8 역 for 반복문

int[] intArray = { 1, 2, 3, 4, 5, 6 };

// 요소의 길이를 출력합니다.
for (int i = intArray.Length - 1; i >= 0; i--)
{
    Console.WriteLine(intArray[i]);
}
*/

/*
// 기본 예제 4-9 foreach 반복문과 배열

// 변수 선언
string[] array = { "사과", "배", "포도", "딸기", "바나나" };

// 반복 수행
foreach (string item in array) // item은 임의로 정한 것.
{
    Console.WriteLine(item);
}
*/

/*
// 기본 예제 4-10 foreach 반복문과 var 키워드

string[] array = { "사과", "배", "포도", "딸기", "바나나" };

// 반복 수행
foreach (var item in array) // var를 사용해서 string 자동 선택?
{
    Console.WriteLine(item);
}
*/


/*
// 기본 예제 4-11 별 피라미드(1) 교수님이 좋아하시는 유형, 셤출제!!???


for (int i = 0; i <= 10; i++)
{
    for (int j = 1; j <= i + 1; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
*/

/*
// 기본 예제 4-12 별 피라미드(2)
for (int i = 0; i <= 10; i++)
{
    for (int j = 1; j <= i + 1; j++)
    {
        Console.Write(" ");
    }
    for (int j = 1; j < i + 1; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
*/

/*
// 기본 예제 4-13 break 키워드

while (true)
{
    Console.Write("숫자를 입력해주세요(짝수를 입력하면 종료): ");
    int input = int.Parse(Console.ReadLine());
    if (input %2 == 0)
    {
        break;
    }
}
*/

/*
// 기본 예제 4-14 continue 키워드

for (int i = 1; i < 10; i++)
{
    if (i % 2 == 0)
    {
        continue;
    }
    Console.WriteLine(i);
}
*/






























































































































