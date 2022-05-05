using System;

namespace OpQuizgame2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var question = new Question("Fornavnet til Obama er?", 1);
            question.AddAnswer(true, "Barack");
            question.AddAnswer(false, "Brick");
            question.AskQuestion();

            var question2 = new Question("Fornavnet til Joe er?", 2);
            question2.AddAnswer(true, "Joe");
            question2.AddAnswer(false, "Mama");
            question2.AskQuestion();

            var question3 = new Question("Hvorfor kalles Kristian bleia", 3);
            question3.AddAnswer(false, "Fordi han bruker bleie");
            question3.AddAnswer(true, "Fordi Kristian er ung");
            question3.AddAnswer(false, "Fordi han er keeg");
            question3.AskQuestion();
        }
    }
}
