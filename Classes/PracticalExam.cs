using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.Classes
{
    public class PracticalExam : Exam
    {
        public override void ShowExam()
        {
            Console.WriteLine("Practical Exam Started!");
            foreach (Question question in Questions)
            {
                Console.WriteLine(question.BodyOfQuestion);

                foreach (Answer answer in question.AnswerList)
                {
                    Console.WriteLine($"{answer.answerId}. {answer.answerText}");
                }

                Console.Write("Your Answer: ");
                Console.ReadLine();
            }

            Console.WriteLine("Exam Finished!");
            Console.WriteLine("Right Answers:");
        }
    }
}
