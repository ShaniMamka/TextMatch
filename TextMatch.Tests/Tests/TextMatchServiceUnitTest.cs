using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextMatch.BLL;
using TextMatch.Models;

namespace TextMatch.Tests.Tests
{
    [TestClass]
    public class TextMatchServiceUnitTest
    {
        //This test checks the result for a single character.
        [TestMethod]
        public void TestGetTextMatchIndexesSingalChar()
        {
            TextMatchModel textMatch = new TextMatchModel();

            textMatch.Text = "A";
            textMatch.Subtext = "A";
            textMatch.MatchIndexes.Add(1);

            CollectionAssert.AreEqual(textMatch.MatchIndexes, TextMatchService.GetTextMatchIndexes(textMatch.Text, textMatch.Subtext));
        }

        //This test checks the result for a case insensitive scenario.
        [TestMethod]
        public void TestGetTextMatchIndexesCaseInsensitive()
        {
            TextMatchModel textMatch = new TextMatchModel();

            textMatch.Text = "A";
            textMatch.Subtext = "a";
            textMatch.MatchIndexes.Add(1);

            CollectionAssert.AreEqual(textMatch.MatchIndexes, TextMatchService.GetTextMatchIndexes(textMatch.Text, textMatch.Subtext));
        }

        //This test checks the result for subtext that is longer than the text scenario.
        [TestMethod]
        public void TestGetTextMatchIndexesSubtextLonger()
        {
            TextMatchModel textMatch = new TextMatchModel();

            textMatch.Text = "AB";
            textMatch.Subtext = "ABB";

            CollectionAssert.AreEqual(textMatch.MatchIndexes, TextMatchService.GetTextMatchIndexes(textMatch.Text, textMatch.Subtext));
        }

        //This test checks the result for numbers inputs scenario.
        [TestMethod]
        public void TestGetTextMatchIndexesNumbers()
        {
            TextMatchModel textMatch = new TextMatchModel();

            textMatch.Text = "11112";
            textMatch.Subtext = "12";
            textMatch.MatchIndexes.Add(4);

            CollectionAssert.AreEqual(textMatch.MatchIndexes, TextMatchService.GetTextMatchIndexes(textMatch.Text, textMatch.Subtext));
        }

        //All of the tests below were taken from the assignment document that was sent to me
        [TestMethod]
        public void TestGetTextMatchIndexes1()
        {
            TextMatchModel textMatch = new TextMatchModel();

            textMatch.Text = "aaaa";
            textMatch.Subtext = "aa";
            textMatch.MatchIndexes.Add(1);
            textMatch.MatchIndexes.Add(2);
            textMatch.MatchIndexes.Add(3);

            CollectionAssert.AreEqual(textMatch.MatchIndexes, TextMatchService.GetTextMatchIndexes(textMatch.Text, textMatch.Subtext));
        }

        [TestMethod]
        public void TestGetTextMatchIndexes2()
        {
            TextMatchModel textMatch = new TextMatchModel();

            textMatch.Text = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we’ll all have tea";
            textMatch.Subtext = "Polly";
            textMatch.MatchIndexes.Add(1);
            textMatch.MatchIndexes.Add(26);
            textMatch.MatchIndexes.Add(51);

            CollectionAssert.AreEqual(textMatch.MatchIndexes, TextMatchService.GetTextMatchIndexes(textMatch.Text, textMatch.Subtext));
        }

        [TestMethod]
        public void TestGetTextMatchIndexes3()
        {
            TextMatchModel textMatch = new TextMatchModel();

            textMatch.Text = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we’ll all have tea";
            textMatch.Subtext = "polly";
            textMatch.MatchIndexes.Add(1);
            textMatch.MatchIndexes.Add(26);
            textMatch.MatchIndexes.Add(51);

            CollectionAssert.AreEqual(textMatch.MatchIndexes, TextMatchService.GetTextMatchIndexes(textMatch.Text, textMatch.Subtext));
        }

        [TestMethod]
        public void TestGetTextMatchIndexes4()
        {
            TextMatchModel textMatch = new TextMatchModel();

            textMatch.Text = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we’ll all have tea";
            textMatch.Subtext = "ll";
            textMatch.MatchIndexes.Add(3);
            textMatch.MatchIndexes.Add(28);
            textMatch.MatchIndexes.Add(53);
            textMatch.MatchIndexes.Add(78);
            textMatch.MatchIndexes.Add(82);

            CollectionAssert.AreEqual(textMatch.MatchIndexes, TextMatchService.GetTextMatchIndexes(textMatch.Text, textMatch.Subtext));
        }

        [TestMethod]
        public void TestGetTextMatchIndexes5()
        {
            TextMatchModel textMatch = new TextMatchModel();

            textMatch.Text = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we’ll all have tea";
            textMatch.Subtext = "X";

            CollectionAssert.AreEqual(textMatch.MatchIndexes, TextMatchService.GetTextMatchIndexes(textMatch.Text, textMatch.Subtext));
        }

        [TestMethod]
        public void TestGetTextMatchIndexes6()
        {
            TextMatchModel textMatch = new TextMatchModel();

            textMatch.Text = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we’ll all have tea";
            textMatch.Subtext = "Polx";

            CollectionAssert.AreEqual(textMatch.MatchIndexes, TextMatchService.GetTextMatchIndexes(textMatch.Text, textMatch.Subtext));
        }
    }
}
