using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYZUniversity.Entities
{
    public class Student
    {
        public string studentName;
        private int subjectMarks1;
        private int subjectMarks2;
        private int subjectMarks3;
        public string result;

        public void SetMarks1(int m1)
        {
            if (m1 >= 1 && m1 <= 100)
                subjectMarks1 = m1;
            else
                throw new Exception("Invalid Subject 1 Marks");         
        }
        public int GetMarks1()
        {
            return subjectMarks1;
        }

        public void SetMarks2(int m1)
        {
            if (m1 >= 1 && m1 <= 100)
                subjectMarks2 = m1;
            else
                throw new Exception("Invalid Subject 2 Marks ");
        }
        public int GetMarks2()
        {
            return subjectMarks2;
        }

        public void SetMarks3(int m1)
        {
            if (m1 >= 1 && m1 <= 100)
                subjectMarks3 = m1;
            else
                throw new Exception("Invalid Subject 3 Marks ");
        }
        public int GetMarks3()
        {
            return subjectMarks3;
        }
    }
}