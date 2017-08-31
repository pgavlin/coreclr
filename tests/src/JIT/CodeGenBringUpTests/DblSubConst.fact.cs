using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _DblSubConst_DblSubConst_
    {
        [OuterLoop]
        [Fact]
        public void _DblSubConst_DblSubConst_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\DblSubConst\\DblSubConst.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
