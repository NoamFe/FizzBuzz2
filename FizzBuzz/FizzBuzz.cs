using System;
using System.Collections.Generic;
using System.Linq;


namespace FizzBuzz
{ 

    public class FizzBuzz
    {
        public void Validate(int fromNumber, int toNumber, Dictionary<int, string> inputValues)
        {
            if (toNumber < fromNumber)
                throw new Exception("To Number Must Be Bigger Than From Number");
            if (inputValues.Count == 0)
                throw new Exception("Input Values Must Contain At Least One Value");
        }

        public IList<string> Run(int fromNumber, int toNumber, Dictionary<int, string> inputValues)
        {
            Validate(fromNumber, toNumber, inputValues);

            var returnDictionary = new List<string>();
            var orderedInputValues  = inputValues.OrderBy(x => x.Key).ToList();
           
            for (int i = fromNumber; i <= toNumber; i++)
            { 
                var valueToPrint = string.Empty;

                foreach (var inputValue in orderedInputValues)
                {
                    if (i%inputValue.Key == 0)
                    {
                        valueToPrint += inputValue.Value;
                    }
                }
                returnDictionary.Add(valueToPrint == string.Empty ? i.ToString() : valueToPrint);
            }
            return returnDictionary;
        }
    }
}
