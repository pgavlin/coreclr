using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _JTrue1_JTrue1_
    {
        [OuterLoop]
        [Fact]
        public void _JTrue1_JTrue1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\JTrue1\\JTrue1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
