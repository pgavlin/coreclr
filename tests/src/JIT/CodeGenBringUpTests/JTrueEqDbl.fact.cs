using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _JTrueEqDbl_JTrueEqDbl_
    {
        [OuterLoop]
        [Fact]
        public void _JTrueEqDbl_JTrueEqDbl_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\JTrueEqDbl\\JTrueEqDbl.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
