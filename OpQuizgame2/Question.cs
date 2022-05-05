using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpQuizgame2
{
    internal class Question
    {
        public string Text { get; set; }
        public int Id { get; set; }
        public List<Answer> Answers { get; set; }

        public Question(string text, int id)
        {
            Text = text;
            Id = id;
            Answers = new List<Answer>();
        }

        public void AddAnswer(bool rightAnswer, string text)
        {
            Answers.Add(new Answer(text, rightAnswer));
        }

        public bool AskQuestion()
        {
            Console.WriteLine($"Spørsmål {Id}: {Text}");
            for (int i = 0; i < Answers.Count; i++)
            {
                var answerId = (char) (65 + i);
                Console.WriteLine($"{answerId}: {Answers[i].Text}");
            }
            var command = Console.ReadLine();
            if (command is null || command.Length != 1) return false;
            var index = Convert.ToChar(command.ToUpper()) - 65;
            if(index < 0 || index >= Answers.Count) return false;
            var answer = Answers[index];
            if (answer.IsCorrect)
            {
                Console.WriteLine($"{answer.Text} is Correct!!!");
                return true;
            }

            Console.WriteLine($"{answer.Text} is wrong ;(");
            return false;
        }
    }
}
