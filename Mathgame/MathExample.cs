using Mathgame.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;


namespace Mathgame
{
    class MathExample : IMathExample
    {
        #region properties
        public string? Example { get; set; }

        public char Operator { get; set; } 

        public int Result { get; set; }
        #endregion
        #region constructors
        public MathExample(char _operator) {
            Operator = _operator;
            Generate();
        }

        #endregion
        #region methods
        /// <summary>
        /// Generates a random math example
        /// </summary>
        public void Generate()
        {
            string example = "";
            Random r = new();
            int amountOfNumbers = r.Next(1, 10);
            int[] numbers = new int[amountOfNumbers];

            for(int i = 0; i< amountOfNumbers; i++)
            {
                numbers[i] = r.Next(0, 100);
                example += $"{numbers[i]} {Operator} ";
            }
            var result = new DataTable().Compute(example, null);

            Result = int.Parse(result.ToString());
        }

        public void Show()
        {
            Console.WriteLine(Example);
        }
        #endregion
    }
}
