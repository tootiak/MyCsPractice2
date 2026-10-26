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
#region 
//Practice 3
Console.ForegroundColor=ConsoleColor.DarkGreen;
Console.WriteLine("Calculating the Average!");
Console.ResetColor();
await Task.Delay(1000);
Console.Write("Enter number(1/3): ");
var N1=Convert.ToInt32(Console.ReadLine());
await Task.Delay(1000);
Console.Write("Enter number(2/3): ");
var N2=Convert.ToInt32(Console.ReadLine());
await Task.Delay(1000);
Console.Write("Enter number(3/3): ");
var N3=Convert.ToInt32(Console.ReadLine());
await Task.Delay(1000);
Console.Write("The Average is: ");
await Task.Delay(1000);
Console.ForegroundColor=ConsoleColor.DarkGreen;
Console.Write((N1+N2+N3)/3);
Console.ResetColor();
//End
#endregion