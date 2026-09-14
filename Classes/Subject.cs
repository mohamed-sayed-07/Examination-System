using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.Classes
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam ExamOfsubject { get; set; }
        public void CreateExam(Exam ExamType)
        {
            ExamOfsubject = ExamType;
        }

    }
}
