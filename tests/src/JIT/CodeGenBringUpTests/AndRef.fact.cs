using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _AndRef_AndRef_
    {
        [OuterLoop]
        [Fact]
        public void _AndRef_AndRef_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\AndRef\\AndRef.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
