using System;

Priority priority = Priority.High;
if (priority == Priority.High)
    Console.WriteLine("높은 우선순위");

Animal animal = Animal.Tiger;
Console.WriteLine(animal);

if (animal == Animal.Tiger)
{
    Console.WriteLine("호랑이");
}

int red = (int)Color.Red;
int green = (int)Color.Green;
int blue = (int)Color.Blue;

Console.WriteLine($"Red: {red}, Green: {green}, Blue: {blue}");

Console.WriteLine(sizeof(SmallEnum));

Type colorType = typeof(Color);

string[] colors = Enum.GetNames(colorType);

Console.WriteLine("ConsoleColor 열거형의 색상들: ");
foreach (string c in colors)
{
    Console.WriteLine(c);
}

string colorName = "Red";
ConsoleColor color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colorName);
Console.ForegroundColor = color;
Console.WriteLine("빨간색 텍스트");
Console.ResetColor();
Console.WriteLine("기본 색상 텍스트");

string input = "Up";
if (Enum.TryParse(input, out Direction direction))
{
    Console.WriteLine($"변환 성공: {direction}");
}
else
{
    Console.WriteLine("변환 실패");
}

string invalid = "Forward";
if(Enum.TryParse(invalid, out Direction result))
{
    Console.WriteLine($"변환 성공: {result}");
}
else
{
    Console.WriteLine($"'{invalid}'은(는) 유효하지 않은 값");
}


bool isValid1 = Enum.IsDefined(typeof(Animal), 1);
Console.WriteLine($"1은 유효한 Animal 값인가? {isValid1}");

bool isValid2 = Enum.IsDefined(typeof(Animal), 100);
Console.WriteLine($"100은 유효한 Animal 값인가? {isValid2}");
 
bool isValid3 = Enum.IsDefined(typeof(Animal), "Tiger");
Console.WriteLine($"'Tiger'는 유효한 Animal 값인가? {isValid3}");

Direction dir = Direction.Right;
int num = (int)dir;
Console.WriteLine($"{dir} = {num}");

int value = 2;
Direction dir1 = (Direction)value;
Console.WriteLine($"{value} = {dir1}");

Animal invalid1 = (Animal)100;
Console.WriteLine(invalid1);

enum Priority
{
    High,
    Normal,
    Low
}

enum Animal
{
    Mouse,
    Cow,
    Tiger
}

enum Color
{
    Red = 10,
    Green,
    Blue = 20
}

enum SmallEnum : byte
{
    Left, 
    Right, 
    Top, 
    Bottom
}

enum Direction
{
    Up, 
    Down, 
    Left, 
    Right
}