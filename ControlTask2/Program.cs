using ControlTask2;

internal class Program
{
    private static void Main(string[] args)
    {
        var firstDateTime = new DateTime(2030, 6, 15, 12, 30, 30);
        var firstEnterDateTime = new EnterDateTime(firstDateTime);
        var secondEnterDateTime = new EnterDateTime();

        OutputOfFormatSettingsMenu(firstEnterDateTime);
        firstEnterDateTime.RepresentationFormat = Console.ReadLine();
        Console.Clear();
        OutputOfFormatSettingsMenu(secondEnterDateTime);
        secondEnterDateTime.RepresentationFormat = Console.ReadLine();
        Console.Clear();

        PrintResults(firstEnterDateTime, secondEnterDateTime);
    }

    private static void OutputOfFormatSettingsMenu(EnterDateTime exampleEnterDateTime)
    {
        var exampleDateTime = exampleEnterDateTime.EnteredDateTime;
        Console.WriteLine("D: {0:D}", exampleDateTime);
        Console.WriteLine("d: {0:d}", exampleDateTime);
        Console.WriteLine("F: {0:F}", exampleDateTime);
        Console.WriteLine("f: {0:f}", exampleDateTime);
        Console.WriteLine("G: {0:G}", exampleDateTime);
        Console.WriteLine("g: {0:g}", exampleDateTime);
        Console.WriteLine("M: {0:M}", exampleDateTime);
        Console.WriteLine("O: {0:O}", exampleDateTime);
        Console.WriteLine("R: {0:R}", exampleDateTime);
        Console.WriteLine("s: {0:s}", exampleDateTime);
        Console.WriteLine("T: {0:T}", exampleDateTime);
        Console.WriteLine("t: {0:t}", exampleDateTime);
        Console.WriteLine("U: {0:U}", exampleDateTime);
        Console.WriteLine("u: {0:u}", exampleDateTime);
        Console.WriteLine("Y: {0:Y}", exampleDateTime);
        Console.Write($"Choose a representation format DateTime for {exampleDateTime}: ");
    }

    private static void PrintResults(EnterDateTime firstEnterDateTime, EnterDateTime secondEnterDateTime)
    {
        Console.WriteLine(firstEnterDateTime.EnteredDateTime.ToString(firstEnterDateTime.RepresentationFormat));
        Console.WriteLine(secondEnterDateTime.EnteredDateTime.ToString(secondEnterDateTime.RepresentationFormat));
        Console.WriteLine();

        Console.WriteLine($"Is firstDateTime in future? {firstEnterDateTime.IsTimeInFuture}");
        Console.WriteLine($"Is secondEnterDateTime in future? {secondEnterDateTime.IsTimeInFuture}");
        Console.WriteLine();

        Console.WriteLine($"The sum of the digits in the firstEnterDateTime with the currently selected format: {firstEnterDateTime.SumOfNumbersInRow}");
        Console.WriteLine($"The sum of the digits in the secondEnterDateTime with the currently selected format: {secondEnterDateTime.SumOfNumbersInRow}");
        Console.WriteLine();

        Console.WriteLine($"The sum of the digits of the firstEnterDateTime is greater than the sum of the secondEnterDateTime {firstEnterDateTime.Compare(secondEnterDateTime)}");
    }
}