using System.Runtime.InteropServices;

Console.WriteLine("***** Testes com C# 11 | Aliases para IntPtr e UIntPtr (nint e nuint) *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName}- Kernel: {Environment
    .OSVersion.VersionString}");

Console.WriteLine();

IntPtr intPtr01 = IntPtr.Zero;
Console.WriteLine($"{nameof(intPtr01)} = {intPtr01} [{intPtr01.GetType().FullName}]");

nint intPtr02 = nint.Zero;
Console.WriteLine($"{nameof(intPtr02)} = {intPtr02} [{intPtr02.GetType().FullName}]");

IntPtr intPtr03 = -10;
Console.WriteLine($"{nameof(intPtr03)} = {intPtr03} [{intPtr03.GetType().FullName}]");

nint intPtr04 = -15;
Console.WriteLine($"{nameof(intPtr04)} = {intPtr04} [{intPtr04.GetType().FullName}]");

Console.WriteLine();

UIntPtr nuintPtr01 = UIntPtr.Zero;
Console.WriteLine($"{nameof(nuintPtr01)} = {nuintPtr01} [{nuintPtr01.GetType().FullName}]");

nuint nuintPtr02 = nuint.Zero;
Console.WriteLine($"{nameof(nuintPtr02)} = {nuintPtr02} [{nuintPtr02.GetType().FullName}]");

UIntPtr nuintPtr03 = 20;
Console.WriteLine($"{nameof(nuintPtr03)} = {nuintPtr03} [{nuintPtr03.GetType().FullName}]");

nuint nuintPtr04 = 30;
Console.WriteLine($"{nameof(nuintPtr04)} = {nuintPtr04} [{nuintPtr04.GetType().FullName}]");