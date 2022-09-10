using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ControlTask2
{
    internal class EnterDateTime
    {
        private DateTime EnteredDateTime;
        private DateTime DateTimeOfCreation;
        private bool isTimeInFuture;
        private string representationFormat = "D";
        private int theSumOfTheNumbersInARow;

        public EnterDateTime()
        {
            EnteredDateTime = new DateTime();
            DateTimeOfCreation = DateTime.Now;
        }

        public EnterDateTime(DateTime EnteredDateTime)
        {
            this.EnteredDateTime = EnteredDateTime;
            DateTimeOfCreation = DateTime.Now;
        }

        public bool IsTimeInFuture
        {
            get
            {
                int comparisonDateTime = DateTime.Compare(EnteredDateTime, DateTimeOfCreation);
                if (comparisonDateTime <= 0)
                {
                    isTimeInFuture = false;
                }
                else isTimeInFuture = true;
                return isTimeInFuture;
            }
        }

        public void OutputOfTheFormatSettingsMenu()
        {
            DateTime exampleDateTime = DateTimeOfCreation;
            Console.WriteLine("Choose a representation format DateTime:");
            Console.WriteLine("D: {0}", exampleDateTime.ToString("D"));
            Console.WriteLine("d; {0}", exampleDateTime.ToString("d"));
            Console.WriteLine("F: {0}", exampleDateTime.ToString("F"));
            Console.WriteLine("f: {0}", exampleDateTime.ToString("f"));
            Console.WriteLine("G; {0}", exampleDateTime.ToString("G"));
            Console.WriteLine("g: {0}", exampleDateTime.ToString("g"));
            Console.WriteLine("M: {0}", exampleDateTime.ToString("M"));
            Console.WriteLine("O: {0}", exampleDateTime.ToString("O"));
            Console.WriteLine("o: {0}", exampleDateTime.ToString("o"));
            Console.WriteLine("R; {0}", exampleDateTime.ToString("R"));
            Console.WriteLine("s: {0}", exampleDateTime.ToString("s"));
            Console.WriteLine("T: {0}", exampleDateTime.ToString("T"));
            Console.WriteLine("t: {0}", exampleDateTime.ToString("t"));
            Console.WriteLine("U: {0}", exampleDateTime.ToString("U"));
            Console.WriteLine("u: {0}", exampleDateTime.ToString("u"));
            Console.WriteLine("Y: {0}", exampleDateTime.ToString("Y"));
        }

        public string RepresentationFormat
        {
            get
            {
                return representationFormat;
            }
            set
            {
                representationFormat = value;
            }
        }

        public int TheSumOfTheNumbersInARow
        {
            get
            {
                int count = 0;
                foreach (var i in EnteredDateTime.ToString(representationFormat)) if (char.IsDigit(i)) count++;
                return theSumOfTheNumbersInARow;
            }
        }

        public bool Compare(EnterDateTime anotherInstance)
        {
            if (anotherInstance.TheSumOfTheNumbersInARow < TheSumOfTheNumbersInARow)
                return true;
            else return false;
        }
    }
}