using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.Classes
{
    class FinalExam : Exam
    {
        public override void ShowExam()
        {
            int grade = 0;
            Console.WriteLine("Final Exam Started!");

            foreach (Question question in Questions)
            {
                Console.WriteLine(question.BodyOfQuestion);

                foreach (Answer answer in question.AnswerList)
                {
                    Console.WriteLine($"{answer.answerId}. {answer.answerText}");
                }

                Console.Write("Your Answer: ");
                int studentAnswer = int.Parse(Console.ReadLine());

                if (studentAnswer == question.RightAnswer.answerId)
                {
                    grade += question.marks;
                }

                Console.WriteLine();
            }

            Console.WriteLine($" Your Grade is  {grade}");
            Console.WriteLine($"Time is: { time}");
        }
    }
}
