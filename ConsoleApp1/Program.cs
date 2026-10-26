//Tootia
//Practice 1
Console.Clear();
Console.ForegroundColor=ConsoleColor.DarkCyan;
Console.WriteLine("Calculating the Area and Perimeter of Rectangle!");
Console.ResetColor();
await Task.Delay(1000);
Console.Write("Enter Length: ");
var L=Convert.ToDouble(Console.ReadLine());
Console.Write("Enter Width: ");
var W=Convert.ToDouble(Console.ReadLine());
await Task.Delay(1000);
Console.Write("The Area is: ");
Console.ForegroundColor=ConsoleColor.DarkCyan;
Console.WriteLine(L*W);
Console.ResetColor();
await Task.Delay(1000);
Console.Write("The Perimeter is: ");
Console.ForegroundColor=ConsoleColor.DarkCyan;
Console.WriteLine((L+W)*2);
Console.ResetColor();
//End