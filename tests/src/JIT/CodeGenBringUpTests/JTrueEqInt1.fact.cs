using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _JTrueEqInt1_JTrueEqInt1_
    {
        [OuterLoop]
        [Fact]
        public void _JTrueEqInt1_JTrueEqInt1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\JTrueEqInt1\\JTrueEqInt1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
