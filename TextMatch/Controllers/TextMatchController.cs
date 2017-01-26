using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TextMatch.Models;
using TextMatch.BLL;

namespace TextMatch.Controllers
{
    public class TextMatchController : Controller
    {
        [HttpGet]
        public ActionResult SearchTextMatch()
        {
            var textMatch = new TextMatchModel();
            return View(textMatch);
        }

        [HttpPost]
        public ActionResult SearchTextMatchIndexes(TextMatchModel textMatch)
        {
            //Server validation
            if (String.IsNullOrWhiteSpace(textMatch.Subtext) || String.IsNullOrWhiteSpace(textMatch.Text))
            {
                textMatch.ErrorMessage = "Invalid input: The subtext and the text can't be empty.";
            }

            else if (textMatch.Subtext.Length > textMatch.Text.Length)
            {
                textMatch.ErrorMessage = "Invalid input: The subtext can't be longer than the text.";
            }
            
            //Get text match Indexes from the service
            else
            {
                textMatch.MatchIndexes = TextMatchService.GetTextMatchIndexes(textMatch.Text, textMatch.Subtext);
                if (textMatch.MatchIndexes.Count == 0)
                {
                    ViewBag.MatchIndexesMessage = "There is no output";
                }
            }

            return View("SearchTextMatch", textMatch);
        }



    }
}
