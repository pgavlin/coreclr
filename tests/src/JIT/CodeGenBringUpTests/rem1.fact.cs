using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _rem1_rem1_
    {
        [OuterLoop]
        [Fact]
        public void _rem1_rem1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\rem1\\rem1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
