bool a = true;
bool b = true;
if (a && b)
{
    Console.WriteLine("Line 1 - 条件为真");
}
if (a || b)
{
    Console.WriteLine("Line 2 - 条件为真");
}
a = false;
b = true;
if (a && b)
{
    Console.WriteLine("Line 3 - 条件为真");
}
else
{
    Console.WriteLine("Line 3 - 条件不为真");
}
if (a || b)
{
    Console.WriteLine("Line 3.5 - 条件为真");
}
if (!(a && b))
{
    Console.WriteLine("Line 4 - 条件为真");
}
Console.WriteLine("p&q:只有p,q值均为1时，输出为1，其他情况输出0");
Console.WriteLine("p|q:若p,q中有1时，输出为1，均为0时输出0");
Console.WriteLine("p^q:p,q相同(均为0,均为1)时输出0，p,q不同时输出1");

Type type = typeof(string);
Console.WriteLine(type.FullName);
Console.ReadLine();