using NUnit.Framework;
using 

namespace Tests
{
    class TestKit
    {
        [Test]
        public void DAOEquals()
        {
            DAO dao = new DAO();
            int result = dao.dlug("abcde");
            Assert.That(result, Is.EqualTo(5));
        }
    }
}