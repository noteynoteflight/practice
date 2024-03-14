using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Groups.Tests
{
    public class StudentEntityTests
    {
        [Test]
        public void StudentEntity_ConstructsCorrectly()
        {
            var student = new StudentEntity();
            Assert.IsNotNull(student);
            Assert.IsNull(student.Name);
            Assert.AreEqual(0, student.Age);
            Assert.AreEqual(0, student.StudentId);
            Assert.IsNotNull(student.Subjects);
            Assert.AreEqual(0, student.Subjects.Count);
        }

        [Test]
        public void StudentEntity_StudentId_SetCorrectly()
        {
            var student = new StudentEntity();
            var studentId = 123;
            student.StudentId = studentId;
            Assert.AreEqual(studentId, student.StudentId);
        }
    }
