using System.Text.RegularExpressions;

class Note
{
    static void Main()

    {
        Console.WriteLine("Insert your instrument: ");
        string instrument = Console.ReadLine();
        Console.WriteLine("Insert your note: ");
        string note = Console.ReadLine();
        switch (instrument)
        {
            case "Picollo" when new Regex(@"[C-D4-7]").IsMatch(note):
                Console.WriteLine("true");
                break;
            case "Tuba" when new Regex(@"[D-F1-4]").IsMatch(note):
                Console.WriteLine("true");
                break;
            case "Guitar" when new Regex(@"[E3-6]").IsMatch(note):
                Console.WriteLine("true");
                break;
            case "Piano" when new Regex(@"[A-C0-8]").IsMatch(note):
                Console.WriteLine("true");
                break;
            case "Violin" when new Regex(@"[A-G3-7]").IsMatch(note):
                Console.WriteLine("true");
                break;
            default:
                Console.WriteLine("false") ;
                break;

        }

    }
}