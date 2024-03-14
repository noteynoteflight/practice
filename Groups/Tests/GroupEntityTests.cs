using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Groups.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class GroupEntityTests
    {
        [Test]
        public void GroupEntity_ConstructsCorrectly()
        {
            var group = new GroupEntity();
            Assert.IsNotNull(group);
            Assert.IsNull(group.Name);
            Assert.IsNotNull(group.Students);
            Assert.AreEqual(0, group.Students.Count);
            Assert.IsNull(group.Teacher);
        }

        [Test]
        public void GroupEntity_Name_SetCorrectly()
        {
            var group = new GroupEntity();
            var groupName = "GroupA";
            group.Name = groupName;
            Assert.AreEqual(groupName, group.Name);
        }

    }
}
