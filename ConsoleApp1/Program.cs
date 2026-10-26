#region 
//Tootia
//Practice 1
Console.Clear();
Console.ForegroundColor=ConsoleColor.DarkCyan;
Console.WriteLine("Calculating the Area and Perimeter of Rectangle!");
Console.ResetColor();
await Task.Delay(1000);
Console.Write("Enter Length: ");
var L=Convert.ToDouble(Console.ReadLine());
await Task.Delay(1000);
Console.Write("Enter Width: ");
var W=Convert.ToDouble(Console.ReadLine());
await Task.Delay(1000);
Console.Write("The Area is: ");
await Task.Delay(1000);
Console.ForegroundColor=ConsoleColor.DarkCyan;
Console.WriteLine(L*W);
Console.ResetColor();
await Task.Delay(1000);
Console.Write("The Perimeter is: ");
await Task.Delay(1000);
Console.ForegroundColor=ConsoleColor.DarkCyan;
Console.WriteLine((L+W)*2);
Console.ResetColor();
//End
#endregion
#region 
//Practice 2
Console.ForegroundColor=ConsoleColor.DarkBlue;
Console.WriteLine("Calculating the Area and Circumference of a circle!");
Console.ResetColor();
await Task.Delay(1000);
Console.Write("Enter the Radius: ");
var R=Convert.ToDouble(Console.ReadLine());
await Task.Delay(1000);
Console.Write("The Circumference is: ");
await Task.Delay(1000);
Console.ForegroundColor=ConsoleColor.DarkBlue;
Console.WriteLine(2*3.14*R);
Console.ResetColor();
await Task.Delay(1000);
Console.Write("The Area is: ");
await Task.Delay(1000);
Console.ForegroundColor=ConsoleColor.DarkBlue;
Console.WriteLine(2*3.14*R*R);
Console.ResetColor();
//End
#endregion