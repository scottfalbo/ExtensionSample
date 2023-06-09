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

        [TestMethod]
        public void GetCattributeCount_ReturnsCorrectCount()
        {
            var expectedSpaceghost = 3;
            var actualSpaceghost = _spaceghost.GetCattributeCount();

            var expectedHarryWinston = 4;
            var actualHarryWinston = _harryWinston.GetCattributeCount();

            var expectedLucipurr = 3;
            var actualLucipurr = _lucipurr.GetCattributeCount();

            var expectedEthel = 3;
            var actualEthel = _ethel.GetCattributeCount();

            var expectedWeeeeps = 3;
            var actualWeeeeps = _weeeeps.GetCattributeCount();

            Assert.AreEqual(expectedSpaceghost, actualSpaceghost);
            Assert.AreEqual(expectedHarryWinston, actualHarryWinston);
            Assert.AreEqual(expectedLucipurr, actualLucipurr);
            Assert.AreEqual(expectedEthel, actualEthel);
            Assert.AreEqual(expectedWeeeeps, actualWeeeeps);
        }

        [TestMethod]
        public void GetSharedCattributesCount_ReturnCorrectCount_I()
        {
            var expected = 3;
            var actual = _ethel.GetSharedCattributesCount(_weeeeps);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetSharedCattributesCount_ReturnCorrectCount_II()
        {
            var expected = 2;
            var actual = _spaceghost.GetSharedCattributesCount(_lucipurr);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetSharedCattributesCount_ReturnCorrectCount_III()
        {
            var expected = 2;
            var actual = _harryWinston.GetSharedCattributesCount(_weeeeps);

            Assert.AreEqual(expected, actual);
        }

        [TestInitialize]
        public void TestInitialize()
        {
            var spaceshostCattributes = new string[] { Cattribute.PurrMonster, Cattribute.Handsome, Cattribute.CuddlePudding };
            _spaceghost = new MeowCat(name: "Spaceghost", age: 14, type: "Siamese", spaceshostCattributes);

            var harryWinstonCattributes = new string[] { Cattribute.PurrMonster, Cattribute.Handsome, Cattribute.CuddlePudding, Cattribute.Maniac };
            _harryWinston = new MeowCat(name: "Harry Winston", age: 14, type: "Fluffy", harryWinstonCattributes);

            var lucipurrCattributes = new string[] { Cattribute.PurrMonster, Cattribute.CuddlePudding, Cattribute.Terror };
            _lucipurr = new MeowCat(name: "Lucipurr", age: 7, type: "Tabby", lucipurrCattributes);

            var ethelCattributes = new string[] { Cattribute.PurrMonster, Cattribute.Maniac, Cattribute.Terror };
            _ethel = new MeowCat(name: "Ethel", age: 7, type: "Tabby", ethelCattributes);

            var weeeepsCattributes = new string[] { Cattribute.PurrMonster, Cattribute.Maniac, Cattribute.Terror };
            _weeeeps = new MeowCat(name: "Weeeeps", age: 2,  type: "Fluffy", weeeepsCattributes);
        }
    }
}