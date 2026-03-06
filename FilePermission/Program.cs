using System;

Console.WriteLine("===파일 권한 관리 ===");

FilePermission fileState = FilePermission.None;
Console.WriteLine($"현재 권한: {fileState}");
Console.WriteLine();

Console.WriteLine("[권한 추가]");
AddPermission(FilePermission.Read);
Console.WriteLine($"+ Read 추가: {fileState}");
AddPermission(FilePermission.Write);
Console.WriteLine($"+ Write 추가: {fileState}");
AddPermission(FilePermission.Execute);
Console.WriteLine($"+ Execute 추가: {fileState}");
Console.WriteLine();

Console.WriteLine("[권한 확인]");
Console.WriteLine($"{FilePermission.Read}권한: {HasFlag(FilePermission.Read)}");
Console.WriteLine($"{FilePermission.Write}권한: {HasFlag(FilePermission.Write)}");
Console.WriteLine($"{FilePermission.Execute}권한: {HasFlag(FilePermission.Execute)}");
Console.WriteLine();

Console.WriteLine("[권한 제거]");
RemovePermission(FilePermission.Write);
Console.WriteLine($"Write 제거: {fileState}");
Console.WriteLine();

Console.WriteLine("[제거 후 확인]");
Console.WriteLine($"{FilePermission.Read}권한: {HasFlag(FilePermission.Read)}");
Console.WriteLine($"{FilePermission.Write}권한: {HasFlag(FilePermission.Write)}");
Console.WriteLine($"{FilePermission.Execute}권한: {HasFlag(FilePermission.Execute)}");

void AddPermission(FilePermission filePermission)
{
    fileState |= filePermission;
}

void RemovePermission(FilePermission filePermission)
{
    fileState &= ~filePermission; 
}

bool HasFlag(FilePermission filePermission)
{
    return (fileState & filePermission) != 0;
}

[Flags]
enum FilePermission
{
    None = 0,
    Read = 1,
    Write = 1 << 1,
    Execute = 1 << 2
}