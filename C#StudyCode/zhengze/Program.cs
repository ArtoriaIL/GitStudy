using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string str = "A Thousand Splendid Suns";

        Console.WriteLine("Matching words that start with 'S': ");
        ShowMatch(str, @"\bS\S*");
        Console.ReadKey();
    }    
    private static void ShowMatch(string text, string expr)
    {
        Console.WriteLine("The Expression: " + expr);
        MatchCollection mc = Regex.Matches(text, expr);
        foreach (Match m in mc)
        {
            Console.WriteLine(m);
        }
    }
}
