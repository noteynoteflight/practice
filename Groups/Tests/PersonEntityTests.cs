using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Groups.Tests
{
    [TestFixture]
    public class PersonEntityTests
    {
        [Test]
        public void Person_ConstructsCorrectly()
        {
            var person = new Person();
            Assert.IsNotNull(person);
            Assert.IsNull(person.Name);
            Assert.AreEqual(0, person.Age);
        }


    }
}
