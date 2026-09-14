using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.Classes
{
    public class Question
    {
        public string HeaderOfQuestion { get; set; }
        public string BodyOfQuestion { get; set; }
        public int marks { get; set; }
        public Answer[] AnswerList { get; set; }
        public Answer RightAnswer { get; set; }
    }
}
