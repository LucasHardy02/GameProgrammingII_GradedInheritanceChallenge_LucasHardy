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
        static public int _score;
        static string[] _question7Answers = { "Tomato Head", "Pizza Pete", "Pizza Patrick", "Tomato Tyrant" };
        static string[] _question8Answers = { "Griddy", "Floss", "Take The L", "Fresh" };
        static string[] _question9Answers = { "2016", "2017", "2018", "2019" };

        static void Main(string[] args)
        {
            

            Question question1 = new Question("What item color is considered 'Rare' rarity", "Blue");
            Question question2 = new Question("What location is infamous for being dangerous", "Tilted Towers");
            Question question3 = new Question("What was the tier 100 skin in Chapter 1, Season 3", "The Reaper");
            Question question4 = new TrueOrFalseQuestion("The office is coming to Fortnite", true);
            Question question5 = new TrueOrFalseQuestion("The battle bus is yellow", false);
            Question question6 = new TrueOrFalseQuestion("Battle Royale was always Fortnite's main mode", false);
            Question question7 = new MultipleChoiceQuestion("Who is Beef Boss' rival?", _question7Answers, 1);
            Question question8 = new MultipleChoiceQuestion("What is the rarest item shop emote in Fortnite?", _question8Answers, 4);
            Question question9 = new MultipleChoiceQuestion("When did Fortnite come out?", _question9Answers, 2);

            _quizQuestions.Add(question1);
            _quizQuestions.Add(question2);
            _quizQuestions.Add(question3);
            _quizQuestions.Add(question4);
            _quizQuestions.Add(question5);
            _quizQuestions.Add(question6);
            _quizQuestions.Add(question7);
            _quizQuestions.Add(question8);
            _quizQuestions.Add(question9);



            Console.WriteLine("Welcome to the Fortnite Quiz!");
            Console.WriteLine("Press any key to begin...");
            Console.ReadKey(true);
            Console.Clear();

            for (int i = 0; i < _quizQuestions.Count; i++)
            {
                Console.WriteLine($"Current Score: {_score}/{_quizQuestions.Count}");
                Console.WriteLine($"Question #{i + 1}");
                _quizQuestions[i].Ask();
                _quizQuestions[i].CheckAnswer();

            }
            Console.WriteLine($"Final Score: {_score}/{_quizQuestions.Count}");
            Console.ReadKey();
        }

    }
}
