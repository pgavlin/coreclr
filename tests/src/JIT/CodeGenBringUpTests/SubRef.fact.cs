using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _SubRef_SubRef_
    {
        [OuterLoop]
        [Fact]
        public void _SubRef_SubRef_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\SubRef\\SubRef.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
