using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.Classes
{
    public abstract class Exam
    {
        public int time { get; set; }
        public int number_of_questions { get; set; }
        public Subject subject { get; set; }
        public Question[] Questions { get; set; }
        public abstract void ShowExam();
    }
}
