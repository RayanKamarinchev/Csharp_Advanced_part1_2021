using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomProject
{
    class Classroom
    {
        public List<Student> Students { get; set; }
        public int Capacity { get; set; }
        public int Count { get; set; }

        public Classroom(int capacity)
        {
            Capacity = capacity;
            Students=new List<Student>();
        }

        public string RegisterStudent(Student student)
        {
            if (Capacity>=Count+1)
            {
                Count++;
                Students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }
            else
            {
                return "No seats in the classroom";
            }
        }

        public string DismissStudent(string firstName, string lastName)
        {
            Student kickedStudent = GetStudent(firstName, lastName);
            if (kickedStudent!=null)
            {
                Students.Remove(kickedStudent);
                Count--;
                return $"Dismissed student {firstName} {lastName}";
            }
            else
            {
                return "Student not found";
            }
        }

        public string GetSubjectInfo(string subject)
        {
            List<Student> pairs = new List<Student>();
            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].Subject==subject)
                {
                    pairs.Add(Students[i]);
                }
            }
            if (pairs.Count <= 0)
            {
                return "No students enrolled for the subject";
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Subject: {subject}");
                sb.AppendLine("Students:");
                for (int i = 0; i < pairs.Count; i++)
                {
                    sb.AppendLine($"{pairs[i].FirstName} {pairs[i].LastName}");
                }
                return sb.ToString();
            }
        }

        public int GetStudentsCount() => Count;

        public Student GetStudent(string firstName, string lastName)
        {
            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].FirstName==firstName&&
                    Students[i].LastName==lastName)
                {
                    return Students[i];
                }
            }
            return null;
        }
    }
}
