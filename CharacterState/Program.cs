using System;
using System.ComponentModel;
using System.Security.Principal;

CharacterState character = CharacterState.Idle;

Console.WriteLine("=== 캐릭터 상태 관리 ===");

while (true)
{
    Console.WriteLine();
    Console.WriteLine($"현재 상태 {character}");
    Console.WriteLine();

    Console.WriteLine("1. 상태 변경");
    Console.WriteLine("2. 상태 목록 보기");
    Console.WriteLine("3. 현재 행동 보기");
    Console.WriteLine("4. 종료");

    Console.Write("선택: ");
    int select = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    switch (select)
    {
        case 1:
            ChangeState();
            break;
        case 2:
            PrintAllState();
            break;
        case 3:
            LookCurrent();
            break;
        case 4:
            Console.WriteLine("프로그램을 종료합니다");
            return;
        default:
            Console.WriteLine("1~4중 입력하세요");
            break;
    }
}

void ChangeState()
{
    Console.Write("변경할 상태 번호 입력 (0~5): ");
    int select = Convert.ToInt32(Console.ReadLine());
    character = (CharacterState)select;
    Console.WriteLine($"상태가 {character}(으)로 변경되었습니다.");
}

void PrintAllState()
{
    Array characterState = Enum.GetValues(typeof(CharacterState));

    Console.WriteLine("=== 상태 목록 ===");
    foreach (CharacterState state in characterState)
    {
        Console.WriteLine($"{state} = {(int)state}");
    }
}

void LookCurrent()
{
    switch (character)
    {
        case CharacterState.Idle:
            Console.WriteLine("[행동] 대기 상태입니다");
            break;
        case CharacterState.Walking:
            Console.WriteLine("[행동] 걷기 상태입니다");
            break;
        case CharacterState.Running:
            Console.WriteLine("[행동] 달리기 상태입니다");
            break;
        case CharacterState.Jumping:
            Console.WriteLine("[행동] 점프 상태입니다");
            break;
        case CharacterState.Attacking:
            Console.WriteLine("[행동] 공격 상태입니다");
            break;
        case CharacterState.Dead:
            Console.WriteLine("[행동] 사망 상태입니다");
            break;
    }
}

enum CharacterState
{
    Idle,
    Walking,
    Running,
    Jumping,
    Attacking,
    Dead
}