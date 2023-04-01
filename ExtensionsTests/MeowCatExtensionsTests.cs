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
        public void IsSameType_SameType_ReturnsTrue()
        {
            var result = _weeeeps.IsSameType(_harryWinston);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsSameType_NotSameType_ReturnsFalse()
        {
            var result = _ethel.IsSameType(_weeeeps);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsSameAgeAndType_SameAgeAndType_ReturnsTrue()
        {
            var result = _lucipurr.IsSameAgeAndType(_ethel);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsSameAgeAndType_NotSameAgeAndType_ReturnsFalse()
        {
            var result = _harryWinston.IsSameAgeAndType(_weeeeps);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void GetInfo_ConsoleWrites_TestExplorer()
        {
            _spaceghost.GetInfo();
            _harryWinston.GetInfo();
            _lucipurr.GetInfo();
            _ethel.GetInfo();
            _weeeeps.GetInfo();
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