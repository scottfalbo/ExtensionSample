/// ------------------------------------
/// Basic use of Extensions sample code
/// ------------------------------------

using ExtensionCore.Extensions;
using ExtensionCore.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtentionTests
{
    [TestClass]
    public class MeowCatExtensionsTests
    {
        private MeowCat _spaceghost;
        private MeowCat _harryWinston;
        private MeowCat _lucipurr;
        private MeowCat _ethel;
        private MeowCat _weeeeps;

        [TestMethod]
        public void IsSameAge_SameAge_ReturnsTrue()
        {
            var result = _spaceghost.IsSameAge(_harryWinston);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsSameAge_NotSameAge_ReturnsFalse()
        {
            var result = _spaceghost.IsSameAge(_weeeeps);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsSameAge_SameType_ReturnsTrue()
        {
            var result = _weeeeps.IsSameType(_harryWinston);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsSameAge_NotSameType_ReturnsFalse()
        {
            var result = _ethel.IsSameAge(_weeeeps);
            Assert.IsFalse(result);
        }

        [TestInitialize]
        public void TestInitialize()
        {
            _spaceghost = new MeowCat("Spaceghost", 14, "Siamese");
            _harryWinston = new MeowCat("Harry Winston", 14, "Fluffy");
            _lucipurr = new MeowCat("Lucipurr", 7, "Tabby");
            _ethel = new MeowCat("Ethel", 7, "Tabby");
            _weeeeps = new MeowCat("Weeeeps", 2, "Fluffy");
        }

    }
}