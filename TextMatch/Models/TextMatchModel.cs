using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TextMatch.Models
{
    public class TextMatchModel
    {
        public string Text { get; set; }
        public string Subtext { get; set; }
        public List<int> MatchIndexes { get; set; }
        public string ErrorMessage { get; set; }

        //Empty constructor
        public TextMatchModel()
        {
            MatchIndexes = new List<int>();
        }
    }
}