using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _NotRMW_NotRMW_
    {
        [OuterLoop]
        [Fact]
        public void _NotRMW_NotRMW_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\NotRMW\\NotRMW.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
