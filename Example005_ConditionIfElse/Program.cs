Console.WriteLine("Enter your name: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("Yoohoo, it is MASHA");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}