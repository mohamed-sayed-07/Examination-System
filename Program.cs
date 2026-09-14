
using Examination_System.Classes;

namespace Examination_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject1 = new Subject();

            Console.WriteLine("Enter Type Of Exam (1 Practical, 2 FinalExam):");
            int examType = Convert.ToInt32(Console.ReadLine());

            if (examType == 1)
            {
                subject1.CreateExam(new PracticalExam());
            }
            else if (examType == 2)
            {
                subject1.CreateExam(new FinalExam());
            }
            else
            {
                Console.WriteLine("Invalid Exam Type");
                return;
            }

            Console.Write("Please enter the time for the exam (30 to 180 minutes): ");
            int time = int.Parse(Console.ReadLine());

            Console.Write("Please enter the number of questions: ");
            int numberOfQuestions = int.Parse(Console.ReadLine());

            Question[] questionsArray = new Question[numberOfQuestions];

            for (int i = 0; i < numberOfQuestions; i++)
            {
                Console.WriteLine("Please choose question type:");
                Console.WriteLine("1. MCQ");
                Console.WriteLine("2. True / False");

                int questionType = int.Parse(Console.ReadLine());

                Console.Write("Enter question body: ");
                string body = Console.ReadLine();

                Console.Write("Enter question mark: ");
                int mark = int.Parse(Console.ReadLine());

                Question question = new Question();

                question.BodyOfQuestion = body;
                question.marks = mark;

                if (questionType == 1)
                {
                    // MCQ

                    Console.WriteLine("Choice of Question:");

                    Answer[] answer1 = new Answer[4];

                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write($"Enter Choice number {j + 1}: ");
                        string answertext = Console.ReadLine();

                        Answer answer = new Answer();

                        answer.answerId = j + 1;
                        answer.answerText = answertext;

                        answer1[j] = answer;
                    }

                    Console.WriteLine("Please enter Id for correct answer (1:4):");
                    int chooseanswer = int.Parse(Console.ReadLine());

                    question.RightAnswer = answer1[chooseanswer - 1];
                    question.AnswerList = answer1;
                }
                else if (questionType == 2)
                {
                    // True / False

                    Answer[] answer1 = new Answer[2];

                    answer1[0] = new Answer();
                    answer1[0].answerId = 1;
                    answer1[0].answerText = "True";

                    answer1[1] = new Answer();
                    answer1[1].answerId = 2;
                    answer1[1].answerText = "False";

                    Console.WriteLine("1. True");
                    Console.WriteLine("2. False");

                    Console.WriteLine("Please enter Id for correct answer (1:2):");
                    int chooseanswer = int.Parse(Console.ReadLine());

                    question.RightAnswer = answer1[chooseanswer - 1];
                    question.AnswerList = answer1;
                }
                // Store the question in the array
                questionsArray[i] = question;
            }

            // Store questions inside the exam
            subject1.ExamOfsubject.Questions = questionsArray;

            Console.WriteLine("Do you want to start exam (Y|N)?");
            string yn = Console.ReadLine();

            if (yn.Equals("Y", StringComparison.OrdinalIgnoreCase))
            {
                subject1.ExamOfsubject.ShowExam();
            }
            else
            {
                Console.WriteLine("Exam not started.");
            }
        }
    }
}
