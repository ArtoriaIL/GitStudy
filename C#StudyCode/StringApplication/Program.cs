string fname, lname;
fname = "Rowan";
lname = "Atkinson";
string fullname = fname + lname;
Console.WriteLine($"Full Name:{fullname}");

char[] letters = { 'H', 'e', 'l', 'l', 'o' };
string greetings = new(letters);
Console.WriteLine($"Greetings:{greetings}");

string[] sarray = { "Hello", "From", "Tutorials", "Point" };
string message=String.Join(" ", sarray);
Console.WriteLine($"Message:{message}");

DateTime waiting = new(2012, 10, 10, 17, 58, 1);
string chat = String.Format("Message sent at{0:t} on {0:D}", waiting);
Console.WriteLine($"Message:{chat}");
Console.ReadKey();
