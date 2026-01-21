using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GameProgrammingII_GradedInheritanceChallenge_LucasHardy
{
    internal class Program
    {
        static List<Question> _quizQuestions = new List<Question>();

        static int _score;
        static void Main(string[] args)
        {

            Question question1 = new Question("What is my beverage of choice?", "Pepsi Zero");
            Question question2 = new Question("What game am I working on recreating in my free time?", "Super Mario World");
            Question question3 = new TrueOrFalseQuestion("The office is coming to Fortnite", true);
            Question question4 = new MultipleChoiceQuestion("")
            _quizQuestions.Add(question1);
            _quizQuestions.Add(question2);
            _quizQuestions.Add(question3);



            for (int i = 0; i < _quizQuestions.Count; i++)
            {
                Console.WriteLine($"Current Score: {_score}");
                Console.WriteLine($"Question #{i + 1}");
                _quizQuestions[i].Ask();
                _quizQuestions[i].CheckAnswer();
                if (_quizQuestions[i].CheckAnswer() == true)
                {
                    _score++;
                }
               
            }

        }

    }
}
