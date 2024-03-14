using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Groups.Tests
{
    [TestFixture]
    public class GroupManagerEntityTests
    {
        [Test]
        public void GroupManagerEntity_ConstructsCorrectly()
        {
            var groupManager = new GroupManagerEntity();

            Assert.IsNotNull(groupManager);
            Assert.IsNotNull(groupManager.Groups);
            Assert.AreEqual(0, groupManager.Groups.Count);
        }

        [Test]
        public void GroupManagerEntity_AddGroup_AddsCorrectly()
        {
            var groupManager = new GroupManagerEntity();
            var group = new GroupEntity();

            groupManager.AddGroup(group);

            Assert.AreEqual(1, groupManager.Groups.Count);
            Assert.IsTrue(groupManager.Groups.Contains(group));
        }

    }
}
