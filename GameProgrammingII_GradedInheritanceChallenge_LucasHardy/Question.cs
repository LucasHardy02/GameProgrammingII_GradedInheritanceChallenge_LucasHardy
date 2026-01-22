using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GameProgrammingII_GradedInheritanceChallenge_LucasHardy
{
    internal class Question
    {
        protected string _questionText;
        protected string _answerText;
        protected string _playerAnswer;

        public Question(string question, string answer)
        {
            _questionText = question;
            _answerText = answer.ToLower();
        }

        public void Ask()
        {
            Console.WriteLine($"{_questionText}");
        }
        public virtual bool CheckAnswer()
        {
            _playerAnswer = Console.ReadLine().ToLower();


            if(_playerAnswer == _answerText)
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
