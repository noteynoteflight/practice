using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Groups.Tests
{
    [TestFixture]
    public class TeacherEntityTests
    {
        [Test]
        public void TeacherEntity_ConstructsCorrectly()
        {
            var teacher = new TeacherEntity();
            Assert.IsNotNull(teacher);
            Assert.IsNull(teacher.Name);
            Assert.AreEqual(0, teacher.Age);
            Assert.AreEqual(0, teacher.TeacherId);
            Assert.IsNotNull(teacher.Subjects);
            Assert.AreEqual(0, teacher.Subjects.Count);
        }
    }
}
