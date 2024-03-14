using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Groups.Tests
{
    [TestFixture]
    public class SubjectEntityTests
    {
        [Test]
        public void SubjectEntity_ConstructsCorrectly()
        {
            var subject = new SubjectEntity();
            Assert.IsNotNull(subject);
            Assert.IsNull(subject.Name);
            Assert.IsNull(subject.Teacher);
        }

    }
}
