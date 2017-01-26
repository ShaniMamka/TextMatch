using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TextMatch.BLL
{
    public class TextMatchService
    {
        public static List<int> GetTextMatchIndexes(string text, string subText)
        {          
            int i;
            string textLowerCase, subTextLowerCase, checkTextMatch;
            List<int> textMatchIndexes = new List<int>();

            //convert the strings to be lower case
            textLowerCase = text.ToLower();
            subTextLowerCase = subText.ToLower();

            //In each iteration, the 'text' string index will increase by one, 
            //and assign the substring from that index till 'subtext' length to a variable.
            for (i = 0; i < textLowerCase.Length; i++)
            {
                //Check if the 'text' length is in boundaries
                if (textLowerCase.Length >= subTextLowerCase.Length + i)
                {
                    checkTextMatch = textLowerCase.Substring(i, subTextLowerCase.Length);
                    if (subTextLowerCase == checkTextMatch)
                    {
                        textMatchIndexes.Add(i + 1);
                    }
                }
            }
            return textMatchIndexes;
        }
    }
}