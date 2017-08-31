using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _JTrueNeInt1_JTrueNeInt1_
    {
        [OuterLoop]
        [Fact]
        public void _JTrueNeInt1_JTrueNeInt1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\JTrueNeInt1\\JTrueNeInt1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
