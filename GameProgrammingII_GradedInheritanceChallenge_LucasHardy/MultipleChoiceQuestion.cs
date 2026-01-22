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
                Console.WriteLine($"#{i + 1}: {_answerOptions[i]}");
            }

            string selectedKey = Console.ReadLine();
            
            int answer = int.Parse(selectedKey);


            while (selectedKey == null || answer < 1 || answer > 4)
            {
                Console.WriteLine("Wrong Input, Please try again");
                selectedKey = Console.ReadLine();
                answer = int.Parse(selectedKey);

            }

            if (answer == _correctAnswer)
            {
                Console.WriteLine("Correct");
                Console.WriteLine("");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey(true);
                Console.Clear();
                Program._score++;
                return true;
            }
            else
            {
                Console.WriteLine("False");
                Console.WriteLine("");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey(true);
                Console.Clear();
                return false;
            }
        }
    }
}
