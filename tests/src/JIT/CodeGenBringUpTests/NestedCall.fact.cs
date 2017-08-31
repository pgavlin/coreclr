using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _NestedCall_NestedCall_
    {
        [OuterLoop]
        [Fact]
        public void _NestedCall_NestedCall_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\NestedCall\\NestedCall.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
