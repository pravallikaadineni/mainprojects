using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingProject;
using System.Runtime.InteropServices;

namespace TestingTest
{
    public class SchoolTest
    {
        Student s = new Student();
        Teacher t = new Teacher();
        Subject sub = new Subject();
        public SchoolTest()
        {
            s.FileRead();
        }
        [TestCase("sweety", ExpectedResult = true)]
        [TestCase("nani", ExpectedResult = true)]
        [TestCase("vaishu", ExpectedResult = false)]
        [TestCase("varun", ExpectedResult = false)]
        public bool FindStudent(string ans)
        {
            return s.SearchByName(ans);
        }
        [TestCase("Saleem sir", ExpectedResult = true)]
        [TestCase("neha", ExpectedResult = true)]
        [TestCase("harini", ExpectedResult = true)]
        [TestCase("swetha", ExpectedResult = false)]
        public bool FindTeacher(string ans)
        {
            return t.SearchByName(ans);
        }
        [TestCase("Maths", ExpectedResult = true)]
        [TestCase("sam", ExpectedResult = false)]
        [TestCase("Telugu", ExpectedResult = true)]
        [TestCase("Physics", ExpectedResult = false)]
        public bool FindSubject(string ans)
        {
            return sub.SearchByName(ans);
        }



    }
}

