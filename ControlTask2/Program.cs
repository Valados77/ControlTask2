using ControlTask2;

internal class Program
{
    private static void Main(string[] args)
    {
        DateTime firstDateTime = new DateTime(2030, 6, 15, 12, 30, 30);
        EnterDateTime firstEnterDateTime = new EnterDateTime(firstDateTime);
        EnterDateTime secondEnterDateTime = new EnterDateTime();

        OutputOfTheFormatSettingsMenu(firstEnterDateTime);
        firstEnterDateTime.RepresentationFormat = Console.ReadLine();
        Console.Clear();
        OutputOfTheFormatSettingsMenu(secondEnterDateTime);
        secondEnterDateTime.RepresentationFormat = Console.ReadLine();
        Console.Clear();

        Console.WriteLine(firstEnterDateTime.EnteredDateTime.ToString(firstEnterDateTime.RepresentationFormat));
        Console.WriteLine(secondEnterDateTime.EnteredDateTime.ToString(secondEnterDateTime.RepresentationFormat));
        Console.ReadLine();

        Console.WriteLine($"Is firstDateTime in future? {firstEnterDateTime.IsTimeInFuture}");
        Console.WriteLine($"Is secondEnterDateTime in future? {secondEnterDateTime.IsTimeInFuture}");
        Console.ReadLine();

        Console.WriteLine($"The sum of the digits in the firstEnterDateTime with the currently selected format: {firstEnterDateTime.TheSumOfTheNumbersInARow}");
        Console.WriteLine($"The sum of the digits in the secondEnterDateTime with the currently selected format: {secondEnterDateTime.TheSumOfTheNumbersInARow}");
        Console.ReadLine();

        Console.WriteLine($"The sum of the digits of the firstEnterDateTime is greater than the sum of the secondEnterDateTime {firstEnterDateTime.Compare(secondEnterDateTime)}");
    }

    private static void OutputOfTheFormatSettingsMenu(EnterDateTime exampleEnterDateTime)
    {
        DateTime exampleDateTime = exampleEnterDateTime.EnteredDateTime;
        Console.WriteLine("D: {0}", exampleDateTime.ToString("D"));
        Console.WriteLine("d; {0}", exampleDateTime.ToString("d"));
        Console.WriteLine("F: {0}", exampleDateTime.ToString("F"));
        Console.WriteLine("f: {0}", exampleDateTime.ToString("f"));
        Console.WriteLine("G; {0}", exampleDateTime.ToString("G"));
        Console.WriteLine("g: {0}", exampleDateTime.ToString("g"));
        Console.WriteLine("M: {0}", exampleDateTime.ToString("M"));
        Console.WriteLine("O: {0}", exampleDateTime.ToString("O"));
        Console.WriteLine("R; {0}", exampleDateTime.ToString("R"));
        Console.WriteLine("s: {0}", exampleDateTime.ToString("s"));
        Console.WriteLine("T: {0}", exampleDateTime.ToString("T"));
        Console.WriteLine("t: {0}", exampleDateTime.ToString("t"));
        Console.WriteLine("U: {0}", exampleDateTime.ToString("U"));
        Console.WriteLine("u: {0}", exampleDateTime.ToString("u"));
        Console.WriteLine("Y: {0}", exampleDateTime.ToString("Y"));
        Console.Write($"Choose a representation format DateTime for {exampleDateTime}: ");
    }
}