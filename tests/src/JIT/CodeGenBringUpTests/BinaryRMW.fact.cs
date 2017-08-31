using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _BinaryRMW_BinaryRMW_
    {
        [OuterLoop]
        [Fact]
        public void _BinaryRMW_BinaryRMW_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\BinaryRMW\\BinaryRMW.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
