using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OpQuizgame2
{
    internal class Answer
    {
            public string Text { get; set; }
            public bool IsCorrect { get; set; }

            public Answer(string text, bool isCorrect)
            {
                Text = text;
                IsCorrect = isCorrect;
            }

    }
}
