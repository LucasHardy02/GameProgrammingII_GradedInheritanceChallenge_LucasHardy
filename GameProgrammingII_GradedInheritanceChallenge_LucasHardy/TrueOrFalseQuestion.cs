using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgrammingII_GradedInheritanceChallenge_LucasHardy
{
    internal class TrueOrFalseQuestion : Question
    {
        private static string _answerAsString;

        public TrueOrFalseQuestion(string questionText, bool answerAsBool) : base(questionText, _answerAsString)
        {
            _answerAsString = answerAsBool.ToString();
            _questionText = questionText;
        }

    }
}
