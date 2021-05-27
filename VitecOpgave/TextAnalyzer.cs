using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VitecOpgave
{
    //Jeg tænkte at det var en god ide at lave en klasse til at holde convertering og sorterings logik.
    public class TextAnalyzer
    {
        /// <summary>
        /// Converts a string in to it's substrings seperated by a whitespace " "
        /// </summary>
        /// <param name="text"></param>
        /// <returns>A List of strings</returns>
        public List<string> TextToSubstring(string text)
        {
            string processedText = text.ToLower().Replace(".", "").Replace(",", "");

            List<string> substringList = processedText.Split(" ").ToList();
            
            return substringList;
        }

        /// <summary>
        /// Finds how many times strings exists in a List
        /// </summary>
        /// <param name="stringList"></param>
        /// <returns>A Dictionary with a key value pair of <string, int></returns>
        public Dictionary<string, int> SubstringFrequency(List<string> stringList)
        {
            Dictionary<string, int> frequencyDictonary = stringList.GroupBy(x => x)
                                                                    .Where(g => g.Count() > 0)
                                                                    .ToDictionary(x => x.Key, x => x.Count());

            return frequencyDictonary;
        }

        /// <summary>
        /// Sorts a Dictonary in descending order
        /// </summary>
        /// <param name="dictonary"></param>
        /// <returns>A List of key value pairs</returns>
        public List<KeyValuePair<string, int>> DictonarySorter(Dictionary<string, int> dictonary)
        {
            var items = from pair in dictonary 
                        orderby pair.Value descending
                        select pair;

            List<KeyValuePair<string, int>> list = items.ToList();

            return list;
        }
    }
}
