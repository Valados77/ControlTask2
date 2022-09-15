using System.Text.RegularExpressions;

namespace ControlTask2
{
    internal class EnterDateTime
    {
        public DateTime EnteredDateTime { get; }
        public DateTime DateTimeOfCreation { get; }
        private bool _isTimeInFuture;
        private string? _representationFormat = "D";
        private int _sumOfNumbersInRow;

        public EnterDateTime()
        {
            EnteredDateTime = new DateTime();
            DateTimeOfCreation = DateTime.Now;
        }

        public EnterDateTime(DateTime enteredDateTime)
        {
            this.EnteredDateTime = enteredDateTime;
            DateTimeOfCreation = DateTime.Now;
        }

        public bool IsTimeInFuture
        {
            get
            {
                var comparisonDateTime = DateTime.Compare(EnteredDateTime, DateTimeOfCreation);
                _isTimeInFuture = comparisonDateTime > 0;

                return _isTimeInFuture;
            }
        }

        public string? RepresentationFormat
        {
            get
            {
                return _representationFormat;
            }
            set
            {
                const string pattern = @"[D,d,F,f,G,g,M,O,R,s,T,t,U,u,Y]";
                _representationFormat = Regex.IsMatch(value, pattern) ? value : "D";
            }
        }

        public int SumOfNumbersInRow
        {
            get
            {
                dynamic sum = 0;
                foreach (var i in EnteredDateTime.ToString(_representationFormat))
                {
                    if (char.IsDigit(i))
                    {
                        sum += (i - '0');
                    }
                }

                _sumOfNumbersInRow = sum;
                return _sumOfNumbersInRow;
            }
        }

        public bool Compare(EnterDateTime anotherInstance)
        {
            return anotherInstance.SumOfNumbersInRow < SumOfNumbersInRow;
        }
    }
}