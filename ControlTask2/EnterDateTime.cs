using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ControlTask2
{
    internal class EnterDateTime
    {
        public DateTime EnteredDateTime { get; }
        public DateTime DateTimeOfCreation { get; }
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

        public string RepresentationFormat
        {
            get
            {
                return representationFormat;
            }
            set
            {
                string pattern = @"[D,d,F,f,G,g,M,O,R,s,T,t,U,u,Y]";
                if (Regex.IsMatch(value, pattern)) representationFormat = value;
                else representationFormat = "D";
            }
        }

        public int TheSumOfTheNumbersInARow
        {
            get
            {
                foreach (var i in EnteredDateTime.ToString(representationFormat)) if (char.IsDigit(i)) theSumOfTheNumbersInARow++;
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