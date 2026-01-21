using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace GameProgrammingII_GradedInheritanceChallenge_LucasHardy
{
    internal class MultipleChoiceQuestion : Question
    {
        private string[] _answerOptions;
        private int _correctAnswer;
        public MultipleChoiceQuestion(string question, string[] answerOptions, int correctAnswer) : base(question, answerOptions.ToString())
        {
            _answerOptions = answerOptions;
            _correctAnswer = correctAnswer;

        }

        public override bool CheckAnswer()
        {
            Console.WriteLine("Please select your answer");

            for (int i = 0; i < _answerOptions.Length; i++)
            {
                Console.WriteLine($"{_answerOptions}");
            }

            char selectedKey;
            while (true)
            {
                selectedKey = Console.ReadKey().KeyChar;
                if(char.IsDigit(selectedKey))
                {
                    break;
                }

            }
            int answer = int.Parse(selectedKey.ToString());
            

            if (selectedKey == _correctAnswer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
