using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _DblMulConst_DblMulConst_
    {
        [OuterLoop]
        [Fact]
        public void _DblMulConst_DblMulConst_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\DblMulConst\\DblMulConst.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
