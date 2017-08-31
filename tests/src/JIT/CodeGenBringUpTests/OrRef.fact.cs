using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _OrRef_OrRef_
    {
        [OuterLoop]
        [Fact]
        public void _OrRef_OrRef_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\OrRef\\OrRef.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
