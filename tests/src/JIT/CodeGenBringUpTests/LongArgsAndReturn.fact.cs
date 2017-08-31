using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _LongArgsAndReturn_LongArgsAndReturn_
    {
        [OuterLoop]
        [Fact]
        public void _LongArgsAndReturn_LongArgsAndReturn_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\LongArgsAndReturn\\LongArgsAndReturn.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
