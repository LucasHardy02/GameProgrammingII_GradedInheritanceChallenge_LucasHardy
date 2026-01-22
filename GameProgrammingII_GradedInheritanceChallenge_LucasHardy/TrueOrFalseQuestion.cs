using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgrammingII_GradedInheritanceChallenge_LucasHardy
{
    internal class TrueOrFalseQuestion : Question
    {

        public TrueOrFalseQuestion(string questionText, bool answerAsBool) : base(questionText, answerAsBool.ToString())
        {

        }
        public override bool CheckAnswer()
        {
            Console.WriteLine("True or False?");
            return base.CheckAnswer();
        }
    }
}
